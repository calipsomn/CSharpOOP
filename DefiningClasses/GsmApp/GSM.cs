using System;
using System.Collections.Generic;
using System.Text;

namespace GsmApp
{
    public class GSM
    {
        #region Private Fields

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private static GSM iPhone4S = new GSM("IPhone", "Apple Inc");
        private List<Call> callHistory = new List<Call>();

        #endregion

        #region Public Properties

        internal Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value <= 0.0m)
                    throw new ArgumentOutOfRangeException("The gsm price should be above 0");
                price = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Display Display
        {
            get { return display; }
            set { display = value; }
        }

        public Call[] CallHistory
        {
            get { return callHistory.ToArray(); }
        }

        public static GSM IPhone4S
        {
            get { return GSM.iPhone4S; }
            set { GSM.iPhone4S = value; }
        }

        #endregion

        #region Constructors

        public GSM(string model, string manufacturer) : this(model, manufacturer, 0.0m, null, null, null) { }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        #endregion

        #region Public Methods

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            if (!callHistory.Contains(call))
                throw new Exception("There is no such call in the call history");
        }

        public void ClearHistory()
        {
            if (this.callHistory != null)
                this.callHistory.Clear();
        }

        #endregion

        #region Overriden Methods

        public override string ToString()
        {
            return String.Format("Device information:\nModel -> {0}\nManufacturer -> {1}\nPrice -> {2:C}\nOwner -> {3}\n Battery -> {4}\n Display -> {5}",
                this.model, this.manufacturer, this.price, this.owner ?? "unknown", this.battery != null ? this.battery.ToString() : "unknown",
                this.display != null ? this.display.ToString() : "unknown");
        }

        #endregion
    }
}
