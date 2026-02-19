using System.Globalization;

namespace AluguelCarroComInterfaces.Entitites 
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        // Propriedade calculada, ou seja, não tem um campo para armazenar o valor, mas sim um método get que retorna o valor calculado.
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        override public string ToString()
        {
            return "Basic Payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal Payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
