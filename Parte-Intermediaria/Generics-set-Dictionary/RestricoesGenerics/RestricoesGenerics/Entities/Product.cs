using System.Globalization;

namespace RestricoesGenerics.Entities
{
    // tem que implementar IComparable na classe product para ela poder ser comparada com Max
    class Product : IComparable
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString() 
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Comparing erro: argument is not a product");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
