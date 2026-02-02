using System.Globalization;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2000, 8, 15); // ano mes dia
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58); // ano mes dia hora minutos segundos
            DateTime d4 = new DateTime(2000, 8, 15, 13, 5, 58, 275); // o de cima + milisegundo

            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4); // por padrão não imprime os milisegundos
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2000-08-15"); // Converte texto para data aceita varios formatos
            Console.WriteLine(d7);
            DateTime d8 = DateTime.Parse("200-08-15 13:05:58");
            Console.WriteLine(d8);
            DateTime d9 = DateTime.Parse("11-01-2000"); //Formato BR
            Console.WriteLine(d9);

            //Determinando seu próprio formato
            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);

            DateTime d11 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);
        }
    }
}