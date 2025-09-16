using Microsoft.VisualBasic.ApplicationServices;
using StatusMonitor_trial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StatusMonitor_trial.Services
{

    public static class PrinterService
    {
        private static readonly string dataFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "printer.json");
        private static List<PrinterInfo> _printers = new List<PrinterInfo>();
        private static Dictionary<string, PrinterConnection> _activeConnections = new Dictionary<string, PrinterConnection>();
        public static event EventHandler PrintersListChanged; 
        public static event EventHandler<PrinterInfo> PrinterStatusChanged; 

        public static List<PrinterInfo> GetPrinters()
        {
            return _printers.ToList();
        }
        public static void SavePrinter()
        {
            var jsonString = JsonSerializer.Serialize(_printers);
            File.WriteAllText(dataFile, jsonString);
        }

        public static void LoadPrinter()
        {
            if (File.Exists(dataFile))
            {
                var jsonString = File.ReadAllText(dataFile);
                _printers = JsonSerializer.Deserialize<List<PrinterInfo>>(jsonString);
            }
        }
        public static void AddPrinter(PrinterInfo printer)
        {
            _printers.Add(printer);
            PrintersListChanged?.Invoke(null, EventArgs.Empty);
            SavePrinter();
        }

        public static void UpdatePrinter(PrinterInfo updatedPrinter)
        {
            var existingPrinter = _printers.FirstOrDefault(p => p.Name == updatedPrinter.Name);
            if (existingPrinter != null)
            {
                existingPrinter.IP = updatedPrinter.IP;
                existingPrinter.Port = updatedPrinter.Port;
                existingPrinter.LastEdited = DateTime.Now;
            }
            PrintersListChanged?.Invoke(null, EventArgs.Empty);
            SavePrinter();
        }

        public static void DeletePrinter(string printerName)
        {
            _printers.RemoveAll(p => p.Name == printerName);
            PrintersListChanged?.Invoke(null, EventArgs.Empty);
            SavePrinter();
        }

        public static PrinterConnection? GetConnection(string printerName)
        {
            if (_activeConnections.TryGetValue(printerName, out var connection))
            {
                return connection;
            }
            return null;
        }

        public static async Task ConnectPrinterAsync(PrinterInfo printer)
        {
            if (_activeConnections.ContainsKey(printer.Name))
            {
                _activeConnections[printer.Name].Disconnect();
                _activeConnections.Remove(printer.Name);
            }

            var connection = new PrinterConnection(printer);
            bool success = await connection.ConnectAsync();

            if (success)
            {
                _activeConnections[printer.Name] = connection;

                Logger.Log($"Connected to {printer.Name}", Color.Green);
                PrinterStatusChanged?.Invoke(null, printer);
                StatusButtonManager.UpdateReconnectStatus(printer.Name, true);
            }
            else
            {

                Logger.Log($"Failed to connect to {printer.Name}", Color.Red);
                PrinterStatusChanged?.Invoke(null, printer);
                StatusButtonManager.UpdateReconnectStatus(printer.Name, false);
            }
        }
        public static async Task ReconnectAllPrintersAsync()
        {

            var printersToReconnect = _printers.ToList();

            foreach (var printer in printersToReconnect)
            {
                await ConnectPrinterAsync(printer);
            }
        }
        public static class StatusButtonManager
        {
            private static List<Button> _reconnectButtons;
            private static List<Button> _statusButtonsST;

            public static void SeteReconnectButtons(List<Button> buttons)
            {
                _reconnectButtons = buttons;
            }
            public static void SetStatusButtons(List<Button> buttons)
            {
                _statusButtonsST = buttons;
            }
            public static void UpdateReconnectStatus(string printerName, bool isConnected)
            {
                if (_reconnectButtons == null) return;

                foreach (var button in _reconnectButtons)
                {
                    if (button.Tag?.ToString() == printerName)
                    {
                        button.BackColor = isConnected ? Color.LightGreen : Color.LightGray;
                        break;
                    }
                }
            }
            public static void UpdateStatus(string printerName, Color color)
            {
                if (_statusButtonsST == null) return;
                foreach (var button in _statusButtonsST)
                {
                    if (button.Tag?.ToString() == printerName)
                    {
                        button.BackColor = color;
                        break;
                    }
                }
            }

        }
        public static async Task<List<FieldCheckResult>> CheckJobFieldsAsync(List<PrinterInfo> printersToCheck)
        {
            var results = new List<FieldCheckResult>();
            var tasks = new List<Task<FieldCheckResult>>();

            foreach (var printer in printersToCheck)
            {
                tasks.Add(Task.Run(async () =>
                {
                    var result = new FieldCheckResult { PrinterName = printer.Name };
                    var conn = GetConnection(printer.Name);

                    if (conn == null || !conn.IsConnected)
                    {
                        result.IsConnected = false;
                        result.ErrorMessage = "Not Connected";
                        return result;
                    }

                    try
                    {
                        result.IsConnected = true;
                        await conn.SendAsync("GJD");
                        string response = await conn.ReadAsync();
                        var (count, fields) = ParseResponse(response);

                        foreach (var field in fields)
                        {
                            var parts = field.Split('=');
                            if (parts.Length == 2)
                            {
                                result.FieldValues[parts[0]] = parts[1];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        result.ErrorMessage = ex.Message;
                    }
                    return result;
                }));
            }

            var completedTasks = await Task.WhenAll(tasks);
            results.AddRange(completedTasks);

            return results;
        }
        public static (int count, List<string> items) ParseResponse(string response)
        {
            string[] parts = response
                .Replace("<CR>", "")
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim('\r', '\n'))
                .ToArray();
            int count = (parts.Length > 1 && int.TryParse(parts[1], out int n)) ? n : 0;
            List<string> items = parts.Skip(2).ToList();
            return (count, items);
        }
    }
}


