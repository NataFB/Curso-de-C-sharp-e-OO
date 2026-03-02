using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastingDowncasting.Entities
{
    internal class SavingsAccount : Account
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

    }
}
