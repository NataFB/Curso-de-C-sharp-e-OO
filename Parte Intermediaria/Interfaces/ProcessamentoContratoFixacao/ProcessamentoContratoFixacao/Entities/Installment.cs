using System.Globalization;

namespace ProcessamentoContratoFixacao.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount) 
        { 
            DueDate = dueDate;
            Amount = amount;
        }

        //Show the installments
        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
