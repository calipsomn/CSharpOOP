using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    public class Group
    {
        private int groupNumber;
        private Department departmentName;

        public Group(int groupNumber, Department department)
        {
            this.departmentName = department;
            this.groupNumber = groupNumber;
        }

        public int GroupNumber
        {
            get { return groupNumber; }
            set { groupNumber = value; }
        }

        public Department DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
    }
}
