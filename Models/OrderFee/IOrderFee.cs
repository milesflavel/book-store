namespace BookStore.Models
{
    /// <summary>
    /// Represents an order fee definition, providing methods to determine if the fee applies according to the specified rules.
    /// </summary>
    public interface IOrderFee
    {
        /// <summary>
        /// Tests whether this order fee applies for the given <paramref name="orderTotalIncludingTax"/>
        /// and returns a <see cref="bool"/> indicating as such.
        /// </summary>
        /// <param name="orderTotalIncludingTax">The order total price to test this fee against.</param>
        /// <returns><see cref="bool"/> indicating whether this fee applies for the given <paramref name="order"/>.</returns>
        public bool CheckIfApplicable(decimal orderTotalIncludingTax);

        /// <summary>
        /// Returns the fee amount.
        /// </summary>
        /// <returns>Fee amount as a <see cref="decimal"/>.</returns>
        public decimal GetFeeAmount();
    }
}
