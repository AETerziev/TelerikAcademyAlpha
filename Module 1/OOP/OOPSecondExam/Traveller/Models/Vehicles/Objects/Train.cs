using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Enums;
using Traveller.Models.Objects;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles.Objects
{
    public class Train : Vehicle, ITrain
    {
        public Train(int passangerCapacity, decimal pricePerKilometer, int carts) : base(passangerCapacity, pricePerKilometer)
        {
            this.Carts = carts;
            this.Type = VehicleType.Land;
            if (passangerCapacity < 30 || passangerCapacity > 150)
            {
                throw new ArgumentOutOfRangeException("A train cannot have less than 30 passengers or more than 150 passengers.");
            }
        }


        private int carts;


        public int Carts
        {
            get
            {
                return this.carts;
            }
            private set
            {
                if (value < 1 || value > 15)
                {
                    throw new ArgumentOutOfRangeException("A train cannot have less than 1 cart or more than 15 carts.");
                }
                this.carts = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + String.Format("Carts amount: {0}", this.Carts);        }
    }
}
