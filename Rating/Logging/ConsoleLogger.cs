using System;
using Rating.Interfaces;

namespace Rating.Logging
{
    // ConsoleLogger prints log messages directly to the console.
    // This satisfies ILogger and keeps logging separate from business logic.
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
