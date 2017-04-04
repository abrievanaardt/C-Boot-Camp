using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        public double Balance { get; set; }

        public Account(double _balance = 0)
        {
            Balance = _balance;
        }

        public double Withdraw(double amount)
        {
            if (amount < 0.0)
                throw new NegativeAmountException();

            return Balance -= amount;
        }

        public double Deposit(double amount)
        {
            if (amount < 0.0)
                throw new NegativeAmountException();

            return Balance += amount;
        }
    }
}
