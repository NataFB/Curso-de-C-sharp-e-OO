namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // O Do While executa o bloco de código pelo menos uma vez antes de verificar a condição. Então mesmo que a condição seja falsa desde o início, o código dentro do loop será executado uma vez.

            int contador = 0;
            do
            {
                Console.WriteLine("Do While!");
            }while (contador > 5); // A condição é falsa desde o início, mas o bloco de código será executado uma vez.

            Console.WriteLine("Finalizando");
        }
    }
}