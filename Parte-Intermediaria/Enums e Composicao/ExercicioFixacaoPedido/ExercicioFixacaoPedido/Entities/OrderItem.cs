using System.Globalization;

namespace ExercicioFixacaoPedido.Entities
{
    class OrderItem
    {
        // Class OrderItem with properties Quantity and Price and constructors
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        // Method to calculate subTotal
        public double SubTotal()
        {
            return Quantity * Price;
        }

        // Override ToString method to display order item details
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
