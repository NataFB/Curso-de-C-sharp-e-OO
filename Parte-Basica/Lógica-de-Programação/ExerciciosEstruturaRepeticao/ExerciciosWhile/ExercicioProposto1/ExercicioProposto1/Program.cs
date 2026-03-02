namespace ExercicioProposto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha:");
            string senha = Console.ReadLine();
            while (senha != "2002")
            {
                Console.WriteLine("Senha inválida. Tente novamente:");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Acesso permitido.");
        }
    }
}