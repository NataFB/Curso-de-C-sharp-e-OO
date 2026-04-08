using ExercicioLendoArquivosComLinq.Entities;
using System.Globalization;

namespace ExercicioLendoArquivosComLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitando ao usuário o caminho completo do arquivo
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            // Lendo o arquivo e armazenando os dados em uma lista de produtos
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string [] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }

            //Manipulando os dados usando LINQ

            //Calculando a média dos preços dos produtos
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            // Selecionando os nomes dos produtos com preço inferior à média, ordenando-os em ordem decrescente e armazenando em uma nova lista
            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name).ToList();
            foreach( string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}