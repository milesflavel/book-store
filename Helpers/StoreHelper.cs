using BookStore.Models;

namespace BookStore.Helpers
{
    /// <summary>
    /// Static helper acting as a rudimentary source of data for the store.
    /// Provides methods for retrieving products, discounts, taxes and fees.
    /// In a real implementation, this would be replaced with an EF repository.
    /// </summary>
    public static class StoreHelper
    {
        /// <summary>
        /// Retrieve a collection of all the products available at the store.
        /// </summary>
        /// <returns>
        /// <see cref="List{Product}"/> containing all the products.
        /// </returns>
        public static List<Product> GetProducts()
        {
            // Create the return object
            var products = new List<Product>();

            // Add the products
            products.Add(new Book
            {
                Id = Guid.Parse("862029c3-5531-4cf0-b396-1d4ad5898297"),
                Title = "Unsolved murders",
                Author = "Emily G. Thompson, Amber Hunt",
                Genre = "Crime",
                UnitPrice = 10.99m
            });
            products.Add(new Book
            {
                Id = Guid.Parse("989a8a70-a843-4afb-8e81-a5e2c0a6b626"),
                Title = "Alice in Wonderland",
                Author = "Lewis Carroll",
                Genre = "Fantasy",
                UnitPrice = 5.99m
            });
            products.Add(new Book
            {
                Id = Guid.Parse("f0840d21-1cc8-4a39-9e07-33ab68730db2"),
                Title = "A Little Love Story",
                Author = "Roland Merullo",
                Genre = "Romance",
                UnitPrice = 2.40m
            });
            products.Add(new Book
            {
                Id = Guid.Parse("44a7f0a7-d28e-42b0-ace6-34b3569f673a"),
                Title = "Heresy",
                Author = "S J Parris",
                Genre = "Fantasy",
                UnitPrice = 6.80m
            });
            products.Add(new Book
            {
                Id = Guid.Parse("f0840d21-1cc8-4a39-9e07-33ab68730db2"),
                Title = "The Neverending Story",
                Author = "Michael Ende",
                Genre = "Fantasy",
                UnitPrice = 7.99m
            });
            products.Add(new Book
            {
                Id = Guid.Parse("dc9e5069-3412-4037-bad3-e94077f493ba"),
                Title = "Jack the Ripper",
                Author = "Philip Sugden",
                Genre = "Crime",
                UnitPrice = 16.00m
            });
            products.Add(new Book
            {
                Id = Guid.Parse("4fcdeaaf-79fb-4e59-93b5-cf72443655e2"),
                Title = "The Tolkien Years",
                Author = "Greg Hildebrandt",
                Genre = "Fantasy",
                UnitPrice = 22.90m
            });


            // Return the list of products
            return products;
        }

        /// <summary>
        /// Retrieve a collection of all the valid discounts that currently apply for the store.
        /// These are applied to new orders as they're created.
        /// </summary>
        /// <returns>
        /// <see cref="List{IDiscount}"/> containing all currently valid discounts.
        /// </returns>
        public static List<IDiscount> GetCurrentDiscounts()
        {
            // Create the return object
            var currentDiscounts = new List<IDiscount>();

            // Add the current discounts
            currentDiscounts.Add(new DiscountPercentageByGenre(5, "Crime"));

            // Return the list of current discounts
            return currentDiscounts;
        }

        /// <summary>
        /// Retrieve a collection of all the default taxes that apply for the store.
        /// </summary>
        /// <returns>
        /// <see cref="List{ITax}"/> containing all the default taxes.
        /// </returns>
        public static List<ITax> GetDefaultTaxes()
        {
            // Create the return object
            var defaultTaxes = new List<ITax>();

            // Add the default taxes
            defaultTaxes.Add(new TaxGst());

            // Return the list of default taxes
            return defaultTaxes;
        }

        /// <summary>
        /// Retrieve a collection of all the default order fees that apply for the store.
        /// </summary>
        /// <returns>
        /// <see cref="List{IOrderFee}"/> containing all the default order fees.
        /// </returns>
        public static List<IOrderFee> GetDefaultOrderFees()
        {
            // Create the return object
            var defaultOrderFees = new List<IOrderFee>();

            // Add the default order fees
            defaultOrderFees.Add(new OrderFeeDelivery(20m, 5.95m));

            // Return the list of default order fees
            return defaultOrderFees;
        }
    }
}
