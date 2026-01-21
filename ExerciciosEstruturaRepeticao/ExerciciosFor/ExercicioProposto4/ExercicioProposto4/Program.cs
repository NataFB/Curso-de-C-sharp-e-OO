using System.Globalization;

namespace ExercicioProsposto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double resultado = (double)x / y;
                    Console.WriteLine(resultado.ToString("F1"), CultureInfo.InvariantCulture);
                }
            }
        }
    }
}