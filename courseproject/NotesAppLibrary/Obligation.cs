using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesAppLibrary
{
    [Serializable]
	public class Obligation:Note
	{

        public Obligation():base()
        { }
        public override double Importance()
		{
            if (DaysRemaining>8) return -1;
            return base.Importance()*_weight/(10*Math.Sqrt(1 + DaysRemaining));
		}
        public override bool IsPreoccupied(Note[] notes)
        {
            if (notes.Length < 1) return false;
            foreach (var note in notes)
                if (Math.Abs((_date-note.Date).TotalHours)<1) return true;
            return false;
        }

    }
}
