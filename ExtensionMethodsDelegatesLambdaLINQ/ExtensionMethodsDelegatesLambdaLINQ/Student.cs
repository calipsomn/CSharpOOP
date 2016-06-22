using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    public class Student
    {
        #region Private Fields

        private string firstName;
        private string lastName;
        private int age;
        private string fN;
        private string tel;
        private string email;
        private List<double> marks;
        private int groupNumber;

        #endregion

        #region Constructors

        public Student(string firstName, string lastName)
            : this(firstName, lastName, 0, String.Empty, String.Empty, String.Empty, 0, new List<double>())
        {

        }

        public Student(string firstName, string lastName, int age, string fN, string tel, string email, int groupNumber, List<double> marks)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.fN = fN;
            this.tel = tel;
            this.email = email;
            this.groupNumber = groupNumber;
            this.marks = marks;
        }

        #endregion

        #region Properties

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string FN
        {
            get { return fN; }
            set { fN = value; }
        }

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public List<double> Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public int GroupNumber
        {
            get { return groupNumber; }
            set { groupNumber = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        #endregion
    }
}
