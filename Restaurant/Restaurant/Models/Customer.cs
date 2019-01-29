using System.Collections.Generic;

namespace Restaurant.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }

        //1-N
        public virtual ICollection<Order> Orders { get; set; }
    }
}