using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Models.Vehicles.Objects
{
    public abstract class PrintingTicketAndJourney
    {
        public override string ToString()
        {
            return String.Format(@"{0} ----", this.GetType().Name);
        }
    }
}
