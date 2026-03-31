using ComparisonTeLambida.Entities;

namespace ComparisonTeLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //Expressão lambda para comparação de produtos por nome
            //A expressão lambda é uma forma concisa de escrever uma função anônima, ou seja, uma função sem nome. No exemplo abaixo, a expressão lambda é usada para comparar dois objetos do tipo Product com base no nome, convertendo-os para maiúsculas antes de compará-los. A expressão lambda é atribuída a uma variável do tipo Comparison<Product>, que é um delegado que representa uma função de comparação.
            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            // Pode-se por tanto a variavel comp com a expressão lambda quanto por a propria expressão lambda diretamente no método Sort, como mostrado abaixo:
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        //Essa função é um comparison T 
        //Recebe 2 objetos e retorna um inteiro indicando a ordem dos objetos
        /*
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
        */
    }
}