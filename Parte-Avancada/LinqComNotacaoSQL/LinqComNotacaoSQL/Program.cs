using LinqComNotacaoSQL.Entities;
using System.Linq;

namespace LinqComNotacaoSQL
{
    //Refazendo o exemplo de Linq com Lambda porém utilizando a notação SQL, ou seja, utilizando as palavras reservadas do Linq, como from, where, select, etc. Essa notação é mais parecida com o SQL, e pode ser mais fácil de entender para quem já conhece SQL. A notação de Lambda é mais flexível e pode ser mais fácil de escrever para quem já conhece C#, mas a notação SQL pode ser mais fácil de ler para quem já conhece SQL.
    //OS COMENTARIOS DE CADA VAR E O QUE CADA CONSULTA FAZ ESTAO NO PROGRAMA DE LINQ COM LAMBDA, POIS AS CONSULTAS SAO AS MESMAS, APENAS COM NOTACAO DIFERENTE. 
    class Program
    {

        //função auxiliar de printar. O IEnumerable<T> é para ficar compativel com o linq, pois o resultado do linq é um IEnumerable<T>.
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
             };

            var r1 = 
                from p in products // from é para indicar a fonte de dados, ou seja, a coleção que vai ser filtrada. O p é uma variável de iteração, ou seja, ela vai representar cada elemento da coleção durante a iteração.
                where p.Category.Tier == 1 && p.Price < 900.0 // where é para indicar a condição de filtragem, ou seja, a condição que os elementos da coleção devem satisfazer para serem incluídos no resultado.
                select p; // select é para indicar o que vai ser projetado no resultado, ou seja, o que vai ser retornado para cada elemento da coleção que satisfaz a condição de filtragem.
            Print("TIER 1 AND PRICE < 900:", r1);


            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            
            var r3 = 
                from p in products
                where p.Name[0] == 'C'
                select new { p.Name, p.Price, CategoryName = p.Category.Name }; 
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);


            var r4 = 
                from p in products
                where p.Category.Tier == 1
                //nesse caso o orderby tem que ser posto na ordem inversa nessa sintaxe.
                orderby p.Name 
                orderby p.Price
                select p;
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            
            var r5 = 
                (from p in r4
                select p).Skip(2).Take(4); // nesse caso faz a expressão de consulta em r4 colocando entre parenteses, que já tem os produtos filtrados e ordenados, e depois aplica o Skip e o Take.
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

           
            var r6 = (from p in products select p).FirstOrDefault();
            Console.WriteLine("First test1: " + r6);

           
            var r7 = 
                (from p in products
                where p.Price > 3000.0
                select p).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);
            Console.WriteLine();


            var r16 =
                from p in products
                group p by p.Category;
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");

                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
