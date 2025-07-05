using OPPsss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsss
{
    public class Pierson_1
    {
        public DateTime Birthdate { get; private set; } // This will create a private field 

        public int Age // We use the get for this as people don't have to set their ages.
        {
            get { var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
        }
        public string Name { get; set; }  
        public Pierson_1 (DateTime birthdate)
        {
            Birthdate = birthdate;
        }
    }
}
