using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    public static class Extensions
    {
        public static StringBuilder SubString(this StringBuilder sb, int index, int length)
        {
            return new StringBuilder(sb.ToString(index, length));
        }

        public static T Sum<T>(this IEnumerable<T> collection)
           where T : struct
        {
            T sum = default(T);
            foreach (var number in collection)
            {
                sum += (dynamic)number;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
           where T : struct
        {
            T sum = default(T);
            foreach (var number in collection)
            {
                sum *= (dynamic)number;
            }
            return sum;
        }

        public static T Min<T>(this IEnumerable<T> collection)
           where T : struct
        {
            T min = collection.First();
            foreach (var number in collection)
            {
                if (min > (dynamic)number)
                    min = (dynamic)number;
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
           where T : struct
        {
            T max = collection.First();
            foreach (var number in collection)
            {
                if (max < (dynamic)number)
                    max = (dynamic)number;
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection)
           where T : struct
        {
            T sum = default(T);
            foreach (var number in collection)
            {
                sum += (dynamic)number;
            }
            return (dynamic)sum / collection.Count();
        }

        public static IEnumerable<Student> FirstBeforeLast(this Student[] students)
        {
            return from student in students
                   where String.Compare(student.LastName, student.FirstName, true) > 0
                   select student;
        }

        public static IEnumerable<string> AgeRange(this Student[] students, int minAge, int maxAge)
        {
            return from student in students
                   where student.Age>=minAge && student.Age<=maxAge
                   select student.FirstName +" "+student.LastName;
        }

        public static IEnumerable<Student> OrderStudentsDesc(this Student[] students)
        {
            return students.OrderByDescending(st => st.LastName).ThenBy(st => st.FirstName);
        }

        public static IEnumerable<Student> OrderByStudents(this Student[] students)
        {
            return from student in students
                   orderby student.FirstName ascending, student.LastName descending
                   select student;
        }

        public static IEnumerable<int> DivisibleBy7And3(this int[] numbers)
        {
            return numbers.Where(number => number % 7 == 0 && number % 3 == 0);
        }

        public static IEnumerable<int> DivisibleBy7And3LINQ(this int[] numbers)
        {
            return from number in numbers
                   where number % 7 == 0 && number % 3 == 0
                   select number;
        }
    }
}
