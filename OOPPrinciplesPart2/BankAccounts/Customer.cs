using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    public abstract class Customer
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The name shouldn't be empty!");
                name = value;
            }
        }

        public Customer(string name) 
        {
            this.Name = name;
        }
    }
}
