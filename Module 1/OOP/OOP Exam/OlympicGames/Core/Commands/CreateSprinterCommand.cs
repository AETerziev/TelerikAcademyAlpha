using System.Collections.Generic;
using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using OlympicGames.Core.Commands.Abstracts;
using System;
using OlympicGames.Olympics.Objects;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand : Command
    {
        // Consider using the dictionary
        private readonly IDictionary<string, double> records;
        private IOlympian currentSprinter;

        public CreateSprinterCommand(IList<string> commandLine) : base(commandLine)
        {
            this.records = new Dictionary<string, double>();
            int recordsCounter = 3;
            while (commandLine.Count > recordsCounter)
            {
                string[] tempRecords = commandLine[recordsCounter].Split('/');
               this. records.Add(tempRecords[0], Double.Parse(tempRecords[1]));
                recordsCounter++;
            }
            if (commandLine.Count < 3)
            {
                throw new ArgumentException(GlobalConstants.ParametersCountInvalid);
            }
            this.currentSprinter = Factory.CreateSprinter(commandLine[0], commandLine[1], commandLine[2], this.records);
                this.Committee.Olympians.Add(this.currentSprinter);
        }
        

        public override string Execute()
        {
            return "Created Sprinter" + "\n" + this.currentSprinter.ToString();
        }
    }
}
