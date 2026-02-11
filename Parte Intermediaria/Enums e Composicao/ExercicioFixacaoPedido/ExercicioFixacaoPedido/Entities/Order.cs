using ExercicioFixacaoPedido.Entities.Enums;
using System.Globalization;
using System.Text;

namespace ExercicioFixacaoPedido.Entities
{
    class Order
    {
        // Properties
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>(); // Initialize the list of items

        // Constructors
        public Order() 
        { 
        }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }

        // Method to add an item to the order
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        //Remove item from the order
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        // Method to calculate the total price of the order
        public double Total()
        {
            double total = 0.0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        // Override ToString method to display order details
        //Using StringBuilder for better performance
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
