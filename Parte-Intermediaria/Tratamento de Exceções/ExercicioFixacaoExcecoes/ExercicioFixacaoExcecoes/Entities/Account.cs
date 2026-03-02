using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoExcecoes.Entities
{
    class Account
    {
        // Properties
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        // Constructor
        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        // deposit method
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        // withdraw method:
        // The withdraw method should throw exceptions in the following cases:
        // - If the amount exceeds the withdraw limit, throw a DomainException with the message "The amount exceeds withdraw limit".
        // - If the amount exceeds the balance, throw a DomainException with the message "Not enough balance".
        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new Exceptions.DomainException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new Exceptions.DomainException("Not enough balance");
            }
            Balance -= amount;
        }
    }
}
