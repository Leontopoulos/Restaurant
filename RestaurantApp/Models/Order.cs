using System;
using System.Collections.Generic;

namespace RestaurantApp.Models
{
    public class Order
    {
        public Int64 OrderID { get; set; }            //big int γτ θα απειρες παραγγελιες
        public int? CustomerID { get; set; }
        public string OrderNo { get; set; }
        public string PaymentMethod { get; set; }
        public decimal? GrandTotal { get; set; }

        public Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}