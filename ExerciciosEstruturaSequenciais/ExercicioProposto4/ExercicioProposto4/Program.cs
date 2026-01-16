using System;
using System.Globalization;

namespace ExercicioProposto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o número do funcionário:");
            int Funcionario = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o número de horas trabalhadas:");
            int Horas = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor que recebe por hora:");
            double ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Salario = Horas * ValorHora;
            Console.WriteLine("Funcionado: " + Funcionario);
            Console.WriteLine("Salário: R$ " + Salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}