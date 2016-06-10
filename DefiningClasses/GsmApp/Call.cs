using System;
using System.Collections.Generic;
using System.Text;

namespace GsmApp
{
    public class Call
    {
        private DateTime date;
        private int duration;
        private string dialedNumber;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public string DialedNumber
        {
            get { return dialedNumber; }
            set { dialedNumber = value; }
        }

        public Call(DateTime date, int duration, string dialedNumber)
        {
            this.date = date;
            this.duration = duration;
            this.dialedNumber = dialedNumber;
        }
    }
}
