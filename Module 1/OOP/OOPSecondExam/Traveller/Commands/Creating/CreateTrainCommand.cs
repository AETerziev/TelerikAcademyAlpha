using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class CreateTrainCommand :CreateVehicleCommand, ICommand
    {


        public CreateTrainCommand(ITravellerFactory factory, IEngine engine):base(factory,engine)
        {
        }



        public override void PartitialExecute(IList<string> parameters)
        {
            int cartsCount;
            try
            {
                cartsCount = int.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTrain command parameters.");
            }
            var train = this.factory.CreateTrain(this.passengerCapacity, this.pricePerKilometer,cartsCount);
            this.engine.Vehicles.Add(train);
        }


        public override string Execute(IList<string> parameters)
        {
            return base.Execute(parameters);
        }

    }
}
