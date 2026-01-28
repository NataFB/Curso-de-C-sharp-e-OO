using System.Globalization;

namespace Vetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];

            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vetor[i];
            }

            double media = soma / n;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}