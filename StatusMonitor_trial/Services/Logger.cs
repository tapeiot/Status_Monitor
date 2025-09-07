using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace StatusMonitor_trial.Services 
{
    public static class Logger
    {

        private static readonly object _fileLock = new object();

        private static readonly string _logFileName = $"log-{DateTime.Now:yyyy-MM-dd}.txt";

        private static readonly string _logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _logFileName);

        private static List<LogEntry> _logEntries = new List<LogEntry>();
        public static event EventHandler<LogEntry> LogMessageAdded;

        public static void Log(string message, Color color)
        {
            var logEntry = new LogEntry
            {
                Message = $"{DateTime.Now:HH:mm:ss} - {message}",
                Color = color
            };

            _logEntries.Add(logEntry);
            LogMessageAdded?.Invoke(null, logEntry);

            WriteToFile(logEntry.Message);
        }

        private static void WriteToFile(string message)
        {
            lock (_fileLock)
            {
                try
                {
                    File.AppendAllText(_logFilePath, message + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error writing to log file: {ex.Message}");
                }
            }
        }

        public static List<LogEntry> GetLogs()
        {
            return _logEntries;
        }

        public static void ClearLogs()
        {
            _logEntries.Clear();
        }
    }

    public class LogEntry
    {
        public string Message { get; set; }
        public Color Color { get; set; }
    }
}