using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Core.Writer.Contracts;

namespace Traveller.Core.Writer
{
    class ConsoleWriter : IWriter
    {
        public void Write(string args)
        {
            Console.Write(args);
        }
    }
}
