using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace restaurantApp.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<ItemIngredient> Items { get; set; }
#nullable enable
        public string? AlternativeName { get; set; }
    }
}