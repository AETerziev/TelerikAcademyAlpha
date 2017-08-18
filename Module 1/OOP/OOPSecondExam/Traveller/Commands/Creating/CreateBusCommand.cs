using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class CreateBusCommand :CreateVehicleCommand, ICommand
    {

        public CreateBusCommand(ITravellerFactory factory, IEngine engine):base(factory,engine)
        {
        }


        public override void PartitialExecute(IList<string> parameters)
        {
            var bus = this.factory.CreateBus(this.passengerCapacity, this.pricePerKilometer);
            this.engine.Vehicles.Add(bus);

        }


        public override string Execute(IList<string> parameters)
        {
            return base.Execute(parameters);
        }

    }
}
