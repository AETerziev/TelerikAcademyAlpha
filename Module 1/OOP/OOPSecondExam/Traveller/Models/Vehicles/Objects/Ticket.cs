using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Contracts;

namespace Traveller.Models.Vehicles.Objects
{
    class Ticket :PrintingTicketAndJourney, ITicket
    {
        public Ticket(IJourney journey,decimal administrativeCosts)
        {
            this.AdministrativeCosts = administrativeCosts;
            this.Journey = journey;
        }


        private decimal administrativeCosts;
        private IJourney journey;




        public decimal AdministrativeCosts
        {
            get
            {
                return this.administrativeCosts;
            }
            private set
            {
                if (value<(decimal)0)
                {
                    throw new ArgumentOutOfRangeException("The cost must be greater or equal to zero");
                }
                this.administrativeCosts = value;
            }
        }

        public IJourney Journey
        {
            get
            {
                return this.journey;
            }
            private set
            {
                if (value==null)
                {
                    throw new ArgumentNullException("There is no journey for this ticket!");
                }
                this.journey = value;
            }
        }

        public decimal CalculatePrice()
        {
            return this.AdministrativeCosts + this.Journey.CalculateTravelCosts();
        }


        public override string ToString()
        {
            return base.ToString() + "\n" + String.Format(@"Destination: {0}
Price: {1}", this.Journey.Destination, this.CalculatePrice());

        }
    }
}
