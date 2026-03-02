using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace UpcastingDowncasting.Entities
{
    sealed class SavingsAccount : Account // A classe SavingsAccount é marcada como sealed, o que significa que ela não pode ser herdada por outras classes. Isso é útil para garantir que a implementação da conta poupança seja final e não possa ser modificada por subclasses.
    {
        public double InterestRate { get; set; } // Juros

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) // Sobrescreve o método Withdraw da classe base Account.
           // O modificador sealed impede que esse método seja sobrescrito por qualquer classe que possa herdar de SavingsAccount, garantindo que a implementação do saque para contas poupança seja final e não possa ser alterada por subclasses.
           //O metodo sealed só pode ser utilizado em métodos que já foram sobrescritos, ou seja, métodos que possuem a palavra-chave override. Ele não pode ser aplicado a métodos que não foram sobrescritos, pois o objetivo do sealed é impedir que um método seja sobrescrito novamente em classes derivadas.
        {
            base.Withdraw(amount); // Chama o método Withdraw da classe base para realizar a operação de saque, aplicando a taxa de saque padrão.
            Balance -= 2.0; // Aplica uma taxa adicional de saque específica para contas poupança.

        }
    }
}
