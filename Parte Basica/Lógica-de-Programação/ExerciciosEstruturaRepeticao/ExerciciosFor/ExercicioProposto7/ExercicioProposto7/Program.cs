namespace ExercicioProposto7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro positivo:");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                int quadrado = i * i;
                int cubo = i * i * i;
                Console.WriteLine($"Linha: {i}, Quadrado: {quadrado}, Cubo: {cubo}");
            }
        }
    }
}