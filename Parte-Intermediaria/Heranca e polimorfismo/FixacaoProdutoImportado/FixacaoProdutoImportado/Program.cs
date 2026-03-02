using System.Globalization;
using FixacaoProdutoImportado.Entities;

namespace FixacaoProdutoImportado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> Products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                // get common product data for all products
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // get specific data for Products based on its type and create the corresponding object

                if (type == 'i' || type == 'I')// imported product
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (type == 'u' || type == 'U') // used product
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else // common product
                {
                    Products.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in Products)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}