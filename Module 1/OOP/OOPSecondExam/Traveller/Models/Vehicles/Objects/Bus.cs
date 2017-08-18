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
   public class Bus:Vehicle,IBus
    {
        public Bus(int passangerCapacity,decimal pricePerKilometer):base(passangerCapacity,pricePerKilometer)
        {
            this.Type = VehicleType.Land;
            if (passangerCapacity<10 || passangerCapacity>50)
            {
                throw new ArgumentOutOfRangeException("A bus cannot have less than 10 passengers or more than 50 passengers");
            }
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
