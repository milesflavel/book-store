namespace BookStore.Models
{
    /// <summary>
    /// Represents the base product class.
    /// </summary>
    public abstract class Product : Entity
    {
        /// <summary>
        /// Represents the price for a single unit of stock.
        /// </summary>
        public decimal UnitPrice { get; set; }
    }
}
