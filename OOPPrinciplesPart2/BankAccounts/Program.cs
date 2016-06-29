using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            accounts.Add( new LoanAccount(new Individual(1111111111, "Ivan Ivanov"), 100.0, 2.0));
            accounts.Add(new LoanAccount(new Company(222222222, "Adasdzc LTD"), 3000.0, 1.0));
            accounts.Add(new DepositAccount(new Individual(3333333333, "Ivan etrov"), 1001.0, 3.0));
            accounts.Add(new DepositAccount(new Company(4444444444, "Bcadf LTD"), 5000.0, 1.5));
            accounts.Add(new Mortgage(new Individual(5555555555, "Maria Georgoeva"), 500.0, 2.0));
            accounts.Add(new Mortgage(new Company(6666666666666, "Adasdzc LTD"), 13000.0, 1.0));

            foreach (var account in accounts)
            {
                account.CalculateInterest(20);
                account.Deposit(10.0);
                if (account is DepositAccount)
                    (account as DepositAccount).Withdraw(100);

                account.CalculateInterest(20);
            }
        }
    }
}
