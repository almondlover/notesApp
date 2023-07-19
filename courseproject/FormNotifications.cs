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
	public partial class FormNotifications : Form
	{
		private List<Note> _upcoming = new List<Note>();
		public FormNotifications(List<Note> upcoming)
		{
			InitializeComponent();
            _upcoming = upcoming;
		}

		private void FormNotifications_Load(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			if (_upcoming == null) return;
			for (int i=0; i<_upcoming.Count; i++)
			{
                (listView1.Items.Add(_upcoming[i].Title)).SubItems.Add(_upcoming[i].DaysRemaining.ToString());
                _upcoming[i].GetNotificationColor(out int r, out int g);
				listView1.Items[i].BackColor = Color.FromArgb(r, g, 0);
			}
		}
    }
}
