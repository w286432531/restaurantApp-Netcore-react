namespace restaurantApp.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public virtual Cart Cart { get; set; }
        public int ItemSizeId { get; set; }
        public virtual ItemSize ItemSize { get; set; }
    }
}