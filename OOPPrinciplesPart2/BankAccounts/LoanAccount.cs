using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class LoanAccount:Account
    {
        public LoanAccount(Customer customer, double balance, double interestRate) :
            base(customer, balance, interestRate) { }

        public override double CalculateInterest(int months)
        {
            if (months <= 0)
                throw new ArgumentOutOfRangeException("The number of months should be more than zero!");

            bool isCompany = this.Customer is Company;
            if (isCompany)
            {
                if (months < 4)
                    return 0.0;

                return (months - 3) * this.InterestRate;
            }

            if (months < 3)
                return 0.0;

            return (months - 2) * this.InterestRate;
        }
    }
}
