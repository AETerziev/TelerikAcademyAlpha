using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands.Contracts;
using Traveller.Commands.Creating;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Database;
using Traveller.Core.Database.Contracts;
using Traveller.Core.Factories;
using Traveller.Core.Factories.Contracts;
using Traveller.Core.Providers;
using Traveller.Core.Providers.Contracts;
using Traveller.Core.Reader;
using Traveller.Core.Reader.Contracts;
using Traveller.Core.Writer;
using Traveller.Core.Writer.Contracts;

namespace Traveller.Ninject
{
    public class TravellerModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ICommandParser>().To<CommandParser>().InSingletonScope();
            this.Bind<IReader>().To<ConsoleReader>();
            this.Bind<IWriter>().To<ConsoleWriter>();
            this.Bind<IEngine>().To<Engine>()
                .InSingletonScope();

            this.Bind<ITravellerDatabase>().To<TravellerDatabase>().InSingletonScope();
            this.Bind<ITravellerFactory>().To<TravellerFactory>().InSingletonScope();


            this.Bind<ICommand>().To<CreateAirplaneCommand>().Named("createairplane");
            this.Bind<ICommand>().To<CreateBusCommand>().Named("createbus");
            this.Bind<ICommand>().To<CreateJourneyCommand>().Named("createjourney");
            this.Bind<ICommand>().To<CreateTicketCommand>().Named("createticket");
            this.Bind<ICommand>().To<CreateTrainCommand>().Named("createtrain");
            this.Bind<ICommand>().To<ListJourneysCommand>().Named("listjourneys");
            this.Bind<ICommand>().To<ListTicketsCommand>().Named("listtickets");
            this.Bind<ICommand>().To<ListVehiclesCommand>().Named("listvehicles");

            this.Bind<ICommandFactory>()
                .To<CommandFactory>().InSingletonScope();
            
            //.WithConstructorArgument(this.Kernel);

        }
    }
}
