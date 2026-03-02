using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAbstratas.Entitites
{
    // A classe Account é abstrata, ou seja, não pode ser instanciada diretamente. Ela serve como uma base para outras classes de conta, como SavingsAccount e BusinessAccount.
    // A palavra-chave 'abstract' indica que a classe é abstrata.
    // Ela virou uma classe abstrata para evitar que objetos do tipo Account sejam criados diretamente, já que faz mais sentido trabalhar com tipos específicos de contas.
    abstract class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}