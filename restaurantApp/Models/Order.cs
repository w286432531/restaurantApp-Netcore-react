using System;
using System.Collections.Generic;

namespace restaurantApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual List<OrderedItem> Items { get; set; }
        
    }
}