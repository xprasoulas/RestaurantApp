using System;
using System.Collections.Generic;

namespace Restaurant.Models
{
    public class Order
    {
        public Int64 OrderID { get; set; }
        public int? CustomerID { get; set; } //FK
        public string OrderNo { get; set; } //FK
        public string PaymentMethod { get; set; }
        public decimal? GrandTotal { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}