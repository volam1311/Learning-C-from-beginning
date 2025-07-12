using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace Ex_StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new StopWatch();
            watch.Start();
            Thread.Sleep(1000);
            watch.Start();
            Thread.Sleep(2000);
            watch.Stop();
        }
    }
}