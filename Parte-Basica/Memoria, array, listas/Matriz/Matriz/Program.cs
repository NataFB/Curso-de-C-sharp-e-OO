namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //gerando a matriz, primeiro o tipo da matriz depois declarar que é uma matriz (bidimensional) deve utilizar [,], onde [Linhas, Colunas]
            double[,] mat = new double[2, 3];


            Console.WriteLine(mat.Length);//Mostra quantos elementos tem no total

            Console.WriteLine(mat.Rank);//Mostra o tamanho da primeira dimensão (linhas)

            Console.WriteLine(mat.GetLength(0));//Mostra o tamanho da primeira dimensão (linhas)
            Console.WriteLine(mat.GetLength(1));//Mostra a segunda dimensão (colunas) 
        }
    }
}