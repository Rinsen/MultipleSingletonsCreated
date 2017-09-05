using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem
{
    public class DoNothingLogProvider : ILoggerProvider
    {
        private static int numberOfSingletonsCreated = 0;

        public DoNothingLogProvider()
        {
            numberOfSingletonsCreated++;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new DoNothingLogger();
        }

        public void Dispose()
        {
            throw new Exception("This will never be called on the first(?) singleton");
        }
    }
}
