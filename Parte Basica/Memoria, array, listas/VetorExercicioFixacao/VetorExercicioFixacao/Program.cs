namespace VetorExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Quantos quartos tem disponíveis?");
            int Quartos = int.Parse(Console.ReadLine());

            Estudante[] Estudantes = new Estudante[Quartos];

            Console.WriteLine("Quantos Quartos serão alugados?");
            int Quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Quantidade; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel {i} ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Estudantes[quarto] = new Estudante (nome, email);
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < Estudantes.Length; i++)
            {
                if (Estudantes[i] != null)
                {
                    Console.WriteLine(i + ": " + Estudantes[i]);
                }
            }
        }
    }
}