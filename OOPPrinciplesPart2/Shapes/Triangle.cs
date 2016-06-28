using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Triangle:Shape
    {
        public override double CalculateSurface()
        {
            return Height * Width / 2.0;
        }

        public Triangle(double width, double height) : base(width, height) { }
    }
}
