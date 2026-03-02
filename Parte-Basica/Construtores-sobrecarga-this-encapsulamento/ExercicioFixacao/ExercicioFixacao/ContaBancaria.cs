using System.Globalization;

namespace ExercicioFixacao
{
    class ContaBancaria
    {
        private string _nomeTitular;
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            _nomeTitular = nomeTitular;
            Saldo = 0.0;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular)
        {
            Depositar(depositoInicial);
        }

        public string NomeTitular
        {
            get { return _nomeTitular; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nomeTitular = value;
                }
            }
        }

        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }

        public void Sacar(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {_nomeTitular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
