using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Traveller.Core.Factories.Contracts;
using Traveller.Core.Providers;

namespace UnitTestProject1.Core.Providers.CommandParserTests
{
    [TestClass]
    public class ParseParameters_Should
    {
        [TestMethod]
        public void GenerateListWithArguments_WhenParametersAreCorrect()
        {
            //Arrange
            string command = "createairplane 250 2.7 true";
            var commandParts = command.Split().Skip(1).ToList();
            var commandFactoryMock = new Mock<ICommandFactory>();
            var createAirplaneMock = new Mock<ICommand>();

            var expectedOutput = new List<string>();
            CommandParser commandParser = new CommandParser(commandFactoryMock.Object);

            //Act
            var currentResult=commandParser.ParseParameters(command);

            //Assert
            Assert.AreEqual(expectedOutput, currentResult);

        }
    }
}
