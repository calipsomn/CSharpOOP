using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    public class Company:Customer
    {
        private ulong bulstat;

        public ulong Bulstat
        {
            get { return bulstat; }
            set 
            {
                int bulstatLength = value.ToString().Length;
                if (bulstatLength != 9 && bulstatLength != 10 && bulstatLength != 13)
                    throw new ArgumentOutOfRangeException("The length of the company bulstat number should be 9, 10 or 11!");

                bulstat = value; 
            }
        }
        public Company(ulong bulstat, string name)
            : base(name)
        {
            this.Bulstat = bulstat;
        }
    }
}
