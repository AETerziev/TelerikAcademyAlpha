using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Olympics.Objects
{
    public class Sprinter : Olympian, ISprinter
    {
        private IDictionary<string, double> personalRecords;
        private HashSet<string> container;


        public Sprinter(string firstName, string lastName, string country, IDictionary<string, double> personalRecords) : base(firstName, lastName, country)
        {
            this.PersonalRecords = personalRecords;
            this.container = new HashSet<string>();
        }


        public IDictionary<string, double> PersonalRecords
        {
            get
            {
                return this.personalRecords;
            }
            private set
            {
                Validator.ValidateIfNull(value);
                this.personalRecords = value;
            }
        }


        // MY OWN MAGIC!!! / p.s. All records "Stringosani" and ready to use.
        private string GetAllRecords()
        {
            foreach (KeyValuePair<string, double> item in this.PersonalRecords)
            {
                this.container.Add(String.Format("{0}m: {1}s", item.Key, item.Value));
            }
            return String.Join("\n", this.container);
        }

        public override string ToString()
        {
            if (this.PersonalRecords.Count>0)
            {
                return String.Format(@"SPRINTER: {0} {1} from {2}
PERSONAL RECORDS:
{3}", this.FirstName, this.LastName, this.Country, this.GetAllRecords());
            }
            else
            {
                return String.Format(@"SPRINTER: {0} {1} from {2}"+"\n" + GlobalConstants.NoPersonalRecordsSet, this.FirstName, this.LastName, this.Country);
            }
        }
    }
}
