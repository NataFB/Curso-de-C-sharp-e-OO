namespace ExercicioContratoTrabalhador.Entities
{
    class HourContract
    {
        //Classe do Contrato com propriedades Data, ValorPorHora e DuracaoEmHoras
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //Metodo para calcular o valor total do contrato
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
