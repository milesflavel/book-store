namespace BookStore.Models
{
    /// <summary>
    /// Represents a product line item on an order.
    /// </summary>
    public class OrderItem : Entity
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Collection of discounts for this order item.
        /// </summary>
        public List<IDiscount> Discounts { get; set; } = new List<IDiscount>();
    }
}
