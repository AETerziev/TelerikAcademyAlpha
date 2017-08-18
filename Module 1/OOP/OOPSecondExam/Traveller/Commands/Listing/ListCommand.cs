using System;
using System.Collections;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Listing
{
    public abstract class ListCommand : ICommand
    {
        internal readonly ITravellerFactory factory;
        internal readonly IEngine engine;

        public ListCommand(ITravellerFactory factory,IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public virtual string Execute(IList<string> parameters)
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
