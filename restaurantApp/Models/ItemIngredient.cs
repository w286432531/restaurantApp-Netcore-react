namespace restaurantApp.Models
{
    public class ItemIngredient
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int IngredientId { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}