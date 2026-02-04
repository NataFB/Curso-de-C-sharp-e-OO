namespace Constante
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Constantes são valores fixos que não podem ser alterados durante a execução do programa.
            // Elas são declaradas usando a palavra-chave const antes do tipo de dado.

            const double Pi = 3.14;
            //Pi = 2.00; // Isso causará um erro de compilação, pois Pi é uma constante e seu valor não pode ser alterado.

            Console.WriteLine(Pi);
        }
    }
}