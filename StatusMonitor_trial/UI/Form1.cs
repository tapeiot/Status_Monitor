using Microsoft.VisualBasic.ApplicationServices;
using StatusMonitor_trial.Helpers;
using StatusMonitor_trial.Models;
using StatusMonitor_trial.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static StatusMonitor_trial.Services.PrinterService;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;

namespace StatusMonitor_trial
{
    public partial class Form1 : BaseForm
    {
        private Dictionary<int, bool> selectedPrinters = new Dictionary<int, bool>();
        private Dictionary<Button, int> btnToPrinterIndex = new Dictionary<Button, int>();
        private List<Button> statusButtonsRC;
        private List<Button> statusButtonsST;
        public Form1()
        {

            InitializeComponent();
            var currentUser = SessionManager.Instance.CurrentUser;
            if (currentUser.Role == "Operator")
            {
                menuStrip1.Visible = false; 
            }
            else
            {
                menuStrip1.Visible = true;
            }

            this.Text = "Status Monitor Trial ASCII";
            PrinterService.PrintersListChanged += PrinterService_PrintersChanged;
            statusButtonsRC = new List<Button>
            {
                btnRC1, btnRC2, btnRC3, btnRC4, btnRC5, btnRC6, btnRC7, btnRC8, btnRC9, btnRC10
            };
            statusButtonsST = new List<Button>
            {
                btnST1, btnST2, btnST3, btnST4, btnST5, btnST6, btnST7, btnST8, btnST9, btnST10
            };

            PopulatePrintersComboBox();

            StatusButtonManager.SeteReconnectButtons(statusButtonsRC);
            StatusButtonManager.SetStatusButtons(statusButtonsST);

            btnSJ1.Click += btnSelect_Click;
            btnSJ2.Click += btnSelect_Click;
            btnSJ3.Click += btnSelect_Click;
            btnSJ4.Click += btnSelect_Click;
            btnSJ5.Click += btnSelect_Click;
            btnSJ6.Click += btnSelect_Click;
            btnSJ7.Click += btnSelect_Click;
            btnSJ8.Click += btnSelect_Click;
            btnSJ9.Click += btnSelect_Click;
            btnSJ10.Click += btnSelect_Click;

            btnToPrinterIndex[btnSJ1] = 0;
            btnToPrinterIndex[btnSJ2] = 1;
            btnToPrinterIndex[btnSJ3] = 2;
            btnToPrinterIndex[btnSJ4] = 3;
            btnToPrinterIndex[btnSJ5] = 4;
            btnToPrinterIndex[btnSJ6] = 5;
            btnToPrinterIndex[btnSJ7] = 6;
            btnToPrinterIndex[btnSJ8] = 7;
            btnToPrinterIndex[btnSJ9] = 8;
            btnToPrinterIndex[btnSJ10] = 9;
        }
        private PrinterInfo? SelectedPrinter
        {
            get
            {
                if (cmbGetMachine.SelectedIndex == -1) return null;
                string selectedText = cmbGetMachine.SelectedItem.ToString();
                string selectedName = selectedText.Split(':')[0].Trim();

                return PrinterService.GetPrinters()
                    .FirstOrDefault(p => p.Name == selectedName);
            }
        }
        private void PrinterService_PrintersChanged(object sender, EventArgs e)
        {

            PopulatePrintersComboBox();
        }
        private (int count, List<string> items) ParseResponse(string response)
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
        private void PopulatePrintersComboBox()
        {
            cmbGetMachine.Items.Clear();
            var printers = PrinterService.GetPrinters();
            foreach (var printer in printers)
            {
                cmbGetMachine.Items.Add($"{printer.Name} : {printer.IP}:{printer.Port}");
            }

            for (int i = 0; i < printers.Count && i < statusButtonsRC.Count; i++)
            {
                var printer = printers[i];
                statusButtonsRC[i].Tag = printer.Name;
                statusButtonsST[i].Tag = printer.Name;
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_FormClosing();
        }
        private void btnVNCRemote_Click(object sender, EventArgs e)
        {
            if (cmbVNC.SelectedItem is PathInfo path)
            {
                PathService.OpenPath(path.Name);
            }
            else
            {
                MessageBox.Show("Please select a vnc path.");
            }
        }

        private void btnWebRemote_Click(object sender, EventArgs e)
        {
            if (cmbWeb.SelectedItem is PathInfo path)
            {
                PathService.OpenPath(path.Name);
            }
            else
            {
                MessageBox.Show("Please select a web path.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPaths(cmbVNC, cmbWeb);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var printers = PrinterService.GetPrinters();
            if (sender is Button btn && btnToPrinterIndex.TryGetValue(btn, out int index))
            {

                if (index >= printers.Count) return;
                bool isSelected = selectedPrinters.ContainsKey(index) && selectedPrinters[index];
                selectedPrinters[index] = !isSelected;
                if (selectedPrinters[index])
                {
                    btn.BackColor = Color.Green;
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.LightGray;
                    btn.ForeColor = Color.Black;
                }

            }
        }
        private async void btnGetJob_Click(object sender, EventArgs e)
        {
            var printer = SelectedPrinter;
            if (printer == null)
            {
                MessageBox.Show("Please select a printer.");
                return;
            }

            var conn = PrinterService.GetConnection(printer.Name);

            if (conn == null || !conn.IsConnected)
            {
                MessageBox.Show($"Printer {printer.Name} is not connected. Please reconnect.");
                lblStatus0.BackColor = Color.IndianRed;
                return;
            }

            try
            {
                lblStatus0.BackColor = Color.LightGreen;
                await conn.SendAsync("GJL");
                string response = await conn.ReadAsync();
                Logger.Log($"Send : GJL<CR> to {printer.Name}", Color.Blue);
                Logger.Log($"Response from {printer.Name} : {response}", Color.Green);

                var (count, jobs) = ParseResponse(response);
                lblCountJN.Text = count.ToString();

                cmbGetJob.Items.Clear();
                foreach (var job in jobs)
                    cmbGetJob.Items.Add(job);

                cmbGetJob.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnGetField_Click(object sender, EventArgs e)
        {
            var printer = SelectedPrinter;
            if (printer == null || cmbGetJob.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both printer and job.");
                return;
            }
            var conn = PrinterService.GetConnection(printer.Name);
            if (conn == null || !conn.IsConnected)
            {
                MessageBox.Show($"Printer {printer.Name} is not connected.");
                return;
            }

            string selectedJob = cmbGetJob.SelectedItem.ToString();
            try
            {
                await conn.SendAsync($"GJF|{selectedJob}|");
                string response = await conn.ReadAsync();
                Logger.Log($"Send : GJF<CR> to {printer.Name}", Color.Blue);
                Logger.Log($"Response from {printer.Name}: {response}", Color.Green);

                var (count, fields) = ParseResponse(response);
                lblCountFN.Text = count.ToString();

                cmbGetField.Items.Clear();
                foreach (var field in fields)
                {
                    cmbGetField.Items.Add(field);
                    cmbField1.Items.Add(field);
                    cmbField2.Items.Add(field);
                    cmbField3.Items.Add(field);
                    cmbField5.Items.Add(field);
                    cmbField6.Items.Add(field);
                }
                cmbGetField.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during communication: " + ex.Message);
            }
        }

        private async void btnSendJob_Click(object sender, EventArgs e)
        {
            var printers = PrinterService.GetPrinters();
            string jobName = cmbGetJob.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(jobName))
            {
                MessageBox.Show("Please select job first!");
                return;
            }

            foreach (var kvp in selectedPrinters.Where(kvp => kvp.Value))
            {
                int index = kvp.Key;
                if (index >= printers.Count) continue;

                var printer = printers[index] as PrinterInfo;
                if (printer == null) continue;

                var conn = PrinterService.GetConnection(printer.Name);
                if (conn == null || !conn.IsConnected)
                {
                    MessageBox.Show($"Printer {printer.Name} is not connected.");
                    return;
                }

                try
                {

                    List<string> parts = new List<string> { "SLA", jobName };

                    if (cmbField1.SelectedItem != null)
                        parts.Add(cmbField1.SelectedItem.ToString() + "=" + txtField1.Text);

                    if (cmbField2.SelectedItem != null)
                        parts.Add(cmbField2.SelectedItem.ToString() + "=" + txtField2.Text);

                    if (cmbField3.SelectedItem != null)
                        parts.Add(cmbField3.SelectedItem.ToString() + "=" + cmbField4.SelectedItem.ToString());

                    if (cmbField5.SelectedItem != null)
                        parts.Add(cmbField5.SelectedItem.ToString() + "=" + txtField3.Text);

                    if (cmbField6.SelectedItem != null)
                        parts.Add(cmbField6.SelectedItem.ToString() + "=" + txtField4.Text);

   
                    string command = string.Join("|", parts) + "|"; 

                    await conn.SendAsync(command);
                    string response = await conn.ReadAsync();
                    Logger.Log($"Send : {command}<CR> to {printer.Name}", Color.Blue);
                    Logger.Log($"Response from {printer.Name}: {response}", Color.Green);
                    label1.Text = "completely";
                    label1.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending to {printer.Name}: {ex.Message}", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    label1.Text = "failed";
                    label1.ForeColor = Color.Red;
                }

            }
        }
        private async void btnGST_Click(object sender, EventArgs e)
        {

            var printers = PrinterService.GetPrinters();
            foreach (var printer in printers)
            {

                var conn = PrinterService.GetConnection(printer.Name);

                if (conn != null && conn.IsConnected)
                {
                    try
                    {
                        await conn.SendAsync("GST");
                        Logger.Log($"Send : GST<CR> to {printer.Name}", Color.Blue);
                        string response = await conn.ReadAsync();
                        Logger.Log($"Response from {printer.Name}: {response}", Color.Green);
                        var (state, fields) = ParseResponse(response);

                        switch (state)
                        {
                            case 0:
                                StatusButtonManager.UpdateStatus(printer.Name, Color.IndianRed);
                                break;
                            case 1:
                                StatusButtonManager.UpdateStatus(printer.Name, Color.LightBlue);
                                break;
                            case 2:
                                StatusButtonManager.UpdateStatus(printer.Name, Color.Yellow);
                                break;
                            case 3:
                                StatusButtonManager.UpdateStatus(printer.Name, Color.LightGreen);
                                break;
                            default:
                                StatusButtonManager.UpdateStatus(printer.Name, Color.LightGray);
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Log($"Failed to send GST to {printer.Name}: {ex.Message}", Color.Red);
                        StatusButtonManager.UpdateStatus(printer.Name, Color.LightGray);
                    }
                }
            }
        }

        private async void btnReconnect_Click(object sender, EventArgs e)
        {
            Logger.Log("Attempting to reconnect all printers...", Color.Gray);
            await PrinterService.ReconnectAllPrintersAsync();
        }

        private async void btnCJM_Click(object sender, EventArgs e)
        {
            var printers = PrinterService.GetPrinters();
            var fieldNamesFromUI = new List<string> { };

            if (cmbField1.SelectedItem != null) fieldNamesFromUI.Add(cmbField1.SelectedItem.ToString());
            if (cmbField2.SelectedItem != null) fieldNamesFromUI.Add(cmbField2.SelectedItem.ToString());
            if (cmbField3.SelectedItem != null) fieldNamesFromUI.Add(cmbField3.SelectedItem.ToString());
            if (cmbField5.SelectedItem != null) fieldNamesFromUI.Add(cmbField5.SelectedItem.ToString());
            if (cmbField6.SelectedItem != null) fieldNamesFromUI.Add(cmbField6.SelectedItem.ToString());
            foreach (var kvp in selectedPrinters.Where(kvp => kvp.Value))
            {

                int index = kvp.Key;
                if (index >= printers.Count) continue;

                var printer = printers[index] as PrinterInfo;
                if (printer == null) continue;

                var conn = PrinterService.GetConnection(printer.Name);
                if (conn == null || !conn.IsConnected)
                {
                    MessageBox.Show($"Printer {printer.Name} is not connected.");
                    return;
                }
                try
                {
                    string jobName = cmbGetJob.SelectedItem.ToString();
                    if (string.IsNullOrEmpty(jobName))
                    {
                        MessageBox.Show("Please select job first!");
                        return;
                    }
                    if (!selectedPrinters.Any())
                    {
                        MessageBox.Show("Please select at least one printer to check.");
                        return;
                    }
                    await conn.SendAsync("GJL");
                    string response = await conn.ReadAsync();
                    var (countJob, jobs) = ParseResponse(response);
                    bool jobExistsOnPrinter = jobs.Contains(jobName);

                    if (!jobExistsOnPrinter)
                    {
                        MessageBox.Show($"Job '{jobName}' does not exist on printer {printer.Name}.");
                        continue;
                    }

                    await conn.SendAsync($"GJF|{jobName}|");
                    response = await conn.ReadAsync();
                    var (countField, fieldNamesFromPrinter) = ParseResponse(response);
                    bool allFieldsMatch = fieldNamesFromUI.All(field => fieldNamesFromPrinter.Contains(field));

                    if (allFieldsMatch)
                    {
                        MessageBox.Show($"Job '{jobName}' and all fields match on printer {printer.Name}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show($"Job '{jobName}' exists, but some fields do not match on printer {printer.Name}.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error checking printer {printer.Name}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


    }
}

