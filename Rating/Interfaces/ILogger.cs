namespace Rating.Interfaces
{
    // ILogger defines a simple contract for logging messages.
    // Concrete classes (ConsoleLogger, FileLogger, etc.) will implement this.
    public interface ILogger
    {
        void Log(string message);
    }
}