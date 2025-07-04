using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsss
{
    public class Pierson_1
    {
        public DateTime Birthdate { get; set; } // This will create a private field 

        public int Age
        {
            get { var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
        }
    }
}
