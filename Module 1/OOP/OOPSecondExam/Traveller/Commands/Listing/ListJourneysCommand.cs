using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Commands.Listing;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class ListJourneysCommand :ListCommand, ICommand
    {
        public ListJourneysCommand(ITravellerFactory factory, IEngine engine):base(factory,engine)
        {
        }

        public override string Execute(IList<string> parameters)
        {
            var journeys = this.engine.Journeys;

            if (journeys.Count == 0)
            {
                return "There are no registered journeys.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, journeys);
        }

    }
}
