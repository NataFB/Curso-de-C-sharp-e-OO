namespace ExercicioProposto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora de início do jogo:");
            int HoraInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora de término do jogo:");
            int HoraTermino = int.Parse(Console.ReadLine());

            int Duracao;
            if (HoraInicio < HoraTermino)
            {
                Duracao = HoraTermino - HoraInicio;
            }
            else
            {
                Duracao = (24 - HoraInicio) + HoraTermino;
            }

            Console.WriteLine($"O jogo durou {Duracao} hora(s).");
        }
    }
}
