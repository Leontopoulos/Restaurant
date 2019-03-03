using System.Collections.Generic;

namespace RestaurantApp.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; } //null: 1 δεν εχει, 2 δεν το ξερω

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}