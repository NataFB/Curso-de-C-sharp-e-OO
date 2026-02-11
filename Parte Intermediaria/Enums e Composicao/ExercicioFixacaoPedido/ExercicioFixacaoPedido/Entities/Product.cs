namespace ExercicioFixacaoPedido.Entities
{
    class Product
    {
        //Class Product with properties Name and Price and constructors
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }
}
