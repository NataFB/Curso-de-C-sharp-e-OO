using IgualdadeHash.Entities;

namespace IgualdadeHash
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);

            Console.WriteLine(a.Contains(prod)); // com o GetHashCode e o Equals definidos na classe Product terá que dar verdadeiro pois comparará os conteúdos. Se não tivessem definidos daria false pois compararia o local da memória.

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p)); // Nesse caso mesmo sem implementar da verdadeiro pois o tipo é struct assim ja comparando por conteúdo. 
        }
    }
}