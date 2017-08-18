using System;
using System.Collections.Generic;
using System.Linq;
using Traveller.Commands.Contracts;
using Traveller.Commands.Listing;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class ListTicketsCommand :ListCommand, ICommand
    {
        public ListTicketsCommand(ITravellerFactory factory, IEngine engine):base(factory,engine)
        {
        }

        public override string Execute(IList<string> parameters)
        {
            var tickets = this.engine.Tickets;

            if (tickets.Count == 0)
            {
                return "There are no registered tickets.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, tickets);
        }

    }
}
