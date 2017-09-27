using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using System.Text;
using Traveller.Core.Contracts;
using Traveller.Core.Providers;
using Traveller.Core.Providers.Contracts;
using Traveller.Core.Reader.Contracts;
using Traveller.Core.Writer.Contracts;
using Traveller.Models;
using Traveller.Models.Abstractions;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Core
{
    public class Engine:IEngine
    {
        private const string TerminationCommand = "Exit";
        private const string NullProvidersExceptionMessage = "cannot be null.";
        private readonly ICommandParser commandParser;
        private readonly IReader reader;
        private readonly IWriter writer;

        private StringBuilder Builder = new StringBuilder();

        public Engine(ICommandParser commandParser, IReader reader, IWriter writer)
        {
            this.commandParser = commandParser;
            this.reader = reader;
            this.writer = writer;

            Guard.WhenArgument(commandParser, "commandParser").IsNull().Throw();
            Guard.WhenArgument(reader, "reader").IsNull().Throw();
            Guard.WhenArgument(writer, "writer").IsNull().Throw();

        }

        public void Start()
        {
            while (true)
            {
                try
                {
                    var commandAsString = this.reader.Read();

                    if (commandAsString.ToLower() == TerminationCommand.ToLower())
                    {
                        this.writer.Write(this.Builder.ToString());
                        break;
                    }

                    this.ProcessCommand(commandAsString);
                }
                catch (Exception ex)
                {
                    this.Builder.AppendLine(ex.Message);
                }
            }
        }

        private void ProcessCommand(string commandAsString)
        {
            if (string.IsNullOrWhiteSpace(commandAsString))
            {
                throw new ArgumentNullException("Command cannot be null or empty.");
            }

            var command = this.commandParser.ParseCommand(commandAsString);
            var parameters = this.commandParser.ParseParameters(commandAsString);

            var executionResult = command.Execute(parameters);
            this.Builder.AppendLine(executionResult);
        }
    }
}
