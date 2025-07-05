using System;
using System.Net.Http.Headers;

namespace PresentationObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance: 
            var obj = new Obj();
            var txt = new Txt();
            obj.Copy();
            txt.Copy(); // This method is inherited from the parent class.
            txt.AddHyperLink("abcdc");

            // Composition: 
            var dbmig = new DbMig(new Logger());
            var installer = new Installer(new Logger());

            dbmig.Migrate();
            installer.Install();

        }
    }
}