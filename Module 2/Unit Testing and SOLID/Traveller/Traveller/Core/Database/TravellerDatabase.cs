using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Core.Database.Contracts;
using Traveller.Models.Abstractions;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Core.Database
{
    public class TravellerDatabase : ITravellerDatabase
    {
        public TravellerDatabase()
        {
            this.Vehicles = new List<IVehicle>();
            this.Journeys = new List<IJourney>();
            this.Tickets = new List<ITicket>();

            Guard.WhenArgument(Vehicles, "Vehicles").IsNull().Throw();
            Guard.WhenArgument(Journeys, "Journeys").IsNull().Throw();
            Guard.WhenArgument(Tickets, "Tickets").IsNull().Throw();
        }

        public IList<IVehicle> Vehicles
        {
            get;
            set;
        }
        

        public IList<IJourney> Journeys
        {
            get;
            set;
        }

        public IList<ITicket> Tickets
        {
            get;
            set;
        }
    }
}
