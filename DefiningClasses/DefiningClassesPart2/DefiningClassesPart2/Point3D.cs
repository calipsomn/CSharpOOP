using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public class Point3D
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
    }
}
