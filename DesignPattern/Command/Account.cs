using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Account
    {
        private decimal _balance;

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            _balance -= amount;
        }
    }
}
