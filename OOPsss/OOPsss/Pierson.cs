using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsss
{
    public class Pierson
    {
        private DateTime _birthdate;
        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }
}
