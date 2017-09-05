using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem
{
    public static class LogExtensions
    {
        public static void AddDoNothingLogger(this ILoggingBuilder loggingBuilder)
        {
            
            loggingBuilder.Services.AddSingleton<ILoggerProvider, DoNothingLogProvider>();
        }
    }
}
