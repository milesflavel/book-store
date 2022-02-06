namespace BookStore.Models
{
    /// <summary>
    /// Represents a tax definition, providing methods to calculate the tax amount
    /// and the corresponding tax component according to the specified rules.
    /// </summary>
    public interface ITax
    {
        /// <summary>
        /// For a given <paramref name="price"/>, calculate and return the tax amount.
        /// </summary>
        /// <param name="price">The input price, excluding tax.</param>
        /// <returns>Tax amount for the given <paramref name="price"/> as a <see cref="decimal"/>.</returns>
        public decimal CalculateTax(decimal price);

        /// <summary>
        /// For a given <paramref name="priceIncludingTax"/>, calculate and return the tax component.
        /// </summary>
        /// <param name="priceIncludingTax">The input price, including tax.</param>
        /// <returns>Tax component of the given <paramref name="priceIncludingTax"/> as a <see cref="decimal"/>.</returns>
        public decimal CalculateTaxComponent(decimal priceIncludingTax);
    }
}
