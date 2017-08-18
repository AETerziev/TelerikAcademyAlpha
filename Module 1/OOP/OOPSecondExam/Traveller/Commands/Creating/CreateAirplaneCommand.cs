using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class CreateAirplaneCommand : CreateVehicleCommand,ICommand
    {
        public CreateAirplaneCommand(ITravellerFactory factory, IEngine engine) : base(factory, engine)
        {
        }

        public override void PartitialExecute(IList<string> parameters)
        {
            bool hasFreeFood;
            try
            {
                hasFreeFood = bool.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateAirplane command parameters.");
            }
            var airplane = this.factory.CreateAirplane(this.passengerCapacity, this.pricePerKilometer,hasFreeFood);
            this.engine.Vehicles.Add(airplane);
        }

        public override string Execute(IList<string> parameters)
        {
            return base.Execute(parameters);
        }
    }
}
