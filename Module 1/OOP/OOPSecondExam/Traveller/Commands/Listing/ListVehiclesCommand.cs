using System;
using System.Collections.Generic;
using System.Linq;
using Traveller.Commands.Contracts;
using Traveller.Commands.Listing;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class ListVehiclesCommand:ListCommand, ICommand
    {
        public ListVehiclesCommand(ITravellerFactory factory, IEngine engine):base(factory,engine)
        {
        }

        public override string Execute(IList<string> parameters)
        {
            var vehicles = this.engine.Vehicles;

            if (vehicles.Count == 0)
            {
                return "There are no registered vehicles.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, vehicles);
        }

    }
}
