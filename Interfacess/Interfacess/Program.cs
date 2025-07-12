using System;
using System.Timers;
namespace Interfacess
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbmig = new DbMig(new ConsolorLogger());
            dbmig.Migrate();
            var dbMig_1 = new DbMig(new FileLogger("C:\\Documents:\\log.txt"));
            dbMig_1.Migrate();
        }
    }
}
