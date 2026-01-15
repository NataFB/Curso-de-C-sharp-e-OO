using System;
using System.Globalization;

namespace SaidadeDados  
{
    class Program
    {
        static void Main(string[] args)
        {

            double saldo = 10.35784;
            int idade = 32;
            string nome = "Maria";
            char genero = 'F';

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");
            Console.WriteLine("--------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(nome);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); //ponto como separador decimal ao invés de vírgula

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //interpolação de strings o $ com as chaves fazem a mesma coisa que o de cima
            Console.WriteLine("O valor do troco é " + saldo + " reais");
            Console.WriteLine("O valor do troco é " + saldo.ToString("F2",CultureInfo.InvariantCulture) + " reais"); //só é possivel fazer a formatação do ponto decimal nesse modelo de concatenação

            Console.WriteLine("A paciente " + nome + " tem " + idade + " anos e seu sexo é: " + genero);
        }
    }
}