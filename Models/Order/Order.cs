using BookStore.Helpers;

namespace BookStore.Models
{
    /// <summary>
    /// Represents a customer's order.
    /// This includes a collection of order items (<see cref="OrderItem"/>),
    /// any applicable taxes (<see cref="ITax"/>) and applicable fees (<see cref="IOrderFee"/>).
    /// </summary>
    public class Order : Entity
    {

        /// <summary>
        /// Collection of items on this order.
        /// </summary>
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        /// <summary>
        /// Collection of taxes for this order.
        /// </summary>
        public List<ITax> Taxes { get; set; } = new List<ITax>();

        /// <summary>
        /// Collection of order fees for this order.
        /// </summary>
        public List<IOrderFee> OrderFees { get; set; } = new List<IOrderFee>();
    }
}
