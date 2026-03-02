using Icomparable.Entities;

namespace Icomparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\nataf\OneDrive\Documentos\Curso-de-C-sharp-e-OO\Parte Intermediaria\Interfaces\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    // gera e adiciona na lista lendo o arquivo:
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort(); // Ordena a list, o objeto da lista tem que implementar a interface comparable para funcionar.
                    //Printando:
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}