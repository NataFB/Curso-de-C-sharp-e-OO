using System;
using System.Collections.Generic;
using System.Text;
using UpcastingDowncasting.Entities;

namespace UpcastingDowncasting.Entities
{
    class BussinesAccount : Account// A classe BussinesAccount herda da classe Account (: Account)
    {
        public double LoanLimit { get; set; }
        public BussinesAccount()
        {
        }

        // O construtor da classe BussinesAccount chama o construtor da classe base (Account) usando a palavra-chave "base" para inicializar os atributos herdados (number, holder, balance).
        public BussinesAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        } 
    }
}
