using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationObject
{
    public class Obj
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public void Copy()
        {
            Console.WriteLine("Object copied");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object duplicated");
        }
    }
}
