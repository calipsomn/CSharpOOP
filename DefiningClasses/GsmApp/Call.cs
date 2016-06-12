using System;
using System.Collections.Generic;
using System.Text;

namespace GsmApp
{
    public class Call
    {
        #region Private Fields

        private DateTime date;
        private int durationInSeconds;
        private string dialedNumber;

        #endregion

        #region Public Properties

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int DurationInSeconds
        {
            get { return durationInSeconds; }
            set { durationInSeconds = value; }
        }

        public string DialedNumber
        {
            get { return dialedNumber; }
            set { dialedNumber = value; }
        }

        #endregion

        #region Constructors

        public Call(DateTime date, int duration, string dialedNumber)
        {
            this.date = date;
            this.durationInSeconds = duration;
            this.dialedNumber = dialedNumber;
        }

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return String.Format("Call information:\n Date -> {0}\n Duration -> {1} seconds\n Dialed number -> {2}",
                this.date, this.durationInSeconds, this.dialedNumber);
        }

        #endregion
    }
}
