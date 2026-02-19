using AluguelCarroComInterfaces.Entitites;

namespace AluguelCarroComInterfaces.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerday { get; private set; }

        //Declarando a interface para o serviço de imposto, ou seja, a classe RentalService depende da interface ITaxService, ou seja, a classe RentalService tem uma dependência com a interface ITaxService. E não diretamente com uma classe concreta.
        private ITaxService _taxService;

        //Recebe agora a interface como parametro, ou seja, a classe RentalService não precisa saber qual é a implementação concreta do serviço de imposto, ela apenas precisa saber que existe um serviço de imposto que implementa a interface ITaxService.
        public RentalService(double pricePerHour, double pricePerday, ITaxService taxService) 
        {
            PricePerHour = pricePerHour;
            PricePerday = pricePerday;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start); // Calcula a duração do aluguel subtraindo a data de início da data de término.

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0) //TotalHours calcula o total em horas
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); //Math.Ceiling arredonda para cima então 4:10h ficaria 5h
            }
            else
            {
                basicPayment = PricePerday * Math.Ceiling(duration.TotalDays); // Arredonda para cima o dia nesse caso se ultrapassar das 12h
            }

            double tax = _taxService.Tax(basicPayment); // Usa o serviço da interface sem precisar saber qual a sua implementação concreta.

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
