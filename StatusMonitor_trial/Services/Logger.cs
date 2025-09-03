using StatusMonitor_trial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusMonitor_trial.Services
{
    public static class Logger
    {
        private static List<LogEntry> _logEntries = new List<LogEntry>();
        public static event EventHandler<LogEntry> LogMessageAdded;

        public static void Log(string message, Color color)
        {
            var logEntry = new LogEntry
            {
                Message = $"{DateTime.Now.ToString("HH:mm:ss")} - {message}",
                Color = color
            };

            _logEntries.Add(logEntry); 
            LogMessageAdded?.Invoke(null, logEntry);
        }

        public static List<LogEntry> GetAllLogs()
        {
            return _logEntries;
        }
        public static void ClearLogs()
        {
            _logEntries.Clear();
        }
    }
}
