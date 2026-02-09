using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastingDowncasting.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        // O atributo Balance é protegido (protected), o que significa que ele pode ser acessado e modificado dentro da classe Account e em suas subclasses, mas não pode ser acessado diretamente de fora dessas classes.
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
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
                Balance += amount;
        }
    }
}
