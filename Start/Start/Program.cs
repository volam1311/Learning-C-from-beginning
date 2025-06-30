using System;
using Start.Math;
namespace Start
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    public class People
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phuc Lam Vo");
            int number = 5;
            Console.WriteLine(number);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); //format string
            const float Pi = 3.14f;
            Console.WriteLine(Pi);
            string s = "1.0";
            Console.WriteLine(float.Parse(s));
            try
            {
                var sr = "1234";
                Console.WriteLine(Convert.ToByte(sr));
            }
            catch (Exception)
            {
                Console.WriteLine("Why are you doing this");
            }
            var a = 1;
            var b = 2; 
            Console.WriteLine((float)a/(float)b);
            var c = 3;
            Console.WriteLine(!(c > b && c == a));

            var John = new Person();
            John.firstName = "john";
            John.lastName = "Smith";
            John.Introduce();
            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var names = new string[3] { "Jack", "John", "Sam" };
            Console.WriteLine(names[0]);

            string firstName = "Lam";
            var lastName = "Vo";
            //var fullName = firstName + " " + lastName;
            var fullName = string.Format("My name is {0} {1}",firstName,lastName);
            Console.WriteLine(fullName);

            var name = new string[3] {"John","Jack","Sam" };
            var formatted = string.Join(",", name);
            Console.WriteLine(formatted);

            //var path = "Look into the following path for the result:\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            //Console.WriteLine(path);

            var path1 = @"Look into the following path for the result:
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(path1);

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod),methodName); // Parse a string into the enum type

            // Value type:
            var x = 10;
            var y = x;
            y++;
            Console.WriteLine(string.Format("x: {0}, y: {1}",x,y));

            // Reference type: 
            var array_1 = new int[3] { 1, 2, 3 };
            var array_2 = array_1;
            array_2[0] = 0;
            Console.WriteLine(array_1[0]); // As array is a reference type, the data for this still change and affect the original one. This also happens in Python and Java.
            var num = 1;
            Increment(num);
            Console.WriteLine(num); // This does not change the value of the num variable as num is a value type and we allocate a position of it in the memory so it won't change. 

            var person = new People() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age); // This will change the value of Age in class People
        }
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(People person)
        {
            person.Age += 10;
        }
    }
}