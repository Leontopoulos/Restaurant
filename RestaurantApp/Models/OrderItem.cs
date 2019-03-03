using System;

namespace RestaurantApp.Models
{
    public class OrderItem
    {
        public Int64 OrderItemID { get; set; }
        public Int64 OrderID { get; set; }
        public int? ItemID { get; set; }
        public int? Quuantity { get; set; }

        public Order Order { get; set; }
        public Item Item { get; set; }
    }
}