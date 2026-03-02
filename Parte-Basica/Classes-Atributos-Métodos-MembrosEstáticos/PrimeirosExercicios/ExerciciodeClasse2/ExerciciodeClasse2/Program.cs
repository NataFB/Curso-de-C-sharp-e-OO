using System.Globalization;

namespace ExerciciodeClasse2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Digite o nome do primeiro funcionário:");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário desse funcionário:");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome do segundo funcionário:");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário desse funcionário:");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double SalarioMedio = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("O Salario do funcionario " + f1.Nome + " é de: R$ " + f1.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O Salario do funcionario " + f2.Nome + " é de: R$ " + f2.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O Salario medio dos funcionarios é de: R$ " + SalarioMedio.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}