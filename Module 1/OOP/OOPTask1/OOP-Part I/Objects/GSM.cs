using System;
using System.Collections.Generic;


namespace OOP_Part_I
{
    public class GSM
    {
        private const double pricePerMinute = 0.37;
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Calls> callHistory;
        public static GSM Iphone4S = new GSM("Iphone4S", "Apple", 1500, "Nasko", new Battery("Samsung", 10, 50, BatteryType.NiMH), new Display(10, 15000000));

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
                if (this.model.Length < 1)
                {
                    throw new ArgumentOutOfRangeException("The model must be more than one letter");
                }

            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
                if (manufacturer.Length > 30)
                {
                    throw new ArgumentOutOfRangeException("Manufacturer's name must be less than 30 letters");
                }
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
                if (this.price <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price must be larger than 0");
                }
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
                if (owner.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException("The name of the owner must be larger than 0 letters");
                }
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
                if (this.battery == null)
                {
                    throw new NullReferenceException("You have to make an instance of this property to use it");
                }
            }

        }
        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
                if (this.display == null)
                {
                    throw new NullReferenceException("You have to make an instance of this property to use it");
                }
            }

        }
        public List<Calls> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
                if (this.callHistory==null)
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public GSM():this(null,null,0,null,null,null)
        {

        }
        public GSM(string model):this(model,null,0,null,null,null)
        {
        }
        public GSM(string model, string manufacturer):this(model,manufacturer,0,null,null,null)
        {
        }
        public GSM(string model, string manufacturer, int price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public override string ToString()
        {
            return ("Model:" + this.Model + "\n"
                + "Manufacturer:" + this.Manufacturer + "\n"
                + "Price:" + this.Price + "\n"
                + "Owner:" + this.Owner + "\n"
                + "Battery model:" + this.Battery.Model + "\n"
                + "Battery Hours idle:" + this.Battery.HoursIdle + "\n"
                + "Battery Hours talk:" + this.Battery.HoursTalk + "\n"
                + "Display Size:" + this.Display.Size + "\n"
                + "Display Colors:"+ this.Display.ColorCount + "\n").ToString();
        }
        public void AddCall(DateTime dateTime,string dialedPhone,int duration)
        {
            this.CallHistory.Add(new Calls(dateTime,dialedPhone,duration));
        }
        public void ClearCalls()
        {
            this.CallHistory.Clear();
        }
        public void DeleteCall(int index)
        {
            this.CallHistory.RemoveAt(index);
        }
        public double TotalPriceOfCalls()
        {
            double total = 0;
            foreach (Calls call in callHistory)
            {
                total += call.DurationInMinutes * pricePerMinute;
            }
            return total;
            
        }
    }
}
