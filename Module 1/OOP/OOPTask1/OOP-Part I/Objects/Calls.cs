using System;


namespace OOP_Part_I
{
    public class Calls
    {
        private DateTime? callTime;
        private string dialledPhone;
        private int durationInMinutes;

        public DateTime? CallTime
        {
            get
            {
                return this.callTime;
            }
            set
            {
                this.callTime = value;
                if (this.callTime==null)
                {
                    throw new ArgumentNullException();
                }
            }
        }
        public string DialledPhone
        {
            get
            {
                return this.dialledPhone;
            }
            set
            {
                this.dialledPhone = value;
                if (this.dialledPhone.Length<0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public int DurationInMinutes
        {
            get
            {
                return this.durationInMinutes;
            }
            set
            {
                this.durationInMinutes = value;
                if (this.durationInMinutes<0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Calls():this(null,null,0)
        {

        }
        public Calls(DateTime? callTime,string dialledPhone,int durationInMinutes)
        {
            this.CallTime = callTime;
            this.DialledPhone = dialledPhone;
            this.DurationInMinutes = durationInMinutes;
        }

        public override string ToString()
        {
            return String.Format("Call time:{0} \n Dialed Phone:{1} \n Duration:{2}", this.CallTime, this.DialledPhone, this.DurationInMinutes);
        }


    }
}
