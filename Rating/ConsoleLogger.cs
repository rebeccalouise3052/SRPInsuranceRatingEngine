using System;
using Rating.Interfaces;

namespace Rating
{
    // Simple console logger that satisfies ILogger.
    // This will be refactored later into a dedicated Logger folder.
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
