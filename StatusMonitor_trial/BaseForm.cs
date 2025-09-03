using global::StatusMonitor_trial.Helpers;
using global::StatusMonitor_trial.Models;
using global::StatusMonitor_trial.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StatusMonitor_trial
{

    public class BaseForm : Form
    {
        private Dictionary<string, PrinterConnection> printerConnections = new Dictionary<string, PrinterConnection>();
        protected void mnsOperator_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(this, new Form1());
        }

        protected void mnsTCP_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(this, new TCP_IP());
        }

        protected void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(this, new Register());
        }

        protected void mnsSetting_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(this, new Setting());
        }

        protected void mnsLog_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm(this, new Log());
        }
        protected void Form_FormClosing()
        {
            foreach (var conn in printerConnections.Values)conn?.Dispose();
            Environment.Exit(Environment.ExitCode);
        }

        protected void LoadPaths(ComboBox cmbVNC, ComboBox cmbWeb)
        {
            var paths = PathService.GetPaths();

            var vncPaths = paths.Where(p => p.Type == "VNC").ToList();
            cmbVNC.DataSource = vncPaths;
            cmbVNC.DisplayMember = "Name";
            cmbVNC.ValueMember = "Path";

            var webPaths = paths.Where(p => p.Type == "Web").ToList();
            cmbWeb.DataSource = webPaths;
            cmbWeb.DisplayMember = "Name";
            cmbWeb.ValueMember = "Path";
        }

        protected void OpenVncPath(ComboBox cmbVNC)
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

        protected void OpenWebPath(ComboBox cmbWeb)
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
    }
}
