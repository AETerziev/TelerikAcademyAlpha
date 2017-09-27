using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands.Creating;
using Traveller.Core.Contracts;
using Traveller.Core.Database;
using Traveller.Core.Database.Contracts;
using Traveller.Models;
using Traveller.Models.Abstractions;
using Traveller.Models.Vehicles.Abstractions;

namespace UnitTestProject1.Commnands.Creating.CreateTicketCommandTests
{
    [TestClass]
    public class Execute_Should
    {
        private const string SuccessMessage = "Ticket with ID 0 was created.";


        [TestMethod]
        public void ReturnSuccessfulCreatingMesseage_WhenParametersAreCorrcet()
        {
            string administrativeCosts = "30";
            string currentJourney = "0";

            //Arrange
            List<string> parameters = new List<string>
            {
                currentJourney,
                administrativeCosts
            };
            var travellerFactoryMock = new Mock<ITravellerFactory>();
            var databaseMock = new Mock<ITravellerDatabase>();
            var journeyMock = new Mock<IJourney>();
            var ticketMock = new Mock<ITicket>();
            List<IJourney> journeys = new List<IJourney>();
            journeys.Add(journeyMock.Object);
            List<ITicket> tickets = new List<ITicket>();
            databaseMock.SetupGet(x => x.Journeys).Returns(journeys);
            databaseMock.SetupGet(x => x.Tickets).Returns(tickets);

            travellerFactoryMock.Setup(x => x.CreateTicket(It.IsAny<IJourney>(), It.IsAny<decimal>())).Returns(ticketMock.Object);


            CreateTicketCommand command = new CreateTicketCommand(databaseMock.Object,travellerFactoryMock.Object);

            //Act
            string currentResult = command.Execute(parameters);

            //Assert
            Assert.AreEqual(currentResult, SuccessMessage);
        }

            

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowExceptions_WhenParametersAreIncorrect()
        {
            //Arrange
            string wrongAdministrativeCosts = "1";
            string wrongJourney = "1";

            List<string> parameters = new List<string>
            {
                wrongJourney,
                wrongAdministrativeCosts
                
                
            };

            var travellerFactoryMock = new Mock<ITravellerFactory>();
            var databaseMock = new Mock<ITravellerDatabase>();
            var journeyMock = new Mock<IJourney>();
            var ticketMock = new Mock<ITicket>();
            List<IJourney> journeys = new List<IJourney>();
            journeys.Add(journeyMock.Object);
            List<ITicket> tickets = new List<ITicket>();
            databaseMock.SetupGet(x => x.Journeys).Returns(journeys);
            databaseMock.SetupGet(x => x.Tickets).Returns(tickets);
            travellerFactoryMock.Setup(x => x.CreateTicket(It.IsAny<IJourney>(), It.IsAny<decimal>())).Returns(ticketMock.Object);

            CreateTicketCommand command = new CreateTicketCommand(databaseMock.Object, travellerFactoryMock.Object);

            //Act & Assert
            string currentResult = command.Execute(parameters);


        }


        [TestMethod]
        public void AddInstncesInJourneyListAndTicketList_WhenExecuteIsInvoked()
        {
            string administrativeCosts = "30";
            string currentJourney = "0";
            string secondAdministrativeCosts = "40";
            string secondCurrentJourney = "1";

            //Arrange
            List<string> parameters = new List<string>
            {
                currentJourney,
                administrativeCosts
            };

            List<string> secondParameters = new List<string>
            {
                secondCurrentJourney,
                secondAdministrativeCosts
            };

            var travellerFactoryMock = new Mock<ITravellerFactory>();
            var databaseMock = new Mock<ITravellerDatabase>();
            var journeyMock = new Mock<IJourney>();
            var secondJourneyMock = new Mock<IJourney>();
            var ticketMock = new Mock<ITicket>();
            List<IJourney> journeys = new List<IJourney>();
            journeys.Add(journeyMock.Object);
            journeys.Add(secondJourneyMock.Object);

            List<ITicket> tickets = new List<ITicket>();
            databaseMock.SetupGet(x => x.Journeys).Returns(journeys);
            databaseMock.SetupGet(x => x.Tickets).Returns(tickets);

            travellerFactoryMock.Setup(x => x.CreateTicket(It.IsAny<IJourney>(), It.IsAny<decimal>())).Returns(ticketMock.Object);


            CreateTicketCommand command = new CreateTicketCommand(databaseMock.Object, travellerFactoryMock.Object);

            //Act
            command.Execute(parameters);
            command.Execute(secondParameters);


            //Assert
            Assert.AreEqual(databaseMock.Object.Journeys.Count, 2);
            Assert.AreEqual(databaseMock.Object.Tickets.Count, 2);
        }


    }
}
