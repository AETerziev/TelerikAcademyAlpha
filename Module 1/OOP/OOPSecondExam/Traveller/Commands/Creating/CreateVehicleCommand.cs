using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public abstract class CreateVehicleCommand : ICommand
    {
        internal readonly ITravellerFactory factory;
        internal readonly IEngine engine;
        internal int passengerCapacity;
        internal decimal pricePerKilometer;



        public CreateVehicleCommand(ITravellerFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public abstract void PartitialExecute(IList<string> parameters); //  Includes initializing parameters which are not common for every Vehicle

        public virtual string Execute(IList<string> parameters)
        {

            try
            {
                this.passengerCapacity = int.Parse(parameters[0]);
                this.pricePerKilometer = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateBus command parameters.");
            }
            PartitialExecute(parameters);

            return $"Vehicle with ID {engine.Vehicles.Count - 1} was created.";
        }
    }
}
