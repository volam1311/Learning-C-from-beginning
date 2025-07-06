using System;
using Construtors;
using System.IO;
using System.Collections;
namespace Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            Construtors.Car car = new Construtors.Car("addd");

            Construtors.Text text = new Construtors.Text();

            Construtors.Shape shape = text;

            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width); // This will return 100 as shape is same as text

            //StreamReader reader = new StreamReader(new MemoryStream());

            ArrayList list = new ArrayList(); // ArrayList can takes on different elements
            list.Add(1);
            list.Add("Lam");
            list.Add(new Text());

            var anotherList = new List<int>(); // This only takes on some elements with same datatypes

            //var number = (int)list[1]; This will throw error
            //Console.WriteLine(number);

        }
    }
}