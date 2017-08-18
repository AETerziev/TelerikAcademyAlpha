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
    public class Airplane : Vehicle, IAirplane
    {
        public Airplane(int passangerCapacity,decimal pricePerKilometer,bool hasFreeFood):base(passangerCapacity,pricePerKilometer)
        {
            this.Type =  VehicleType.Air;
            this.HasFreeFood = hasFreeFood;
        }


        private bool hasFreeFood;


        public bool HasFreeFood
        {
            get
            {
                return this.hasFreeFood;
            }
            private set
            {
                this.hasFreeFood = value;
            }
        }


        public override string ToString()
        {
            return base.ToString() + "\n" + String.Format("Has free food: {0}", this.HasFreeFood);
        }
    }
}
