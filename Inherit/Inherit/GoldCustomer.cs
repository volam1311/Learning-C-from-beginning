using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            this.CalculateRating(); // The protected means we can access the Calculate Rating from the class Customer.
            // However, when we only use the protected method if we really know that one method is stable on both its child and its parents.

        }
    }
}
