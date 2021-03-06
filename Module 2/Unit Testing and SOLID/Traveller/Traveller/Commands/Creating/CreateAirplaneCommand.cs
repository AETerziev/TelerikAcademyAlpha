﻿using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Database.Contracts;
using Traveller.Core.Factories;

namespace Traveller.Commands.Creating
{
    public class CreateAirplaneCommand : ICommand
    {
        private readonly ITravellerDatabase database;
        private readonly ITravellerFactory travelFactory;

        public CreateAirplaneCommand(ITravellerDatabase database, ITravellerFactory travelFactory)
        {
            this.database = database;
            this.travelFactory = travelFactory;
        }

        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            bool hasFreeFood;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                hasFreeFood = bool.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateAirplane command parameters.");
            }

            var airplane = this.travelFactory.CreateAirplane(passengerCapacity, pricePerKilometer, hasFreeFood);
            this.database.Vehicles.Add(airplane);

            return $"Vehicle with ID {this.database.Vehicles.Count - 1} was created.";
        }
    }
}
