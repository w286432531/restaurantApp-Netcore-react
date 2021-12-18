using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace restaurantApp.Models
{
    public class AddOn
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        public decimal Price { get; set; }
        public virtual List<OrderItemAddOn> OrderedItems { get; set; }
#nullable enable
        public string? AlternativeName { get; set; }
    }
}