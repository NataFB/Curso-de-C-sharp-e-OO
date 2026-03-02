using System;
using System.Globalization;

namespace ExercicioProposto5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código da Primeira peça: ");
            int peca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade da Primeira peça: ");
            int qtd1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário da Primeira peça: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código da Segunda peça: ");
            int peca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade da Segunda peça: ");
            int qtd2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário da Segunda peça: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = (qtd1 * valor1) + (qtd2 * valor2);
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}