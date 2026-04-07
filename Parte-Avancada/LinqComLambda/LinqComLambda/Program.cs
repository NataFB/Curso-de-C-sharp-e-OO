using System.Linq;
using LinqComLambda.Entities;

namespace LinqComLambda
{
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

            //Obtendo coleção filtrada com linq. Where filtra a lista de acordo com o parametro passado.
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900:", r1);

            //O Select vai projetar apenas o que for pedido, no caso, o nome do produto.
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            //O Select pode projetar para um tipo anonimo, ou seja, um tipo que não existe, mas é criado na hora. No caso, o nome do produto, o preço e o nome da categoria.
            // O CategoryName é o nome da propriedade do tipo anonimo, e p.Category.Name é o valor que vai ser atribuido a essa propriedade. Pois .Name gera ambiguidades, pois tanto o produto quanto a categoria tem uma propriedade .Name, então é necessario dar um nome diferente para a propriedade do tipo anonimo. Igual um alias no sql.
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            //Ordenando a coleção. OrderBy ordena por um criterio, e ThenBy ordena por outro criterio caso haja empate no primeiro criterio. No caso, ordena por preço, e em caso de empate, ordena por nome.
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            //Pula os 2 primeiros e pega os 4 próximos. Skip é para pular um numero de elementos, e Take é para pegar um numero de elementos.
            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            //Pega o primeiro elemento da coleção.
            var r6 = products.First();
            Console.WriteLine("First test1: " + r6);

            //Com apenas o Fist ou o Last vai gerar um erro pois a lista vai ser vazia. O FirstOrDefault e o LastOrDefault vão retornar o valor default do tipo, que no caso é null, caso a lista seja vazia. No caso, a lista vai ser vazia pois não existe nenhum produto com preço maior que 3000.0. Nulo não aparece nada na hora de imprimir.
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);
            Console.WriteLine();

            //SingleOrDefault é para pegar um elemento da coleção, mas ele tem que ser o unico elemento da coleção. Se houver mais de um elemento, ele vai gerar um erro. Se não houver nenhum elemento, ele vai retornar o valor default do tipo, que no caso é null. No caso, a lista vai ter apenas um elemento, que é o produto com Id 3, então ele vai retornar esse produto.
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test: " + r8);
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine();

            //Max retorna o maior valor de uma coleção. No caso, o maior preço dos produtos. Min retorna o menor valor de uma coleção.
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " +r11);

            //Sum retorna a soma dos valores de uma coleção. Nesse caso, a soma dos preços dos produtos da categoria 1.
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);

            //Average retorna a média dos valores de uma coleção. Nesse caso, a média dos preços dos produtos da categoria 1.
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 average price: " + r13);

            // DefaultIfEmpty é para retornar um valor default caso a coleção seja vazia. No caso, a coleção vai ser vazia pois não existe nenhum produto com categoria 5, então ele vai retornar 0.0 como valor default, e a média vai ser 0.0.
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 avarage price: " + r14);

            //Aggregate é para fazer uma operação de agregação, ou seja, pegar os elementos da coleção e aplicar uma função que vai combinar esses elementos. No caso, a função é a soma, então ele vai somar os preços dos produtos da categoria 1. O resultado é o mesmo do Sum, mas o Aggregate é mais geral, pois pode ser usado para outras operações de agregação, como multiplicação, concatenação de strings, etc.
            //O Select + Aggregate é o equivalente em outras linguagens ao map + reduce, ou seja, o Select é o map, que projeta os elementos da coleção para um novo formato, e o Aggregate é o reduce, que combina os elementos da coleção de acordo com uma função.
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0,(x, y) => x + y); //0.0 indica q é double
            Console.WriteLine("Category 1 aggregate sum: " + r15);

            //Agrupa os produtos por categoria. O resultado é uma coleção de grupos, onde cada grupo tem uma chave (a categoria) e uma coleção de elementos (os produtos da categoria).
            var r16 = products.GroupBy(p => p.Category);
            // O foreach para imprimir os grupos. O group.Key é a chave do grupo, ou seja, a categoria, e o group é a coleção de produtos da categoria. IGrouping é uma interface que representa um grupo, onde a chave é do tipo Category e os elementos são do tipo Product.
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                // O foreach para imprimir os produtos do grupo. O group é a coleção de produtos da categoria, então ele vai iterar sobre essa coleção e imprimir cada produto.
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
