using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public static class Point3DStatic
    {
        public static double DistanceBetweenPoints(Point3D point1, Point3D point2)
        {
            double deltaX = point2.XCoordinate - point1.XCoordinate;
            double deltaY = point2.YCoordinate - point1.YCoordinate;
            double deltaZ = point2.ZCoordinate - point1.ZCoordinate;
            return Math.Sqrt(Math.Abs(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ));
        }

        public static Point3D GetPointFromString(string input)
        {
            int x = 0, y = 0, z = 0;
            string[] parts = input.Split(' ');
            x = int.Parse(parts[1].Replace("X=", "").Trim());
            y = int.Parse(parts[1].Replace("Y=", "").Trim());
            z = int.Parse(parts[1].Replace("Z=", "").Trim());
            return new Point3D(x, y, z);
        }
    }
}
