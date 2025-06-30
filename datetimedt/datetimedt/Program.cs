using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace datetimedt
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2024, 11, 13);
            var curr = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(curr.Hour);
            Console.WriteLine(curr.Minute);

            var tomorrow = curr.AddDays(1);
            var yesterday = curr.AddDays(-1);
            Console.WriteLine(curr.ToLongDateString());
            Console.WriteLine(curr.ToShortDateString());
            Console.WriteLine(curr.ToString("yyyy-dd-MM"));

            var timespan = new TimeSpan(1, 2, 3);
            var timespan1 = new TimeSpan(1, 0, 0);
            var timespan2 = TimeSpan.FromHours(1);        

            var start  = DateTime.Now;
            var end = start.AddMinutes(2);
            Console.WriteLine(end - start);
            Console.WriteLine(timespan.TotalMinutes);
            Console.WriteLine(TimeSpan.Parse("01:01:01"));
        }
    }
}