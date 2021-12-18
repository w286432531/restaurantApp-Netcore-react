using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace restaurantApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<ItemIngredient> Ingredients { get; set; }
        public virtual List<OrderedItem> Orders { get; set; }
        public virtual List<CartItem> Carts { get; set; }
#nullable enable
        public string? AlternativeName { get; set; }
    }
}
