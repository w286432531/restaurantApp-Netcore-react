using System.ComponentModel.DataAnnotations;

namespace restaurantApp.Models
{
    public class ItemSize
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int SizeId { get; set; }
        public virtual Size Size { get; set; }
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        public decimal Price { get; set; }
    }
}