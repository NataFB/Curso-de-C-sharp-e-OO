using System.Globalization;
namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Produto p = new Produto(nome, preco); // Usando o construtor com dois argumentos

            Produto p2 = new Produto(); // Usando o construtor padrão


            Produto p3 = new Produto("TV", 500.00, 20); // Usando o construtor com três argumentos

            Produto p4 = new Produto  // Usando sintaxe alternativa para inicizalização de objeto. Funciona sem contrutores na classe ou com o Construtor padrão declarado como uma das posibilidades caso haja algum personalizado.
            {
                Nome = nome,
                Preco = preco,
                Quantidade = 10
            };


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}