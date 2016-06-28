using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    public class Individual:Customer
    {
        private uint egn;

        public uint Egn
        {
            get { return egn; }
            set
            {
                if (egn.ToString().Length != 10)
                    throw new ArgumentOutOfRangeException("The individual egn should be 10 symbols");

                egn = value;
            }
        }
        public Individual(string name) : base(name) { }
    }
}
