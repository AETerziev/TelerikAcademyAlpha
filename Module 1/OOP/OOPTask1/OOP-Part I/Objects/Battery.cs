using System;

namespace OOP_Part_I
{
    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        public BatteryType? BatteryType{ get; private set; }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
                if (this.model.Length > 30)
                {
                    throw new ArgumentOutOfRangeException("Model name cannot be more than 30 symbols");
                }
            }
        }
        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
                if (this.hoursIdle<=0)
                {
                    throw new ArgumentOutOfRangeException("Hours Idle must be more than 0");
                }
            }
        }
        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
                if (this.hoursTalk<=0)
                {
                    throw new ArgumentOutOfRangeException("Hours Talk must be more than 0");
                }
            }
        }

        public Battery():this(null,0,0,null)
        {

        }
        public Battery(string model):this(model,0,0,null)
        {
        }
        public Battery(string model,int hoursIdle,int hoursTalk,BatteryType? batteryType)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Model = model;
            this.BatteryType = batteryType;
        }



    }
}
