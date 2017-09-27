using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Database.Contracts;
using Traveller.Core.Factories;
using Traveller.Models;
using Traveller.Models.Abstractions;

namespace Traveller.Commands.Creating
{
    public class CreateTicketCommand : ICommand
    {
        private readonly ITravellerDatabase database;
        private readonly ITravellerFactory travelFactory;

        public CreateTicketCommand(ITravellerDatabase database, ITravellerFactory travelFactory)
        {
            this.database = database;
            this.travelFactory = travelFactory;
        }

        public string Execute(IList<string> parameters)
        {
            IJourney journey;       
            decimal administrativeCosts;

            try
            {
                journey = this.database.Journeys[int.Parse(parameters[0])];
                administrativeCosts = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTicket command parameters.");
            }

            var ticket = this.travelFactory.CreateTicket(journey, administrativeCosts);
            this.database.Tickets.Add(ticket);  

            return $"Ticket with ID {this.database.Tickets.Count - 1} was created.";
        }
    }
}
