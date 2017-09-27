using System.Collections.Generic;
using Traveller.Core.Database.Contracts;

namespace Traveller.Commands.Contracts
{
    public interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
