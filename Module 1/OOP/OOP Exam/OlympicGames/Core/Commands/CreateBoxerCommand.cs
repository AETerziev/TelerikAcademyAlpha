using System;
using System.Collections.Generic;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using OlympicGames.Core.Commands.Abstracts;

namespace OlympicGames.Core.Commands
{
    public class CreateBoxerCommand : Command
    {
        private IOlympian currentBoxer;


        public CreateBoxerCommand(IList<string> commandLine) : base(commandLine)
        {
            if (commandLine.Count<3)
            {
                throw new ArgumentException(GlobalConstants.ParametersCountInvalid);
            }
            this.currentBoxer = Factory.CreateBoxer(commandLine[0], commandLine[1], commandLine[2], commandLine[3], Int32.Parse(commandLine[4]), Int32.Parse(commandLine[5]));
            this.Committee.Olympians.Add(this.currentBoxer);
        }

        public override string Execute()
        {
            return "Created Boxer"+ "\n" + this.currentBoxer.ToString();
        }
    }
}