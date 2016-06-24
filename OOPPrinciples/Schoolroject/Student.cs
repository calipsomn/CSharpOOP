using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolroject
{
    public class Student:Human
    {
        private int classNumber;

        public int ClassNumber
        {
            get { return classNumber; }
            set { classNumber = value; }
        }

        public Student(string name, int classNumber):base(name)
        {
            this.classNumber = classNumber;
        }
    }
}
