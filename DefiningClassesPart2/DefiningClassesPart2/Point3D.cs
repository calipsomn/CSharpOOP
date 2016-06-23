using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    [Version(1, 2)]
    public class Point3D : System.Attribute
    {
        #region Private Fields

        private int x = 0;
        private int y = 0;
        private int z = 0;
        private static readonly Point3D startCoordinates = new Point3D(0, 0, 0);

        #endregion

        #region Public Properties

        public int XCoordinate
        {
            get { return x; }
            set { x = value; }
        }

        public int YCoordinate
        {
            get { return y; }
            set { y = value; }
        }

        public int ZCoordinate
        {
            get { return z; }
            set { z = value; }
        }

        public static Point3D StartCoordinates
        {
            get { return Point3D.startCoordinates; }
        } 

        #endregion

        #region Constructors

        public Point3D(int x, int y, int z) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return String.Format("Point: X={0} Y={1} Z={2}", this.x, this.y, this.z);
        }

        public override bool Equals(object obj)
        {
            Point3D secondPoint = obj as Point3D;
            if (this.x != secondPoint.XCoordinate)
                return false;
            if (this.y != secondPoint.YCoordinate)
                return false;
            if (this.z != secondPoint.ZCoordinate)
                return false;

            return true;
        }

        #endregion
    }
}
