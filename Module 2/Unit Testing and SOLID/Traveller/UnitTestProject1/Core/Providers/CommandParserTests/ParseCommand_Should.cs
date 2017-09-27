using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands.Contracts;
using Traveller.Commands.Creating;
using Traveller.Core.Factories.Contracts;
using Traveller.Core.Providers;
using Traveller.Models.Vehicles;

namespace UnitTestProject1.Core.Providers.CommandParserTests
{
    [TestClass]
    public class ParseCommand_Should
    {
        [TestMethod]
        public void PassTheCommandToCommandFactory_WhenParametersAreCorrect()
        {
            //Arrange
            string fullCommand = "createairplane 250 1 true";
            string commandName = fullCommand.Split()[0];
            var commandFactoryMock = new Mock<ICommandFactory>();
            var createAirplaneMock = new Mock<ICommand>();
            commandFactoryMock.Setup(x => x.CreateCommand(commandName)).Returns(createAirplaneMock.Object);

            var expectedOutput = new Mock<ICommand>();
            CommandParser commandParser = new CommandParser(commandFactoryMock.Object);

            //Act
            var producedCommand=commandParser.ParseCommand(commandName);

            //Assert
            Assert.AreEqual(createAirplaneMock.Object, producedCommand);
        }

    }
}
