using System.Globalization;

namespace ExercicioProposto6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número com casas decimais (exemplo: 4.00):");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero >= 0 && numero <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero > 25 && numero <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero > 50 && numero <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (numero > 75 && numero <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
