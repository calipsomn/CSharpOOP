using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    public class Individual:Customer
    {
        private ulong egn;

        public ulong Egn
        {
            get { return egn; }
            set
            {
                if (value.ToString().Length != 10)
                    throw new ArgumentOutOfRangeException("The individual egn should be 10 symbols");

                egn = value;
            }
        }
        public Individual(ulong egn, string name)
            : base(name) 
        {
            this.Egn = egn;
        }
    }
}
