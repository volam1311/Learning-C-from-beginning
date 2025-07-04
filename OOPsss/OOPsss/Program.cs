using OOPsss;
using System;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
namespace OPPsss
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Lam";
            person.Introduce("Nick");
            var p = Person.Parse("Polly");
            p.Introduce("Lam");

            // Constructor:
            var order = new Order();
            var customer = new Customer(123,"Lam");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            //customer.Orders.Add(order);

            UsePoints(); // call function

            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1,2,3,4));

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Wrong input type");
            }

            var cusom = new Customer(1);
            cusom.Orders.Add(new Order());
            Console.WriteLine(cusom.Orders.Count());

            // Encapsulation:
            var pierson = new Pierson();
            pierson.SetBirthDate(new DateTime(1992, 1, 1));
            Console.WriteLine(pierson.GetBirthDate());

            // Properties
            var pierson_1 = new Pierson_1();
            pierson_1.Birthdate = new DateTime(2006, 11, 13);
            Console.WriteLine(pierson_1.Age);
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                point.Move(null);
            }
            catch (Exception)
            {
                Console.WriteLine("an unexpected error");
            }
        }
    }
}
