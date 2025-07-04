using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsss
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>(); // This means that the Orders can not be declared again
        //public Customer()
        //{
        //    Orders = new List<Order>(); // We declare an empty list for this one. 
        //}
        public Customer(int id) // before the id code is executed, it will run the new orders one first
        {
            this.Id = id;
        }
        // Overwriting the old constructor.
        public Customer(int id,string name)
            :this(id) // same apply to the name code.
        {
            //this.Id = id; 
            this.Name = name;
        }
        public void Promote()
        {
            //Orders = new List<Order> ();
        }
    }
}
