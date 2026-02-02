namespace ExercicioProposto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a coordenada de X:");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite a coordenada de Y:");
            int Y = int.Parse(Console.ReadLine());

            while(X != 0 && Y != 0)
            {
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else if (X > 0 && Y < 0)
                {
                    Console.WriteLine("Quarto");
                }
                Console.WriteLine("Digite a coordenada de X:");
                X = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a coordenada de Y:");
                Y = int.Parse(Console.ReadLine());
            }

        }
    }
}
