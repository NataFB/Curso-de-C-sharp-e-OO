namespace Timespan
{
    class Program
    {
        static void Main(string[] args) 
        {
            TimeSpan t0 = new TimeSpan(0, 1, 30); //Hora minuto e segundo
            Console.WriteLine(t0);
            Console.WriteLine(t0.Ticks);

            //Construtores:
            TimeSpan t1 = new TimeSpan(); // da um vazio
            TimeSpan t2 = new TimeSpan(900000000L); // contrutor por ticks
            TimeSpan t3 = new TimeSpan(2, 11, 30); // com hora minuto e segundo
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21); //dia hora minuto segundo
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321); // igual o de cima + milisegundos
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            // Instanciando TimeSpan com From:
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
        }
    }
}