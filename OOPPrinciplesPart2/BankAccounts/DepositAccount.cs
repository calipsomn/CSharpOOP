using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class DepositAccount:Account
    {
        public DepositAccount(Customer customer, double balance, double interestRate) :
            base(customer, balance, interestRate) { }

        public override double CalculateInterest(int months)
        {
            if (months <= 0)
                throw new ArgumentOutOfRangeException("The number of months should be more than zero!");

            if (this.Balance < 1000 && this.Balance > 0.0)
                return 0.0;

            return this.InterestRate * months;
        }

        public void Withdraw(double money)
        {
            if (money <= 0.0)
                throw new ArgumentOutOfRangeException("The money to be withdrawn should be more than zero!");

            this.Balance -= money;
        }
    }
}
