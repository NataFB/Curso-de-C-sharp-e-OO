using GetHashCodeEquals.Entities;

namespace GetHashCodeEquals
{
    class Program
    {
        static void Main(string[] args) 
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };
            
            // O Equals e o GetHashCode comparam o conteudo com base em alguma lógica (nesse caso foi sobrescrito a lógica na classe Client).
            //O == Compara a referencia do ponteiro de memória do objeto, então mesmo se o conteudo for igual a referencia vai ser diferente.
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}