using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Abstractions;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Core.Database.Contracts
{
    public interface ITravellerDatabase
    {
        IList<IVehicle> Vehicles { get; set; }

        IList<IJourney> Journeys { get; set; }

        IList<ITicket> Tickets { get; set; }

    }
}
