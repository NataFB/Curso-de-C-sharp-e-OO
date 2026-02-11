using System.Collections.Generic;
using ExercicioContratoTrabalhador.Entities.Enums;

namespace ExercicioContratoTrabalhador.Entities
{
    class Worker
    {
        // Criando Classe Trabalhador com propriedades Nome, Nivel, SalarioBase, Departamento e Contratos
        public String Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        //Iniciando sem os contratos na construção do objeto para serem adicionados depois
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Métodos para adicionar e remover contratos
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract) 
        { 
            Contracts.Remove(contract); 
        }

        //Método para calcular o rendimento do trabalhador em um determinado mês e ano
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}