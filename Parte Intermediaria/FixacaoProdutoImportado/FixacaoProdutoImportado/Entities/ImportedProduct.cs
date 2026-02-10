using System.Globalization;

namespace FixacaoProdutoImportado.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        // Method to calculate total price including customs fee
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        // Override PriceTag method to include customs fee information
        sealed public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice()} (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
