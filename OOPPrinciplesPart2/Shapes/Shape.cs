using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public abstract class Shape
    {
        private double width, height;

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentOutOfRangeException("The widht of the shape should be more than zero!");
                }
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {

                if (value <= 0.0)
                {
                    throw new ArgumentOutOfRangeException("The height of the shape should be more than zero!");
                }
                height = value;
            }
        }

        /// <summary>
        /// Calculates the surface of a shape
        /// </summary>
        /// <param name="width">The width of the shape</param>
        /// <param name="height">The height of the shape</param>
        /// <returns>The calculated surface</returns>
        public abstract double CalculateSurface();

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
