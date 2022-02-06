namespace BookStore.Models
{
    /// <summary>
    /// Represents a flat delivery fee for orders with a total price less than the defined threshold.
    /// </summary>
    public class OrderFeeDelivery : IOrderFee
    {
        /// <summary>
        /// Creates a new flat delivery fee, applicable to orders with a total price less than the given <paramref name="thresholdValue"/>.
        /// </summary>
        /// <param name="thresholdValue">This fee applies to orders with a total price less this threshold value.</param>
        /// <param name="feeAmount">The fee amount to apply if applicable.</param>
        public OrderFeeDelivery(decimal thresholdValue, decimal feeAmount)
        {
            // Set the threshold and amount for this fee
            ThresholdValue = thresholdValue;
            FeeAmount = feeAmount;
        }

        /// <summary>
        /// Stores the fee threshold. This fee applies to orders with a total price less than the defined threshold value.
        /// </summary>
        private decimal ThresholdValue;

        /// <summary>
        /// Stores the fee amount.
        /// </summary>
        private decimal FeeAmount;

        /// <inheritdoc/>
        public decimal GetFeeAmount()
        {
            // This is a flat fee, we just return the defined amount
            return FeeAmount;
        }

        /// <inheritdoc/>
        public bool CheckIfApplicable(decimal orderTotalIncludingTax)
        {
            return orderTotalIncludingTax < ThresholdValue;
        }

        public override string ToString()
        {
            return $"Delivery fee for orders under {ThresholdValue:C}";
        }
    }
}
