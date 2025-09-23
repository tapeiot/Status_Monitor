using StatusMonitor_trial.Helpers;
using StatusMonitor_trial.Models;
using StatusMonitor_trial.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StatusMonitor_trial.Log;
using static StatusMonitor_trial.Services.PrinterService;

namespace StatusMonitor_trial
{
    public partial class Log : BaseForm, IRefreshable
    {
        private List<Button> statusButtons;
        public Log()
        {
            InitializeComponent();
            statusButtons = new List<Button>
            {
                btnRC1, btnRC2, btnRC3, btnRC4, btnRC5, btnRC6, btnRC7, btnRC8, btnRC9, btnRC10
            };

            var printers = PrinterService.GetPrinters();

            for (int i = 0; i < printers.Count && i < statusButtons.Count; i++)
            {
                var printer = printers[i];
                statusButtons[i].Tag = printer.Name;
            }
            StatusButtonManager.SeteReconnectButtons(statusButtons);

        }

        public void LoadLogData()
        {
            rtbLog.Clear();   
            var allLogs = Logger.GetLogs();
            foreach (var logEntry in allLogs)
            {
                UpdateLog(logEntry);
            }
        }


        private void UpdateLog(LogEntry logEntry)
        {
            
            rtbLog.SelectionColor = logEntry.Color;
            rtbLog.AppendText(logEntry.Message + Environment.NewLine);
            rtbLog.ScrollToCaret();
        }

        private void Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_FormClosing();
        }
        private async void btnReconnect_Click(object sender, EventArgs e)
        {
            rtbLog.Clear();
            Logger.Log("Attempting to reconnect all printers...", Color.Gray);
            await PrinterService.ReconnectAllPrintersAsync();
            var allLogs = Logger.GetLogs();
            foreach (var logEntry in allLogs)
            {
                UpdateLog(logEntry);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbLog.Clear();
            Logger.ClearLogs();
        }


    }
    public interface IRefreshable
    {
        void LoadLogData();
    }

}


