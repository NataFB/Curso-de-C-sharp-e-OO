using System.Globalization;
using FixacaoTax.Entities;

namespace FixacaoTax
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create a list to store the taxpayers
            List<Taxpayer> list = new List<Taxpayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                // Read the data of the taxpayer
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Create the taxpayer object type and add it to the list
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                else if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, annualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0.0;
            foreach (Taxpayer tp in list)
            {
                double tax = tp.Tax();
                Console.WriteLine($"{tp.Name}: $ {tax.ToString("F2", CultureInfo.InvariantCulture)}");
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}