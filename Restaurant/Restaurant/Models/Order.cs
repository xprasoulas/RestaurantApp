using System;

namespace Restaurant.Models
{
    public class Order
    {
        public Int64 OrderID { get; set; }
        public int? CustomerID { get; set; }
        public string OrderNo { get; set; }
        public string PaymentMethod { get; set; }
        public decimal? GrandTotal { get; set; }
    }
}