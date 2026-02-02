namespace Iso8601
{
    class Program
    {
        static void Main(string[] args) 
        {
            // yyyy-MM-ddTHH:mm:ssZ
            // Z indica que a data/ hora está em Utc

                        DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime()); //muda por ser indefinido, gerando algo errado
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime()); //muda por ser indefinido, gerando algo errado
            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime()); // não muda por ser local
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime()); // muda para UTC
            Console.WriteLine();

            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado! método errado, ele irá dar ja com a subtração ou adição
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); // Método certo! Precisa garantir a conversão para global para assim usar a formatação
        }
    }
}