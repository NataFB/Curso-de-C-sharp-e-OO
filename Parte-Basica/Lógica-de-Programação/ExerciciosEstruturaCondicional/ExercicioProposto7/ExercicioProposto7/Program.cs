using System.Globalization;

namespace ExercicioProposto7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do eixo X:");
            double EixoX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor do eixo Y:");
            double EixoY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (EixoX == 0 && EixoY == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (EixoX == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (EixoY == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (EixoX > 0 && EixoY > 0)
            {
                Console.WriteLine("Quadrante Q1");
            }
            else if (EixoX < 0 && EixoY > 0)
            {
                Console.WriteLine("Quadrante Q2");
            }
            else if (EixoX < 0 && EixoY < 0)
            {
                Console.WriteLine("Quadrante Q3");
            }
            else
            {
                Console.WriteLine("Quadrante Q4");

            }
        }
    }
}
