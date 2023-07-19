using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using NotesAppLibrary;

namespace project1
{
    public partial class FormMain : Form
    {
        private List<Note> _notes = new List<Note>();
        public static List<Note> recyclednotes = new List<Note>(), upcoming = new List<Note>();

        public FormMain()
        {
            InitializeComponent();
            buttonAddObligation.Click += (sender, e) => buttonAdd_Click<Obligation>(sender, e, listBoxObligations);
            buttonAddArrangement.Click += (sender, e) => buttonAdd_Click<Arrangement>(sender, e, listBoxArrangements);
            buttonAddPlan.Click += (sender, e) => buttonAdd_Click<Plan>(sender, e, listBoxPlans);
            listBoxObligations.MouseDown += (sender, e) => listBoxNotes_ShowDetails(sender, e, richTextBoxObligations);
            listBoxArrangements.MouseDown += (sender, e) => listBoxNotes_ShowDetails(sender, e, richTextBoxArrangements);
            listBoxPlans.MouseDown += (sender, e) => listBoxNotes_ShowDetails(sender, e, richTextBoxPlans);
            listBoxObligations.SelectedIndexChanged += (sender, e) => listBoxNotes_ShowDetails(sender, e, richTextBoxObligations);
            listBoxArrangements.SelectedIndexChanged += (sender, e) => listBoxNotes_ShowDetails(sender, e, richTextBoxArrangements);
            listBoxPlans.SelectedIndexChanged += (sender, e) => listBoxNotes_ShowDetails(sender, e, richTextBoxPlans);
        }

        private void listBoxNotes_ShowDetails(object sender, EventArgs e, RichTextBox richTextBoxNote)
        {
            var lb = (ListBox)sender;
            if (lb.SelectedIndex < 0) return;
            richTextBoxNote.Text = ((Note)lb.SelectedItem).Details;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetUpcoming();
            var fn = new FormNotifications(upcoming);
            fn.ShowDialog();
        }
        private void listBoxNotes_DoubleClick(object sender, EventArgs e)
        {
            var obj = ((ListBox)sender).SelectedItem;
            if (obj == null) return;
            var fd = new FormDetails(true) { Note = (Note)obj };
            fd.ShowDialog();
            if (fd.DialogResult==DialogResult.OK) GetUpcoming();
        }
        private void buttonAdd_Click<T>(object sender, EventArgs e, ListBox lb) where T : Note, new()
        {
            if (_dboardEditEnter) {_dbc.ToggleDescriptionBoxesVisibility(); return; }
            var fd = new FormDetails(true);
            var note = new T();
            fd.Note = note;
            foreach (var note1 in _notes)
                if (note1.GetType().Name == note.GetType().Name) fd.currentnotes.Add(note1);
            fd.ShowDialog();
            if (fd.DialogResult == DialogResult.OK)
            {
                note.PriorityIndex = lb.Items.Count;
                lb.Items.Add(note);
                _notes.Add(note);
            }
            GetUpcoming();
        }


        private void listBoxNotes_KeyDown(object sender, KeyEventArgs e)
        {
            var lb = (ListBox)sender;
            var obj = lb.SelectedItem;
            var ind = lb.SelectedIndex;
            if (obj == null) return;
            if (e.KeyCode == Keys.Delete)
            {
                var note = (Note)obj;
                for (; ind < lb.Items.Count; ind++)
                    ((Note)lb.Items[ind]).PriorityIndex--;
                lb.Items.Remove(obj);
                recyclednotes.Add(note);
                note.Recycled = true;
                _notes.Remove(note);
                GetUpcoming();
            }
        }
        private object _dragDropItem;
        private ListBox _dragDropListBox;

        private void listBoxNotes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks > 1) return;
            _dragDropListBox = (ListBox)sender;
            _dragDropItem = _dragDropListBox.SelectedItem;
            if (_dragDropItem == null) return;
            _dragDropListBox.DoDragDrop(_dragDropItem, DragDropEffects.Move);
        }

        private void listBoxNotes_DragOver(object sender, DragEventArgs e)
        {
            if ((ListBox)sender == _dragDropListBox) e.Effect = DragDropEffects.Move;
        }
        private void listBoxNotes_DragDrop(object sender, DragEventArgs e)
        {
            var note = (Note)_dragDropItem;
            var point = _dragDropListBox.PointToClient(new Point(e.X, e.Y));
            var oldind = _dragDropListBox.SelectedIndex;
            var newind = _dragDropListBox.IndexFromPoint(point);
            if (newind < 0) newind = _dragDropListBox.Items.Count - 1;
            _dragDropListBox.Items.Remove(note);
            _dragDropListBox.Items.Insert(newind, note);
            note.PriorityIndex = newind;
            for (int ind = Math.Min(oldind, newind); ind <= Math.Max(oldind, newind); ind++)
                ((Note)_dragDropListBox.Items[ind]).PriorityIndex = ind;
        }
        private void DragDropFunctionality(Label lb, bool add)
        {
            if (add)
            {
                lb.MouseDown += label_MouseDown;
                lb.DragOver += label_DragOver;
                lb.DragDrop += label_DragDrop;
            }
            else
            {
                lb.MouseDown -= label_MouseDown;
                lb.DragOver -= label_DragOver;
                lb.DragDrop -= label_DragDrop;
            }
        }
        private Label _draggedLabel;
        private void label_DragDrop(object sender, DragEventArgs e)
        {
            int ind1=-1, ind2=-1;
            switch (_draggedLabel.Text)
            {
                case "Obligations": ind1 = 0; break;
                case "Arrangements": ind1 = 1; break;
                case "Plans": ind1 = 2; break;
            }
            switch (((Label)sender).Text)
            {
                case "Obligations": ind2 = 0; break;
                case "Arrangements": ind2 = 1; break;
                case "Plans": ind2 = 2; break;
            }
            _dbc.SwapTypeControlPlaces(ind1, ind2);
        }

        private void label_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            _draggedLabel = (Label)sender;
            _draggedLabel.DoDragDrop(_draggedLabel, DragDropEffects.Move);
        }
        DashboardControlInfo _dbci = null;
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            _notes.AddRange(recyclednotes);
            using (var fstream = new FileStream("NotesAppData", FileMode.Create))
                formatter.Serialize(fstream, _notes);
            _dbci = new DashboardControlInfo(_dbc);
            using (var fstream = new FileStream("DashboardData", FileMode.Create))
                formatter.Serialize(fstream, _dbci);
        }


        private void buttonRecycleBin_Click(object sender, EventArgs e)
        {
            var fr = new FormRecycled(recyclednotes);
            fr.ShowDialog();
            if (fr.DialogResult != DialogResult.OK) return;
            _notes.AddRange(fr.restored);
            foreach (var note in fr.restored)
            {
                switch (note.GetType().Name)
                {
                    case nameof(Obligation):
                    {
                        note.PriorityIndex = listBoxObligations.Items.Count;
                        listBoxObligations.Items.Add(note);
                    } break;
                    case nameof(Arrangement):
                    {
                        note.PriorityIndex = listBoxArrangements.Items.Count;
                        listBoxArrangements.Items.Add(note);
                    } break;
                    case nameof(Plan):
                    {
                        note.PriorityIndex = listBoxObligations.Items.Count;
                        listBoxPlans.Items.Add(note);
                    } break;
                }
            }
            GetUpcoming();
        }
        private void buttonRecycleBin_DragDrop(object sender, DragEventArgs e)
        {
            var note = (Note)_dragDropItem;
            note.Recycled = true;
            recyclednotes.Add(note);
            _notes.Remove(note);
            int ind = _dragDropListBox.SelectedIndex;
            _dragDropListBox.Items.Remove(note);
            for (; ind < _dragDropListBox.Items.Count; ind++)
                ((Note)_dragDropListBox.Items[ind]).PriorityIndex--;
            _dragDropItem = null;
            GetUpcoming();
        }

        private void buttonRecycleBin_DragOver(object sender, DragEventArgs e)
        {
            if (_dragDropItem == null) return;
            if (_draggedLabel==null) e.Effect = DragDropEffects.Move;
        }
        private void GetUpcoming()
        {
            upcoming = _notes
                .Where(note => note.Importance() >= 0)
                .Select(note => note)
                .OrderByDescending(note => note.Importance())
                .ToList();
            if (upcoming.Count==0) return;
            var mostImportant = upcoming
                .Where(note => note.Importance() == upcoming.Max(note1 => note1.Importance()))
                .First();
            mostImportant.GetNotificationColor(out int r, out int g);
            buttonNotifications.BackColor = Color.FromArgb(r, g, 0);
        }
        
        private DashboardCustomizationControl _dbc;
        private bool _dboardEditEnter = false;
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dboardEditEnter = true;
            ToggleUsability(Color.Aqua, _dboardEditEnter);
            _dragDropItem = null;

        }
        private void ToggleUsability(Color colorLabel, bool dboardEditEnter)
        {
            DragDropFunctionality(label1, dboardEditEnter);
            DragDropFunctionality(label2, dboardEditEnter);
            DragDropFunctionality(label3, dboardEditEnter);
            saveToolStripMenuItem.Visible = dboardEditEnter;
            label1.BackColor = colorLabel;
            label2.BackColor = colorLabel;
            label3.BackColor = colorLabel;
            listBoxObligations.Enabled = !dboardEditEnter;
            listBoxArrangements.Enabled = !dboardEditEnter;
            listBoxPlans.Enabled = !dboardEditEnter;
            buttonRecycleBin.Enabled = !dboardEditEnter;
            buttonNotifications.Enabled = !dboardEditEnter;
            buttonAddObligation.Text=dboardEditEnter?"Hide/Show":"Add";
            buttonAddArrangement.Text = dboardEditEnter ? "Hide/Show" : "Add";
            buttonAddPlan.Text = dboardEditEnter ? "Hide/Show" : "Add";
            comboBoxSearch.Enabled = !dboardEditEnter;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dboardEditEnter = false;
            _draggedLabel = null;
            ToggleUsability(Color.Transparent, _dboardEditEnter);

        }

        private void comboBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBoxSearch.SelectedItem != null) return;
            for (int i = comboBoxSearch.Items.Count - 1; i >= 0; i--)
                comboBoxSearch.Items.RemoveAt(i);
            var items = _notes
                .Where(note => note.Title.ToLower().Contains(comboBoxSearch.Text.ToLower()))
                .Select(note => note)
                .OrderByDescending(note => note.PriorityIndex)
                .ThenBy(note => note.Weight)
                .ToArray();
            if (items == null) { comboBoxSearch.DroppedDown = false; return; }
            comboBoxSearch.Items.AddRange(items);
            comboBoxSearch.DroppedDown = true;
            Cursor.Current = DefaultCursor;
        }

        private void comboBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            var item = ((ComboBox)sender).SelectedItem;
            if (e.KeyCode != Keys.Enter || item == null) return;
            var note = (Note)item;
            switch (note.GetType().Name)
            {
                case nameof(Obligation): listBoxObligations.SelectedItem=note; break;
                case nameof(Arrangement): listBoxArrangements.SelectedItem = note; break;
                case nameof(Plan): listBoxPlans.SelectedItem = note; break;
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
		{
            if (File.Exists("NotesAppData"))
			{
                IFormatter formatter = new BinaryFormatter();
                using (var fstream = new FileStream("NotesAppData", FileMode.Open))
					_notes = (List<Note>)formatter.Deserialize(fstream);
			}
            _dbc = new DashboardCustomizationControl()
            {
                lbType = new Label[] { label1, label2, label3 },
                lboxType = new ListBox[] { listBoxObligations, listBoxArrangements, listBoxPlans },
                rtbox = new RichTextBox[] { richTextBoxObligations, richTextBoxArrangements, richTextBoxPlans },
                bttnAdd = new Button[] { buttonAddObligation, buttonAddArrangement, buttonAddPlan },
                bttnNotis = buttonNotifications,
                bttnBin = buttonRecycleBin,
                form=this
            };
            if (File.Exists("DashBoardData"))
            {
                IFormatter formatter = new BinaryFormatter();
                using (var fstream = new FileStream("DashBoardData", FileMode.Open))
                    _dbci = (DashboardControlInfo)formatter.Deserialize(fstream);
            }
            if (_dbci!=null) _dbci.SetDbc(_dbc);
            for (int i=_notes.Count-1; i>=0; i--)
			{
				if (_notes[i].HasPassed()||_notes[i].Recycled)
				{
					recyclednotes.Add(_notes[i]);
                    _notes[i].Recycled = true;
					_notes.RemoveAt(i);
				}
				else
					switch (_notes[i].GetType().Name)
					{
						case nameof(Obligation): listBoxObligations.Items.Add(_notes[i]); break;
						case nameof(Arrangement): listBoxArrangements.Items.Add(_notes[i]); break;
						case nameof(Plan): listBoxPlans.Items.Add(_notes[i]); break;
					}
			}
            GetUpcoming();

        }
	}
}

