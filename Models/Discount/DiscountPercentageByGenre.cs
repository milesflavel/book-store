namespace BookStore.Models
{
    /// <summary>
    /// Represents a percentage discount that applies to a specific genre.
    /// </summary>
    public class DiscountPercentageByGenre : IDiscount
    {
        /// <summary>
        /// Creates a new percentage discount, applicable to the specified <paramref name="genre"/>.
        /// </summary>
        /// <param name="discountPercentage"></param>
        /// <param name="genre"></param>
        public DiscountPercentageByGenre(decimal discountPercentage, string genre)
        {
            // Calculate the discount factor
            // This is a decimal multiplier with a value (0-1) that returns the discounted price when multiplied by, or base price when divided by
            // e.g. 10% discount  = 0.9 discount factor
            //      25% discount  = 0.75
            //      100% discount = 0.0
            //      0% discount   = 1.0
            DiscountFactor = (100m - discountPercentage) / 100m;

            // Set the genre for this discount
            Genre = genre;
        }

        /// <summary>
        /// Stores the discount factor. This is a multiplier calculated once, on construction of this class.
        /// </summary>
        private decimal DiscountFactor;

        /// <summary>
        /// Stores the applicable genre this discount applies to.
        /// </summary>
        private string Genre;

        /// <inheritdoc/>
        public bool CheckIfApplicable(Product product)
        {
            // Only applies for books
            if (product is Book book)
            {
                // Return true if the book's genre matches the discount's genre
                return book.Genre == Genre;
            }

            // Product is not a book, so this discount does not apply
            return false;
        }

        /// <inheritdoc/>
        public decimal CalculateBasePrice(decimal discountPrice)
        {
            return discountPrice / DiscountFactor;
        }

        /// <inheritdoc/>
        public decimal CalculateDiscountPrice(decimal basePrice)
        {
            return basePrice * DiscountFactor;
        }
    }
}
