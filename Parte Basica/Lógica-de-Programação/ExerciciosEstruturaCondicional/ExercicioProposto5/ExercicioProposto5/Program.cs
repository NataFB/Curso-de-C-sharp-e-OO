using System;
using System.Globalization;

namespace ExercicioProposto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do item que deseja selecionar:");
            Console.WriteLine("1 - Cachorro Quente R$4.00");
            Console.WriteLine("2 - X-Salada R$4.50");
            Console.WriteLine("3 - X-Bacon R$5.00");
            Console.WriteLine("4 - Torrada Simples R$2.00");
            Console.WriteLine("5 - Refrigerante R$1.50");
            int ItemNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade desejada:");
            int Quantidade = int.Parse(Console.ReadLine());

            if (ItemNumero == 1)
            {
                double Total = Quantidade * 4.00;
                Console.WriteLine("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (ItemNumero == 2)
            {
                double Total = Quantidade * 4.50;
                Console.WriteLine("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (ItemNumero == 3)
            {
                double Total = Quantidade * 5.00;
                Console.WriteLine("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (ItemNumero == 4)
            {
                double Total = Quantidade * 2.00;
                Console.WriteLine("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (ItemNumero == 5)
            {
                double Total = Quantidade * 1.50;
                Console.WriteLine("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Número do item inválido.");
            }
        }
    }
}