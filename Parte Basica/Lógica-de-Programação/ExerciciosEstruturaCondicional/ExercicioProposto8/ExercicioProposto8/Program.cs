using System.Globalization;

namespace ExercicioProposto8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário:");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double imposto;
            if (salario <= 2000.00)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.00)
            {
                imposto = (salario - 2000.00) * 0.08;
            }
            else if (salario <= 4500.00)
            {
                imposto = (1000.00 * 0.08) + (salario - 3000.00) * 0.18;
            }
            else
            {
                imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + (salario - 4500.00) * 0.28;
            }

            Console.WriteLine("O imposto foi de: R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
