using BookStore.Models;

namespace BookStore.Helpers
{
    /// <summary>
    /// Provides methods for displaying orders in a simple table in the console.
    /// </summary>
    public static class ConsoleHelper
    {
        public static void WriteTableHeaderRow()
        {
            Console.WriteLine("{0,-60}{1,15}{2,15}", "Product", "Tax", "Line Total");
        }

        public static void WriteTableProductRow(OrderItem orderItem, decimal lineTax, decimal lineTotal)
        {
            Console.WriteLine("{0, -5}{1,-55}{2,15:C}{3,15:C}", $"{orderItem.Quantity}x", orderItem.Product, lineTax, lineTotal);
        }

        public static void WriteTableFeeRow(IOrderFee orderFee)
        {
            Console.WriteLine("{0, -5}{1,-70}{2,15:C}", "", orderFee, orderFee.GetFeeAmount());
        }

        public static void WriteOrderTotalRow(decimal orderTax, decimal orderTotal)
        {
            decimal orderTotalExcludingTax = orderTotal - orderTax;
            Console.WriteLine("\n{0,75}{1,15:C}\n{2,75}{3,15:C}\n{4,75}{5,15:C}",
                "Total (ex. Tax)", orderTotalExcludingTax,
                "Tax", orderTax,
                "Total", orderTotal);
        }
    }
}
