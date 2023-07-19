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
    public partial class FormDetails : Form
    {
        private Note _note;
        public List<Note> currentnotes=new List<Note>();
        private bool _editable;
        public Note Note
        {
            get {return  _note; }
            set
            {
                _note = value;
                textBox1.Text = _note.Title;
                richTextBox1.Text = _note.Details;
                trackBarWeight.Value = _note.Weight;
                dateTimePicker1.Value = _note.Date;
            }
        }
        public FormDetails(bool editable)
        {
            InitializeComponent();
            _editable = editable;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Edit") { dateTimePicker1.Enabled = true; richTextBox1.ReadOnly = false; button1.Text = "Restore"; return; }
            Note.Title=textBox1.Text;
            if (Note.Title==""||dateTimePicker1.Value<DateTime.Now) { MessageBox.Show("Invalid data! You need to title your notes and date them appropriately", "Warning"); return; }
            Note.Date=dateTimePicker1.Value; 
            if (Note.IsPreoccupied(currentnotes.ToArray())) { MessageBox.Show("Invalid data! Selected time is too busy!", "Warning"); return; }
            Note.Details=richTextBox1.Text;
            Note.Weight=trackBarWeight.Value;
            DialogResult = DialogResult.OK;
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            if (!_editable)
            {
                richTextBox1.ReadOnly = true;
                textBox1.ReadOnly = true;
                dateTimePicker1.Enabled = false;
                trackBarWeight.Enabled = false;
                button1.Text = "Edit";
            }
            if (textBox1.Text!="") textBox1.Enabled = false;
        }
    }
}
