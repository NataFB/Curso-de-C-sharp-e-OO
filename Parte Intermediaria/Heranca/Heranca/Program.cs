using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BussinesAccount account = new BussinesAccount(8010, "Maria", 100.0, 500.0);
            Console.WriteLine(account.Balance);

            // account.Balance = 200.0; // ERRO! O atributo Balance é somente leitura e não pode ser modificado diretamente
             account.Loan(100.0);
             Console.WriteLine(account.Balance);
        }
    }
}