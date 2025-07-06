using System;
using Amazon;
namespace Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer  = new Customer(); 
            Amazon.Customer customer1 = new Amazon.Customer();
            // We cannot access the RateCalculator for now.
        }
    }
}