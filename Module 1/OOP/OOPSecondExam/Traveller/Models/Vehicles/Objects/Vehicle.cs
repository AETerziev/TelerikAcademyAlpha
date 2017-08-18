using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Enums;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Objects
{
    public class Vehicle : IVehicle
    {
        public Vehicle(int passangerCapacity,decimal pricePerKilometer)
        {
            this.PassangerCapacity = passangerCapacity;
            this.PricePerKilometer = pricePerKilometer;
        }


        private int passangerCapcity;
        private decimal pricePerKilometer;
        private VehicleType type;




        public int PassangerCapacity
        {
            get
            {
                return this.passangerCapcity;
            }
            private set
            {
                if (value<1 || value>800)
                {
                    throw new ArgumentOutOfRangeException("A vehicle with less than 1 passengers or more than 800 passengers cannot exist!");
                }
                this.passangerCapcity = value;
            }
        }

        public decimal PricePerKilometer
        {
            get
            {
                return this.pricePerKilometer;
            }
            private set
            {
                if (value<(decimal)0.10 || value>(decimal)2.50)
                {
                    throw new ArgumentOutOfRangeException("A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!");
                }
                this.pricePerKilometer = value;
            }
        }

        public VehicleType Type
        {
            get
            {
                return this.type;
            }
            internal set
            {
                this.type = value;
            }
        }

        public override string ToString()
        {
            return String.Format(@"{0} ----
Passenger capacity: {1}
Price per kilometer: {2}
Vehicle type: {3}", this.GetType().Name, this.PassangerCapacity, this.PricePerKilometer, this.Type);
        }
    }
}
