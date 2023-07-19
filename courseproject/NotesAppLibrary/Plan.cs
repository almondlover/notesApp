using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesAppLibrary
{
    [Serializable]
    public class Plan : Note
    {
        public Plan() : base()
        { }
        
        public override bool HasPassed()
        {
            if (base.Importance() <1) return _date < DateTime.Now;
            else return _date.AddDays(10 / base.Importance()) < DateTime.Now;
        }
        public override double Importance()
        {
            if (Math.Abs(DaysRemaining) > 4) return -1;
            return base.Importance() / (1 + Math.Abs(DaysRemaining));
        }
    }
}
