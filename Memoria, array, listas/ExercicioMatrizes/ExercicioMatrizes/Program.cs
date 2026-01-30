using System;

namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Diagonal Principal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();


            int contagem = 0;
            for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if(mat[i,j] < 0)
                    {
                        contagem++;
                    }
                }
            }
            Console.WriteLine("Quantidade de números negativos: " + contagem);
        }
    }
}
