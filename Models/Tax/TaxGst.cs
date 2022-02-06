namespace BookStore.Models
{
    /// <summary>
    /// Represents a Goods &amp; Services Tax with a constant percentage value.
    /// </summary>
    public class TaxGst : ITax
    {
        /// <summary>
        /// Stores the constant GST value.
        /// </summary>
        private const decimal GstPercentage = 10;

        /// <summary>
        /// For a given <paramref name="price"/>, calculate and return the tax amount
        /// according to the defined <see cref="GstPercentage"/>.
        /// </summary>
        /// <param name="price"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public decimal CalculateTax(decimal price)
        {
            // Calculate and return the appropriate tax amount according to the given price and defined GST percentage
            return price * GstPercentage / 100m;
        }

        /// <summary>
        /// For a given <paramref name="priceIncludingTax"/>, calculate and return the tax component
        /// according to the defined <see cref="GstPercentage"/>.
        /// </summary>
        /// <param name="price"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public decimal CalculateTaxComponent(decimal priceIncludingTax)
        {
            // Calculate and return the tax component of the given price and defined GST percentage
            return priceIncludingTax - (priceIncludingTax / (1m + (GstPercentage / 100m)));
        }
    }
}
