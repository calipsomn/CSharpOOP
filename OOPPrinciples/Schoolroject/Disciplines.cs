using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolroject
{
    public class Disciplines
    {
        private string name;
        private int numOfExercices;
        private int numOfLectures;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int NumOfExercices
        {
            get { return numOfExercices; }
            set { numOfExercices = value; }
        }

        public int NumOfLectures
        {
            get { return numOfLectures; }
            set { numOfLectures = value; }
        }

        public Disciplines(string name, int numOfExercices, int numOfLectures)
        {
            this.name = name;
            this.numOfExercices = numOfExercices;
            this.numOfLectures = numOfLectures;
        }
    }
}
