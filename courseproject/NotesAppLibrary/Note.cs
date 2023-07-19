using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesAppLibrary
{
	[Serializable]
	public class Note
	{
		private string _title;
		protected DateTime _date;
		private string _details;
		protected int _priorityIndex;
		protected int _weight;
		public int PriorityIndex 
		{
			get { return _priorityIndex; }
			set { _priorityIndex = value; }
		}
		public int Weight { get { return _weight; } set { _weight = value; } }
		public DateTime Date { get { return _date; } set { _date = value; } }
		public int DaysRemaining { get { return (int)(_date-DateTime.Now).TotalDays; } }
        public bool Recycled { get; set; }
        public virtual bool HasPassed()
		{
			return _date < DateTime.Now;
		}
		public string Title 
		{ 
			get { return _title; } 
			set
			{
                _title = "";
                var s=value.Trim(' ').Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                value= string.Join(" ", s);
                bool first = true;
                var marks = ".,;:";
                for (int i=0; i<value.Length;  i++)
                {
                    if (marks.Contains(value[i].ToString()) && first) continue;
                    if (first && value[i] >= 'a' && value[i] <= 'z') { first = false;  _title += char.ToUpper(value[i]); first = false; continue; }
                    first = false;
                    _title += value[i];
                }
			} 
		}
		public string Details 
		{ 
			get { return _details; } 
			set { if (value == "") _details = "No description available"; else _details = value; }
		}
        public Note()
		{ 
			_date = DateTime.Now;
            _priorityIndex = 0;
            Recycled = false;

		}
		public virtual double Importance()
		{
			return _weight / (10+_priorityIndex);
		}
        public void GetNotificationColor(out int red, out int green)
        {
            int maxColorValue = 192 + ((DaysRemaining + 1) / 10) * 163;
			double tempColorValue = (2*maxColorValue )* Importance() / 100;

			red = tempColorValue > maxColorValue ? maxColorValue: (int)tempColorValue;
			green = tempColorValue > maxColorValue ? 2*maxColorValue-(int)tempColorValue: maxColorValue;
		}
        public virtual bool IsPreoccupied(Note[] notes)
        {
            if (notes.Length<1) return false;
            foreach (var note in notes)
                if (_date == note.Date) return true;
            return false;
        }
        public override string ToString()
        {
			return _title;
        }

    }
}
