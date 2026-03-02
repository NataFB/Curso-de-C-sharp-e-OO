using ExercicioFixacaoPedido.Entities;
using ExercicioFixacaoPedido.Entities.Enums;
using System.Globalization;
using System.Threading.Channels;

namespace ExercicioFixacaoPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the client
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Client client = new Client(name, email, birthDate);

            //Instantiate the order
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine();

            Order order = new Order(DateTime.Now, status, client);

            //Instantiate the products and order items, and add the items to the order
            Console.Write("How many items to this order? ");
            int itemsCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= itemsCount; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine();

                // The price of the order item is the same as the product price, because the OrderItem.price is the price of the product at the moment of the order.
                //This way, if the product price changes in the future, the order item price will not change.
                OrderItem orderItem = new OrderItem(quantity, productPrice, product); 

                order.AddItem(orderItem);
            }

            Console.WriteLine("Order Summary:");
            Console.WriteLine(order);
        }

    }
}