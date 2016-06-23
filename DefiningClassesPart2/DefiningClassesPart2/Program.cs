using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Reflection.MemberInfo point = typeof(Point3D);
            Console.WriteLine("Attributes for : " + point.Name);
            foreach (object attribute in point.GetCustomAttributes(true))
            {
                Console.WriteLine(attribute);
            }
        }
    }
}
