using System.Globalization;

namespace ExercicioFixacaoEstatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar atualmente? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorEmReais = ConversordeMoeda.ConversorParaReais(cotacao, quantidade);

            Console.WriteLine($"Valor a ser pago em reais = {valorEmReais.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}