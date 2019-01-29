using System.Collections.Generic;

namespace Restaurant.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }

        //1-N
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}