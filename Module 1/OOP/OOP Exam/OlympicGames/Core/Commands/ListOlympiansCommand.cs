using System.Collections.Generic;
using System.Linq;
using System.Text;
using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Contracts;
using OlympicGames.Utils;

namespace OlympicGames.Core.Commands
{
    public class ListOlympiansCommand : Command, ICommand
    {
        private string key;
        private string order;

        public ListOlympiansCommand(IList<string> commandParameters)
            : base(commandParameters)
        {
            if (commandParameters.Count==0)
            {
                this.key = "firstname";
                this.order = "asc";
            }
            else if (commandParameters.Count==2)
            {
                this.key = commandParameters[0];
                this.order = commandParameters[1];

            }
            else if (commandParameters.Count==1 && (commandParameters[0]=="asc" || commandParameters[0]=="desc"))
            {
                this.key = "firstname";
                this.order = commandParameters[0];
            }
            else
            {
                this.key = commandParameters[0];
                this.order = "asc";
            }
           
        }

        // Use it. It works!
        public override string Execute()
        {
            var stringBuilder = new StringBuilder();
            var sorted = this.Committee.Olympians.ToList();

            stringBuilder.AppendLine(string.Format(GlobalConstants.SortingTitle, this.key, this.order));

            if (this.order.ToLower().Trim() == "desc")
            {
                sorted = this.Committee.Olympians.OrderByDescending(x =>
                {
                    return x.GetType().GetProperties().FirstOrDefault(y => y.Name.ToLower() == this.key.ToLower()).GetValue(x, null);
                }).ToList();
            }
            else
            {
                sorted = this.Committee.Olympians.OrderBy(x =>
                {
                    return x.GetType().GetProperties().FirstOrDefault(y => y.Name.ToLower() == this.key.ToLower()).GetValue(x, null);
                }).ToList();
            }

            foreach (var item in sorted)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            if (Committee.Olympians.Count == 0)
            {
                return GlobalConstants.NoOlympiansAdded;
            }
            else
            {
                return stringBuilder.ToString();
            }
        }
    }
}
