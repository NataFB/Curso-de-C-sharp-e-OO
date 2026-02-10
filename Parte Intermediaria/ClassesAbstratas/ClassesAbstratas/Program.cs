using ClassesAbstratas.Entitites;
using System.Globalization;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            // instanciando objetos de classes derivadas, visto que Account é abstrata e não pode ser instanciada, mas está sendo herdada por outras classes.
            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1004, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1005, "Anna", 500.0, 500.0));


            // Somando o saldo total das contas, mesmo que sejam de tipos diferentes, pois todas herdam da classe Account, e possuem a propriedade Balance.
            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            // Sacando 10.00 de cada conta, mesmo que sejam de tipos diferentes, pois todas herdam da classe Account, e possuem o método Withdraw, que é virtual e pode ser sobrescrito pelas classes derivadas.
            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }
            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}