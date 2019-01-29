using System;

namespace Restaurant.Models
{
    public class OrderItem
    {
        public Int64 OrderItemID { get; set; }
        public Int64 OrderID { get; set; }
        public int? ItemId { get; set; }
        public int? Quantity { get; set; }

        //Navigation Properties-for a specific Order/Item the Quantity that Odered
        public Order Order { get; set; }
        public Item Item { get; set; }
    }
}