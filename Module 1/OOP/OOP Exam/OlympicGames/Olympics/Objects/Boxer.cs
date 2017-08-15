using OlympicGames.Olympics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympicGames.Olympics.Enums;
using OlympicGames.Utils;

namespace OlympicGames.Olympics.Objects
{
    public class Boxer :Olympian, IBoxer
    {
        private int losses;
        private int wins;
        private BoxingCategory category;


        public Boxer(string firstName,string lastName,string country,BoxingCategory category,int wins,int losses):base(firstName,lastName,country)
        {
            this.Category = category;
            this.Wins = wins;
            this.Losses = losses;
        }


        public BoxingCategory Category
        {
            get
            {
                return this.category;
            }
            private set
            {
                Validator.ValidateIfNull(value);
                this.category = value;
            }

        }

        public int Losses
        {
            get
            {
                return this.losses;
            }
            private set
            {
                Validator.ValidateMinAndMaxNumber(value, 0, 100);
                this.losses = value;
            }
        }

        public int Wins
        {
            get
            {
                return this.wins;
            }
            private set
            {
                Validator.ValidateMinAndMaxNumber(value, 0, 100);
                this.wins = value;
            }
        }


        public override string ToString()
        {
            return String.Format(@"BOXER: {0} {1} from {2}
Category: {3}
Wins: {4}
Losses: {5}", this.FirstName, this.LastName, this.Country, this.Category, this.Wins, this.Losses);
        }
    }
}
