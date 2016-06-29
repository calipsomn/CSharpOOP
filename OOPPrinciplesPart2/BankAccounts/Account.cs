using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    public abstract class Account
    {
        private Customer customer;
        private double balance;
        private double interestRate;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public Account(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public abstract double CalculateInterest(int months);

        public void Deposit(double money)
        {
            if (money <= 0.0)
                throw new ArgumentOutOfRangeException("The deposited money should be greater than zero");

            this.Balance += money;
        }
    }
}
