using System.Globalization;
using AluguelCarroSemInterfaces.Entitites;
using AluguelCarroSemInterfaces.Services;

namespace AluguelCarroSemInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            //O método ParseExact é utilizado para converter uma string em um objeto DateTime, utilizando um formato específico.
            //O formato "dd/MM/yyyy HH:mm" define dia, mês, ano, hora (24h) e minutos.
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Criando um objeto CarRental, passando os dados de início, término e o objeto Vehicle com o modelo do carro.
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            //Iniciando o RentalService
            RentalService rentalService = new RentalService(hour, day);

            //Processando a fatura do aluguel, passando o objeto CarRental como argumento. O método ProcessInvoice irá calcular o valor total do aluguel e gerar a fatura correspondente (gera um objeto Invoice).
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}