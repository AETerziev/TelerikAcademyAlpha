using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Database.Contracts;
using Traveller.Core.Factories;

namespace Traveller.Commands.Creating
{
    public class CreateBusCommand : ICommand
    {
        private readonly ITravellerDatabase database;
        private readonly ITravellerFactory travelFactory;

        public CreateBusCommand(ITravellerDatabase database, ITravellerFactory travelFactory)
        {
            this.database = database;
            this.travelFactory = travelFactory; 
        }

        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateBus command parameters.");
            }

            var bus = this.travelFactory.CreateBus(passengerCapacity, pricePerKilometer);
            this.database.Vehicles.Add(bus);

            return $"Vehicle with ID {this.database.Vehicles.Count - 1} was created.";
        }
    }
}
