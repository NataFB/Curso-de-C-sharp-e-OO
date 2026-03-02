namespace BoaPraticaDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local); // Instanciando manualment no horario local com Kind.Local

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc); // Instanciando manualmente no horario UTC com Kind.Utc

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58); // Sem especificar

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime()); //Muda para o horário local da máquina (nesse caso não muda nada por ja estar no local)
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime()); // Transforma para o Horário em UTC equivalentee.
            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime()); // Nesse caso irá mudar transformando para o horário local da máquina
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime()); // Nesse caso não irá mudar pois ja foi iniciado em UTC
            Console.WriteLine();

            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime()); // Como ele não sabe quanto é ele vai ou subtrair ou somar de acordo com o Utc local
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime()); // Como ele não sabe quanto é ele vai ou subtrair ou somar de acordo com o Utc Marco 0
        }
    }
}