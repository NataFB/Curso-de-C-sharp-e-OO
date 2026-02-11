using System.Globalization;

namespace FixacaoProdutoImportado.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime Date { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            Date = date;
        }

        // Override PriceTag method to include manufacture date information
        sealed override public string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {Date.ToString("dd/MM/yyyy")})";
        }


    }
}
