using System;
using System.Collections.Generic;
using System.Text;

namespace GsmApp
{
    public class Display
    {
        #region Private Fields

        double sizeInches;
        int numberOfColors;

        #endregion

        #region Public Properties

        public int NumberOfColors
        {
            get { return numberOfColors; }
            set
            {
                if (value < 2)
                    throw new ArgumentOutOfRangeException("The number of colors of the display should be more than one!");
                numberOfColors = value;
            }
        }

        public double SizeInches
        {
            get { return sizeInches; }
            set
            {
                if (value < 1.0)
                    throw new ArgumentOutOfRangeException("The display size should be at least one inch!");
                sizeInches = value;
            }
        }

        #endregion

        #region Constructors

        public Display(double sizeInches, int numberOfColors)
        {
            this.sizeInches = sizeInches;
            this.numberOfColors = numberOfColors;
        }

        public Display() : this(0.0, 0) { }

        #endregion

        #region Overriden Methods

        public override string ToString()
        {
            return String.Format("Display information:\nSize -> {0} inches\nNumbber of colors: {1}", this.sizeInches, this.numberOfColors);
        }

        #endregion
    }
}
