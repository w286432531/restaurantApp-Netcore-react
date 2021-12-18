namespace restaurantApp.Models
{
    public class OrderItemAddOn
    {
        public int Id { get; set; }
        public int OrderedItemId { get; set; }
        public virtual OrderedItem OrderedItem { get; set; }
        public int AddOnId { get; set; }
        public virtual AddOn AddOn { get; set; }
    }
}