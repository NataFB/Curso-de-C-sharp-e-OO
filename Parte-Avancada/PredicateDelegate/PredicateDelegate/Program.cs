using PredicateDelegate.entities;

namespace PredicateDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // O PREDICATE É UMA DELEGATE QUE RECEBE UM OBJETO DO TIPO ESPECIFICADO COMO PARAMETRO E RETORNA UM VALOR BOOLEANO
            //Pode usar diretamente a expressão lambda, sem a necessidade de criar um método separado
            //list.RemoveAll(p => p.Price >= 100.0);
            // Ou pode criar um método separado para a lógica de teste e passar o nome do método como argumento para o RemoveAll
            list.RemoveAll(ProductTest);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}