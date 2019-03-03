using System.Collections.Generic;

namespace RestaurantApp.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}