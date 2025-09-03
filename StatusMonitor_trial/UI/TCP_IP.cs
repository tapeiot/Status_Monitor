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
using static StatusMonitor_trial.Services.PrinterService;

namespace StatusMonitor_trial
{

    public partial class TCP_IP : BaseForm
    {
        private Dictionary<string, PrinterConnection> printerConnections = new Dictionary<string, PrinterConnection>();
        private BindingSource printerBindingSource = new BindingSource();
        public TCP_IP()
        {
            InitializeComponent();
            dgvMachines.DataSource = printerBindingSource;

            PrinterService.PrintersListChanged += PrinterService_PrintersListChanged;
            PrinterService.PrinterStatusChanged += PrinterService_PrinterStatusChanged;

        }
        private void TCP_IP_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
            LoadPaths(cmbVNC, cmbWeb);
        }
        private void TCP_IP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_FormClosing();
        }
        private void HighlightPrinterRow()
        {
            foreach (DataGridViewRow row in dgvMachines.Rows)
            {
                if (row.DataBoundItem is PrinterInfo printer)
                {
                    var connection = PrinterService.GetConnection(printer.Name);

                    if (connection != null && connection.IsConnected)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }
        private void PrinterService_PrintersListChanged(object sender, EventArgs e)
        {

            UpdateDataGridView();
        }
        private void PrinterService_PrinterStatusChanged(object sender, PrinterInfo printer)
        {
            HighlightPrinterRow();
        }
        private void UpdateDataGridView()
        {
            printerBindingSource.DataSource = PrinterService.GetPrinters();
            HighlightPrinterRow();
        }
        private void cleartxt()
        {
            txtName.Clear();
            txtIP.Clear();
            txtPort.Clear();
        }
        private void dgvMachines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMachines.CurrentRow != null && dgvMachines.CurrentRow.DataBoundItem is PrinterInfo printer)
            {
                txtName.Text = printer.Name;
                txtIP.Text = printer.IP;
                txtPort.Text = printer.Port.ToString();
            }
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Length > 0 && txtIP.Text.Length > 0 && txtPort.Text.Length > 0)
                {
                    var printer = new PrinterInfo
                    {
                        Name = txtName.Text,
                        IP = txtIP.Text,
                        Port = int.Parse(txtPort.Text),
                        LastEdited = DateTime.Now
                    };

                    PrinterService.AddPrinter(printer);
                    _ = PrinterService.ConnectPrinterAsync(printer);
                    cleartxt();

                }
                else MessageBox.Show("Please enter completely.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error {ex}");
            }

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMachines.CurrentRow != null && dgvMachines.CurrentRow.DataBoundItem is PrinterInfo printer)
            {
                var updatedPrinter = dgvMachines.CurrentRow.DataBoundItem as PrinterInfo;
                printer.Name = txtName.Text;
                printer.IP = txtIP.Text;
                printer.Port = int.TryParse(txtPort.Text, out int port) ? port : 0;
                printer.LastEdited = DateTime.Now;

                PrinterService.UpdatePrinter(updatedPrinter);
                _ = PrinterService.ConnectPrinterAsync(printer);
                cleartxt();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvMachines.CurrentRow != null && dgvMachines.CurrentRow.DataBoundItem is PrinterInfo printer)
            {
                PrinterService.DeletePrinter(printer.Name);
                UpdateDataGridView();
                cleartxt();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnVNCRemote_Click(object sender, EventArgs e)
        {
            OpenVncPath(cmbVNC);
        }

        private void btnWebRemote_Click(object sender, EventArgs e)
        {
            OpenWebPath(cmbWeb);
        }


    }
}

