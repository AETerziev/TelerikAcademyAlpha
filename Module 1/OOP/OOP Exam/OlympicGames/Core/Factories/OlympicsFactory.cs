using System;
using System.Collections.Generic;
using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics;
using OlympicGames.Olympics.Enums;
using OlympicGames.Olympics.Objects;
using System.Text;
using System.Linq;

namespace OlympicGames.Core.Factories
{
    public class OlympicsFactory : IOlympicsFactory
    {
        private static OlympicsFactory instance = new OlympicsFactory();

        private OlympicsFactory() { }

        public static OlympicsFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public IOlympian CreateBoxer(string firstName, string lastName, string country, string category, int wins, int losses)
        {
            
            BoxingCategory (Enum.Parse(typeof()))
            Enum.TryParse(category,true,out resultCategory); 
            return new Boxer(firstName, lastName, country, resultCategory, wins, losses);
        }

        public IOlympian CreateSprinter(string firstName, string lastName, string country, IDictionary<string, double> records)
        {
            return new Sprinter(firstName, lastName, country, records);
        }
    }
}
