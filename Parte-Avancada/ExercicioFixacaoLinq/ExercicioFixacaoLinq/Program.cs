using System.Globalization;

using ExercicioFixacaoLinq.Entities;

namespace ExercicioFixacaoLinq
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Solicitar ao usuário o caminho do arquivo
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> employees = new List<Employee>();

            //Ler o arquivo e armazenar os dados em uma lista de objetos Employee
            using (StreamReader sr = File.OpenText(path)) // Usar StreamReader para ler o arquivo
            {
                while (!sr.EndOfStream) // Ler o arquivo linha por linha até o final
                {
                    string[] fields = sr.ReadLine().Split(','); // Dividir a linha em campos usando vírgula como separador
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, salary));
                }
            }

            //MANIPULAR OS DADOS USANDO LINQ
            Console.Write("Enter salary: ");
            double salaryThreshold = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Email of people whose salary is more than {salaryThreshold}");
            // Filtra os funcionários cujo salário é maior que o valor digitado pelo usuário,
            // depois seleciona apenas os e-mails desses funcionários
            // e os ordena em ordem alfabética (A → Z)
            var emails = employees
                .Where(e => e.Salary > salaryThreshold)  // Filtra: só passa quem tem salário acima do limite
                .Select(e => e.Email)                    // Projeta: de cada funcionário, pega apenas o e-mail
                .OrderBy(email => email);               // Ordena: os e-mails em ordem alfabética

            foreach(string email in emails)
            {
                Console.WriteLine(email);
            }

            var sum = employees
                .Where(e => e.Name[0] == 'M') // Filtra: só passa quem tem nome começando com 'M'
                .Sum(e => e.Salary); // Agrega: soma os salários dos funcionários que passaram no filtro

            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}