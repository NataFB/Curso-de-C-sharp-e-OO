using UpcastingDowncasting.Entities;

namespace UpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BussinesAccount bacc = new BussinesAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING
            //O upcasting é o processo de converter um objeto de uma classe derivada para um tipo mais genérico, ou seja, para uma classe base. O upcasting é seguro e não requer uma conversão explícita, pois a classe derivada é um tipo de classe base. No entanto, ao realizar o upcasting, você perde acesso aos métodos e propriedades específicos da classe derivada, e só pode acessar os membros que estão definidos na classe base.

            //A variável do tipo Account recebe um objeto de qualquer classe que herda de Account
            Account acc1 = bacc; // Upcasting implícito, neste caso, BussinesAccount é uma subclasse de Account
            Account acc2 = new BussinesAccount(1003, "Bob", 0.0, 200.0); // Upcasting implícito, neste caso, BussinesAccount é uma subclasse de Account
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01); // Upcasting implícito, neste caso, SavingsAccount é uma subclasse de Account

            // DOWNCASTING
            //O downcasting é o processo de converter um objeto de uma classe base para um tipo mais específico, ou seja, para uma classe derivada. No entanto, o downcasting pode ser perigoso se não for feito corretamente, pois pode resultar em erros em tempo de execução se o objeto não for realmente do tipo para o qual está sendo convertido.

            // BussinesAccount acc4 = acc2; Nesse caso, o código não compila, pois acc2 é do tipo Account e não BussinesAccount, mesmo que acc2 seja uma instância de BussinesAccount. Para fazer isso, é necessário realizar um downcasting explícito.

            BussinesAccount acc4 = (BussinesAccount)acc2; // Downcasting explícito, convertendo acc2 para BussinesAccount
            acc4.Loan(100.0); // Agora é possível acessar os métodos específicos de BussinesAccount

            //BussinesAccount acc5 = (BussinesAccount)acc3; // Downcasting explícito, convertendo acc3 para BussinesAccount, mas isso pode causar um erro em tempo de execução, pois acc3 é uma instância de SavingsAccount, e não BussinesAccount.
            // Para evitar esse tipo de erro, é recomendado usar o operador "is" ou "as" para verificar o tipo antes de realizar o downcasting.

            // Verificando o tipo antes de realizar o downcasting
            if (acc3 is BussinesAccount)
            {
                //não vai entrar aqui, pois acc3 é uma instância de SavingsAccount, e não BussinesAccount
                BussinesAccount acc5 = acc3 as BussinesAccount; //sintaxe alternativa para downcasting, usando o operador "as", que retorna null se a conversão falhar 
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            else
            {
                Console.WriteLine("acc3 não é do tipo BussinesAccount");
            }
        }
    }
}