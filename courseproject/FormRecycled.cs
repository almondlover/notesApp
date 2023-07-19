using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotesAppLibrary;

namespace project1
{
    public partial class FormRecycled : Form
    {
        private List<Note> _recycled;
        public List<Note> restored=new List<Note>();
        public FormRecycled(List<Note> recycled)
        {
            InitializeComponent();
            _recycled = recycled;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRecycled.SelectedItem == null) { MessageBox.Show("Select a note you want to permanently delete first", "Warning"); return; }
            _recycled.RemoveAt(listBoxRecycled.SelectedIndex);
            listBoxRecycled.Items.Remove(listBoxRecycled.SelectedItem);
        }

        private void FormRecycled_Load(object sender, EventArgs e)
        {
            listBoxRecycled.Items.AddRange(_recycled.ToArray());
        }

        private void listBoxRecycled_DoubleClick(object sender, EventArgs e)
        {
            var obj = ((ListBox)sender).SelectedItem;
            if (obj == null) return;
            var note = (Note)obj;
            var fd = new FormDetails(false) { Note = note };
            fd.ShowDialog();
            if (fd.DialogResult == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
                restored.Add(note);
                _recycled.Remove(note);
                note.Recycled = false; 
            }
        }

        private void listBoxRecycled_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                buttonDelete_Click(sender, e);
        }
    }
}
