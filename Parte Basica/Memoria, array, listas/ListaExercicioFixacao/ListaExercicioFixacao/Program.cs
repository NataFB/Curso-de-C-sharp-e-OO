using System.Globalization;
using System.Collections.Generic;

namespace ListaExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos empregados vão ser registrados?");
            int Quantidade = int.Parse(Console.ReadLine());

            List<Empregado> list = new List<Empregado>();
            
            for (int i = 1; i <= Quantidade; i++)
            {
                Console.WriteLine("Empregado #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Empregado(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Entre com o id do empregado que vai ter o salário aumentado: ");
            int procuraId = int.Parse(Console.ReadLine());

            Empregado emp = list.Find(x => x.Id == procuraId);
            if (emp != null)
            {
                Console.WriteLine("Qual a porcentagem que deseja aumentar?");
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentoSalario(porcentagem);
                Console.WriteLine();
            } else
            {
                Console.WriteLine("Este Id não existe.");
            }

            Console.WriteLine("Atualizando lista de empregados:");
            foreach(Empregado obj in list)
            {
                Console.WriteLine(obj.ToString()); 
            }
        }
    }
}
