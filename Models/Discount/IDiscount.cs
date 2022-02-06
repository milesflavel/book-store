namespace BookStore.Models
{
    /// <summary>
    /// Represents a discount definition, providing methods to calculate discount prices according to the specified discount rules.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Tests whether this discount applies for the given <paramref name="product"/>
        /// and returns a <see cref="bool"/> indicating as such.
        /// </summary>
        /// <param name="product">The <see cref="Product"/> to test this discount against.</param>
        /// <returns><see cref="bool"/> indicating whether this discount applies for the given <paramref name="product"/>.</returns>
        public bool CheckIfApplicable(Product product);

        /// <summary>
        /// For a given <paramref name="basePrice"/>, calculate and return the discounted price.
        /// </summary>
        /// <param name="basePrice">The base price, before discount.</param>
        /// <returns>Discounted price as a <see cref="decimal"/>.</returns>
        public decimal CalculateDiscountPrice(decimal basePrice);

        /// <summary>
        /// For a given <paramref name="discountPrice"/>, calculate and return the base price.
        /// </summary>
        /// <param name="discountPrice">The discounted price, after discount.</param>
        /// <returns>Base price as a <see cref="decimal"/>.</returns>
        public decimal CalculateBasePrice(decimal discountPrice);
    }
}
