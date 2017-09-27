using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Database.Contracts;
using Traveller.Core.Factories;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Commands.Creating
{
    public class CreateJourneyCommand : ICommand
    {
        private readonly ITravellerDatabase database;
        private readonly ITravellerFactory travelFactory;

        public CreateJourneyCommand(ITravellerDatabase database, ITravellerFactory travelFactory)
        {
            this.database = database;
            this.travelFactory = travelFactory;
        }

        public string Execute(IList<string> parameters)
        {
            string startLocation;
            string destination;
            int distance;
            IVehicle vehicle;

            try
            {
                startLocation = parameters[0];
                destination = parameters[1];
                distance = int.Parse(parameters[2]);
                vehicle = this.database.Vehicles[int.Parse(parameters[3])];
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateJourney command parameters.");
            }

            var journey = this.travelFactory.CreateJourney(startLocation, destination, distance, vehicle);
            this.database.Journeys.Add(journey);

            return $"Journey with ID {this.database.Journeys.Count - 1} was created.";
        }
    }
}
