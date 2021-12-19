using System.Collections.Generic;

namespace restaurantApp.Models
{
    public class OrderedItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int ItemSizeId { get; set; }
        public virtual ItemSize ItemSize { get; set; }
#nullable enable
        public string? SpecialRequest { get; set; }
        public virtual List<OrderItemAddOn>? AddOns { get; set; }
    }
}