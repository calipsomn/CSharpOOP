using System;
using System.Collections.Generic;
using System.Text;

namespace CommonTypeSystem
{
    public class Student:ICloneable,IComparable
    {
        #region Fields

        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string address;
        private string phone;
        private string email;
        private int course;

        #endregion

        #region Properties

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The first name of the student shouldn't be empty!");

                firstName = value;
            }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The last name of the student shouldn't be empty!");

                lastName = value;
            }
        }

        public string Ssn
        {
            get { return ssn; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The email of the student shouldn't be empty!"); 
                
                email = value;
            }
        }

        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public University University { get; set; }

        public Specialty Specialty { get; set; }

        public Faculty Faculty { get; set; }

        #endregion

        #region Constructors

        public Student(string firstName, string middleName, string lastName, University university, Faculty faculty,
            Specialty specialty, string ssn, string address, string phone, string email, int course)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
            this.ssn = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
        }

        public Student(string firstName, string lastName, University university, Faculty faculty, Specialty specialty, string ssn)
            : this(firstName, "", lastName, university, faculty, specialty, ssn, "", "", "", 0) { }


        #endregion

        #region System.Object

        public override bool Equals(object obj)
        {
            Student secondStudent = obj as Student;
            if (this.Address != secondStudent.Address)
                return false;
            if (this.Course != secondStudent.Course)
                return false;
            if (this.Phone != secondStudent.Phone)
                return false;
            if (this.Specialty != secondStudent.Specialty)
                return false;
            if (this.Email != secondStudent.Email)
                return false;
            if (this.Faculty != secondStudent.Faculty)
                return false;
            if (this.FirstName != secondStudent.FirstName)
                return false;
            if (this.LastName != secondStudent.LastName)
                return false;
            if (this.MiddleName != secondStudent.MiddleName)
                return false;
            if (this.ssn != secondStudent.ssn)
                return false;
            if (this.University != secondStudent.University)
                return false;

            return true;
        }

        public override string ToString()
        {
            return String.Format(@"Name -> {0} {1} {2}\nUniversity -> {3}\nFaculty -> {4}\nSpecialty -> {5}\nSSN -> {6}\nAddress -> {7}\nPhone -> {8}\nEmail -> {9}\nCourse -> {10}");
        }

        public override int GetHashCode()
        {
            return this.ssn.GetHashCode();
        }

        public static bool operator == (Student student1, Student student2)
        {
            return student1.Equals(student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !student1.Equals(student2);
        }

        #endregion

        #region Interface implementations

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.University, this.Faculty, this.Specialty,
                this.ssn, this.address, this.Phone, this.Email, this.Course);
        }

        public int CompareTo(object obj)
        {
            Student student2 = obj as Student;
            if (this.FirstName != student2.FirstName)
                return String.Compare(this.FirstName, student2.FirstName);
            if (this.LastName != student2.LastName)
                return String.Compare(this.LastName, student2.LastName);
            if (this.MiddleName != student2.MiddleName)
                return String.Compare(this.MiddleName, student2.MiddleName);
            if (this.Phone != student2.Phone)
                return String.Compare(this.Phone, student2.Phone);
            if (this.Ssn != student2.Ssn)
                return String.Compare(this.Ssn, student2.Ssn);
            if (this.University != student2.University)
                return String.Compare(this.University.ToString(), student2.University.ToString());
            if (this.Address != student2.Address)
                return String.Compare(this.Address, student2.Address);
            if (this.Course != student2.Course)
                return this.Course - student2.Course;
            if (this.Faculty != student2.Faculty)
                return String.Compare(this.Faculty.ToString(), student2.Faculty.ToString());
            if (this.Specialty != student2.Specialty)
                return String.Compare(this.Specialty.ToString(), student2.Specialty.ToString());
            if (this.Email != student2.Email)
                return String.Compare(this.Email, student2.Email);
            return 0;
        }

        #endregion
    }
}
