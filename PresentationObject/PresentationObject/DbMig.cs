using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationObject
{
    public class DbMig
    {
        private readonly Logger _logger;
        public DbMig(Logger logger)
        {
            _logger = logger; 
        }
        public void Migrate()
        {
            _logger.Log("We are doing sth here");
        }
    }
}
