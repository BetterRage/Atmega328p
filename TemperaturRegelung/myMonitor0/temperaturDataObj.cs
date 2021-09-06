using System;

namespace myMonitor0
{
    public class temperaturDataObj
    {
        public temperaturDataObj(int temp, bool logged)
        {
            this.TemperaturSetInt = temp;
            this.Logged = logged;
        }
        public temperaturDataObj(string temp, bool logged,DateTime zeit)
        {
            this.TemperaturString = temp;
            this.Logged = logged;
            this.Zeit = zeit;
        }
        public temperaturDataObj()
        {
        }
        private float temperatur;
        private DateTime zeit;
        public DateTime Zeit
        {
            get
            {
                return zeit;
            }
            set
            {
                zeit = value;
            }
        }
        public float TemperaturGetFloat
        { 
            get
            {
                return temperatur;
            }
        }
        public int TemperaturSetInt
        {
            set
            {
                if (value < 0 || value > 1023)
                    temperatur = 0;
                else
                {
                    temperatur = Convert.ToSingle(value * 100.0 / 1023.0);
                }
            }
        }
        public string TemperaturString
        {
            get
            {
                return temperatur.ToString("0.00")+"";
            }
            set
            {
                float input = float.Parse(value);
                if (input < 0 || input > 1023)
                    temperatur = 0;
                else
                {
                    temperatur = input * 100 / 1023;
                }
            }
        }
        public bool Logged
        {
            get;
            set;
        }
    }
}
