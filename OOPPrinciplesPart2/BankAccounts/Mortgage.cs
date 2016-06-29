using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, double balance, double interestRate) :
            base(customer, balance, interestRate) { }

        public override double CalculateInterest(int months)
        {
            if (months <= 0)
                throw new ArgumentOutOfRangeException("The number of months should be more than zero!");

            if (this.Customer is Company)
            {
                if (months < 13)
                    return this.InterestRate * months / 2.0;

                return this.InterestRate * 6.0 + this.InterestRate * (months - 12);
            }

            if (months < 7)
                return this.InterestRate * months / 2.0;

            return this.InterestRate * 3.0 + this.InterestRate * (months - 6);
        }
    }
}
