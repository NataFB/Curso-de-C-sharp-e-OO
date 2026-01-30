namespace ExercicioFixacaoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] vect = Console.ReadLine().Split(" ");
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(vect[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++) 
            {
                for (int j = 0;j < N; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Cima: " + mat[i - 1, j]);
                        }
                        if (j < N - 1)
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if (i < M - 1)
                        {
                            Console.WriteLine("Baixo: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}