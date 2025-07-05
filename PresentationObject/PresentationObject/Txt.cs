using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationObject
{
    public class Txt : Obj
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
        public void AddHyperLink(string url)
        {
            Console.WriteLine("Added link" + url);
        }
    }
}
