using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            if(hour > 0 && hour < 12)
            {
                Console.WriteLine("it is morning");
            }
            else if(hour<18)
            {
                Console.WriteLine("It is the afternoon");
            }
            else
            {
                Console.WriteLine("it is the evening");
            }

            // Other ways for if else statement
            bool gold = true;
            var price = (gold) ? 19.95f : 5.5f;
            Console.WriteLine(price);

            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It is autumn");
                    break;
                case Season.Spring:
                    Console.WriteLine("It is spring");
                    break;
                case Season.Summer:
                    Console.WriteLine("It is summer");
                    break;
                default:
                    Console.WriteLine("It is winter");
                    break;
            } 
            
            for (var i =  1; i< 10; i++)
            {
                if(i%2 == 0)
                    Console.WriteLine(i);
            }
            // foreach loop 
            var name = "John Smith";
            //foreach(var cha in name)
            //{
            //    Console.WriteLine(cha);
            //}
            //var numbers = new int[] { 1, 2, 3, 4 };
            //foreach(var num in numbers)
            //{
            //    Console.WriteLine(string.Join(" ", num));
            //}
            //while (true)
            //{
            //    Console.WriteLine("Type your name");
            //    var input = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(input))
            //        break;
            //    Console.WriteLine("Echo: "+input);
            //}

            //var random = new Random();
            //for(var i = 0;i<10; i++)
            //    Console.WriteLine(random.Next(1,10)); // create random int numbers between 1 and 10

            //Console.WriteLine((int)'a'); //97 
            var random = new Random();
            //for (var i = 0; i< 10;i++)
            //{
            //    Console.WriteLine((char) random.Next(97,122));
            //}

            // or we can do this
            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine((char)('a'+random.Next(0, 26)));
            //}
            //const int len_word = 10;
            //var buffer = new char[len_word];
            //for(var i =0; i < len_word; i++)
            //{
            //    buffer[i] = (char) ('a' + random.Next(0, 26));
            //}
            //var password = new string(buffer);
            //Console.WriteLine(password);
            Console.WriteLine();
            // ex1:
            var cnt = 0;
            for (var i = 1; i<=100; i++)
            {
                if (i%3 == 0)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);

            //ex2:
            var sum = 0;
            while(true)
            {
                var input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }
                var num = int.Parse(input);
                sum += num;
                Console.WriteLine(sum);
            }
        }
    }
}