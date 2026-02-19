using AluguelCarroSemInterfaces.Entitites;

namespace AluguelCarroSemInterfaces.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerday { get; private set; }

        // Criando uma dependencia direta com a classe BrazilTaxService, ou seja, a classe RentalService tem uma instância da classe BrazilTaxService.
        // Obs: Essa é uma abordagem considerada ruim (mas por motivos de didática do curso, vai ser feito dessa forma). 
        //Dependência direta cria forte acoplamento com BrazilTaxService,
        // dificultando testes, reutilização e troca da regra de imposto.
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerday)
        {
            PricePerHour = pricePerHour;
            PricePerday = pricePerday;
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

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
