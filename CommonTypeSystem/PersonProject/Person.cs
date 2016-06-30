using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    public class Person
    {
        private string name;
        private int? age;

        public int? Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person(string name, int? age)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            return String.Format("Name -> {0}\nAge{1}", this.Name, this.Age != null ? this.Age.ToString() : "Unknown");
        }
    }
}
