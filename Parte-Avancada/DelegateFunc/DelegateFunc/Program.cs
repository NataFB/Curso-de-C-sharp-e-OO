using DelegateFunc.Entities;
using System.Linq;

namespace DelegateFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            // O Func delegate é um tipo de delegate pré-definido que pode representar métodos que retornam um valor e podem ter vários parâmetros.
            //igual o action o Func tem 16 sobrecargas de métodos, mas a diferença é que o Func tem um tipo de retorno, ou seja, ele pode retornar um valor, enquanto o Action não retorna nenhum valor (void).
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Declarando um delegate Func que recebe um Product e retorna uma string como uma forma alternativa para usar no select
            // Func<Product, string> é um delegate que representa um método que recebe um Product como parâmetro e retorna uma string.
            //Versão com função lambda: Func<Product, string> func = p => p.Name.ToUpper();
            Func<Product, string> func = NameUpper;

            //Select pertence ao namespace System.Linq e é um método de extensão que permite projetar cada elemento de uma sequência em um novo formulário. Ele é usado para transformar os elementos de uma coleção em outro tipo ou formato.
            // Como a função Select retorna um IEnumerable<string>, precisamos converter para List<string> usando o método ToList()
            List<string> result = list.Select(func).ToList();
             
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        //Função Func que recebe um produto e retorna o nome do produto em letras maiúsculas
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}