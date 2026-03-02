using ExercicioTrabalhadorHeranca.Entities;
using System.Globalization;

namespace ExercicioTrabalhadorHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>(); // List of employees

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            // Read employee data
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Check if the employee is outsourced and create the appropriate object
                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }

                Console.WriteLine();
            }
            // Calling the payment method for each employee and print the results
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}