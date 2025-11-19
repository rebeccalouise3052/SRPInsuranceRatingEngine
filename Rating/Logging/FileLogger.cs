using System;
using System.IO;
using Rating.Interfaces;

namespace Rating.Logging
{
    // FileLogger writes log messages to a text file.
    // This is useful because it allows logging to persist after the app closes.
    public class FileLogger : ILogger
    {
        private readonly string _logFilePath;

        public FileLogger(string logFilePath = "rating.log")
        {
            _logFilePath = logFilePath;
        }

        public void Log(string message)
        {
            try
            {
                File.AppendAllText(_logFilePath, message + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Logging failed: {ex.Message}");
            }
        }
    }
}