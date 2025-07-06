using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon; // We can use the Customer class from Amazon
namespace Inherit
{
    public class Customer
    {
        public int  Id { get; set; }
        public string Name { get; set; }    

        public void Promote() {
            var rating = CalculateRating();
            if (rating == 0)
            {
                Console.WriteLine("Promote level 1");
                Console.WriteLine("Promote level 2");
            }
        }
        protected int CalculateRating() { return 0; }  
    }
}
