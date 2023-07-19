using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesAppLibrary
{
    [Serializable]
    public class Arrangement : Note
    {
        public Arrangement() : base()
        { }
        
        public override double Importance()
        {
            if (DaysRemaining > 1) return -1;
            return base.Importance()*Math.Sqrt(_weight/2)/(1+DaysRemaining);
        }
        public override bool IsPreoccupied(Note[] notes)
        {
            if (notes.Length < 1) return false;
            foreach (var note in notes)
                if (Math.Abs((_date - note.Date).TotalMinutes) < 30) return true;
            return false;
        }

    }
}
