using System;

namespace TipodeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos de dados primitivos em C#
            int numeroInteiro = 42; // Tipo inteiro
            double numeroDecimal = 3.14; // Tipo ponto flutuante
            float numeroFloat = 2.71f; // Tipo ponto flutuante de precisão simples
            long numeroLongo = 1234567890L; // Tipo longo
            char caractere = 'A'; // Tipo caractere
            string texto = "Olá, Mundo!"; // Tipo string
            bool booleano = true; // Tipo booleano
            object objeto = "Alex"; // Tipo objeto, tipo genérico que pode armazenar qualquer tipo de dado
            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            decimal n4 = decimal.MaxValue;

            // Exibindo os valores na tela
            Console.WriteLine("Número Inteiro: " + numeroInteiro);
            Console.WriteLine("Número Decimal: " + numeroDecimal);
            Console.WriteLine("Caractere: " + caractere);
            Console.WriteLine("Texto: " + texto);
            Console.WriteLine("Booleano: " + booleano);
            Console.WriteLine("Número Float: " + numeroFloat);
            Console.WriteLine("Número Longo: " + numeroLongo);
            Console.WriteLine("Objeto: " + objeto);
            Console.WriteLine("Valor mínimo de int: " + n1);
            Console.WriteLine("Valor máximo de int: " + n2);
            Console.WriteLine("Valor mínimo de sbyte: " + n3);
            Console.WriteLine("Valor máximo de decimal: " + n4);
        }
    }
}