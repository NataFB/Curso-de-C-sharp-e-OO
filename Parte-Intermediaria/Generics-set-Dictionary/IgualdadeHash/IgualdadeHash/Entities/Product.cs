namespace IgualdadeHash.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //criando lógica de comparação do gethashcode
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        //criando lógica de comparação do Equals
        public override bool Equals(object? obj)
        {
            if(!(obj is Product))
            {
                return false;
            }
            Product other = obj as Product;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
