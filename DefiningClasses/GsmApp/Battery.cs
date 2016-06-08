using System;
using System.Collections.Generic;
using System.Text;

namespace GsmApp
{
    public class Battery
    {
        #region Private Fields
        
        BatteryType model;
        double hoursIdle;
        double hoursTalk;

        #endregion

        #region Public Proerties

        public double HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }

        public double HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }

        public BatteryType Model
        {
            get { return model; }
            set { model = value; }
        }

        #endregion

        #region Constructors

        public Battery(BatteryType model, double hoursIdle, double hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public Battery() : this(BatteryType.Unknown, 0.0, 0.0) { }

        #endregion

        #region Overriden Methods

        public override string ToString()
        {
            return String.Format("Battery information:\nModel -> {0}\nHours idle -> {1}\nHours talk{2}",
                this.model, this.hoursIdle, this.hoursTalk);
        }

        #endregion
    }
}
