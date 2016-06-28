using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Triangle(1.2, 3.4));
            shapes.Add(new Rectangle(3.4, 5.6));
            shapes.Add(new Square(7.2));
            foreach (var shape in shapes)
                Console.WriteLine("{0} -> {1}", shape.GetType().Name, shape.CalculateSurface());
        }
    }
}
