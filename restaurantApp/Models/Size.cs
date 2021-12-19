using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace restaurantApp.Models
{
    public class Size
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<ItemSize> Item { get; set; }
#nullable enable
        public string? AlternativeName { get; set; }

    }
}
