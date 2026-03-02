namespace ExerciciodeClasse1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa:");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa:");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa:");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa:");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é {p1.Nome} com {p1.Idade} anos.");
            }
            else if (p2.Idade > p1.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é {p2.Nome} com {p2.Idade} anos.");
            }
            else
            {
                Console.WriteLine("As duas pessoas têm a mesma idade.");
            }
        }
    }
}