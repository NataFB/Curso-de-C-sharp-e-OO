using DelegateAction.Entities;

namespace DelegateAction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delegate action representa um método void que recebe zero ou mais parâmetros. Ele é útil para encapsular métodos que não retornam um valor.
            //Existe 16 variações do action com sobrecarga de parâmetros, desde Action<T1> até Action<T1, T2, ..., T16>.

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Posso criar um objeto do tipo Action e atribuir a ele o método UpdatePrice, que é um método void que recebe um parâmetro do tipo Product. Dessa forma, o objeto act pode ser usado para chamar o método UpdatePrice em cada elemento da lista.
            //Também poderia usar uma expressão lambda para criar o Action, como por exemplo: Action<Product> act = p =>{ p.Price += p.Price * 0.1 }; Isso faria a mesma coisa que o método UpdatePrice, mas sem precisar criar um método separado.
            Action<Product> act = UpdatePrice;


            //list.ForEach recebe um action como parâmetro, ou seja, um método void que recebe um parâmetro do tipo Product. O método UpdatePrice é um exemplo de método que pode ser passado como argumento para o ForEach.
            //O list.ForEach irá iterar sobre cada elemento da lista e aplicar o método UpdatePrice em cada um deles, atualizando o preço de cada produto.
            list.ForEach(UpdatePrice);
            
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}