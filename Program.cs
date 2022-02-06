using BookStore.Helpers;
using BookStore.Models;

// Retrieve all the products, taxes, discounts and fees for the store
List<Product> products = StoreHelper.GetProducts();
List<ITax> taxes = StoreHelper.GetDefaultTaxes();
List<IDiscount> discounts = StoreHelper.GetCurrentDiscounts();
List<IOrderFee> orderFees = StoreHelper.GetDefaultOrderFees();

// Create the order
// This should come from a database according to user actions
var order = new Order();
order.OrderItems.Add(new OrderItem
{
    // Unsolved murders
    Product = products.FirstOrDefault(x => x.Id == Guid.Parse("862029c3-5531-4cf0-b396-1d4ad5898297")),
    Quantity = 1
});
order.OrderItems.Add(new OrderItem
{
    // A Little Love Story
    Product = products.FirstOrDefault(x => x.Id == Guid.Parse("f0840d21-1cc8-4a39-9e07-33ab68730db2")),
    Quantity = 1
});
order.OrderItems.Add(new OrderItem
{
    // Heresy
    Product = products.FirstOrDefault(x => x.Id == Guid.Parse("44a7f0a7-d28e-42b0-ace6-34b3569f673a")),
    Quantity = 1
});
order.OrderItems.Add(new OrderItem
{
    // Jack the Ripper
    Product = products.FirstOrDefault(x => x.Id == Guid.Parse("dc9e5069-3412-4037-bad3-e94077f493ba")),
    Quantity = 1
});
order.OrderItems.Add(new OrderItem
{
    // The Tolkien Years
    Product = products.FirstOrDefault(x => x.Id == Guid.Parse("4fcdeaaf-79fb-4e59-93b5-cf72443655e2")),
    Quantity = 1
});

// Add the default store taxes to the order
order.Taxes.AddRange(taxes);

// Define the running total of the order
decimal orderTotal = 0m;

// Write the table header
ConsoleHelper.WriteTableHeaderRow();

// Loop over the order items, calculating the line total and order total
// according to unit price, quantity, taxes and applicable discounts
foreach (OrderItem orderItem in order.OrderItems)
{
    // Check for a valid quantity before handling this order item
    if (orderItem.Quantity <= 0)
    {
        continue;
    }

    // The initial line total is Unit Price * Quantity
    decimal lineTotal = orderItem.Product.UnitPrice * orderItem.Quantity;

    // Calculate the total tax for this line
    foreach (ITax tax in order.Taxes)
    {
        lineTotal += tax.CalculateTax(lineTotal);
    }

    // Apply discounts after tax has been applied
    foreach (IDiscount discount in discounts)
    {
        // Only apply the discount if applicable
        if (discount.CheckIfApplicable(orderItem.Product))
        {
            // Set the line total to the new discounted price
            lineTotal = discount.CalculateDiscountPrice(lineTotal);

            // Add this discount to the order item
            // This should really be a read-only copy of the discount,
            // so that the saved order doesn't change if the discount is updated
            orderItem.Discounts.Add(discount);
        }
    }
    
    // Value to store the tax component for this line
    decimal lineTax = 0m;

    // Determine the the total tax for this line after discounts
    foreach (ITax tax in order.Taxes)
    {
        lineTax += tax.CalculateTaxComponent(lineTotal);
    }

    // Add the line total to the order total
    orderTotal += lineTotal;

    // Write the table product row
    ConsoleHelper.WriteTableProductRow(orderItem, lineTax, lineTotal);
}

// Check if any order fees apply
foreach (IOrderFee orderFee in orderFees)
{
    // Only apply the order fee if applicable
    if (orderFee.CheckIfApplicable(orderTotal))
    {
        // Set the line total to the new discounted price
        orderTotal += orderFee.GetFeeAmount();

        // Add this order fee to the order
        // This should really be a read-only copy of the fee,
        // so that the saved order doesn't change if the fee is updated
        order.OrderFees.Add(orderFee);

        // Write the table fee row
        ConsoleHelper.WriteTableFeeRow(orderFee);
    }
}

// Define the running total of the order tax
// This isn't calculated until the end, as discounts and fees affect the outcome
decimal orderTax = 0m;

// Calculate the total tax on this order
// This is the inverse of the per-product taxes, as discounts and fees have since been applied
foreach (ITax tax in order.Taxes)
{
    orderTax += tax.CalculateTaxComponent(orderTotal);
}

// Write the total prices
ConsoleHelper.WriteOrderTotalRow(orderTax, orderTotal);