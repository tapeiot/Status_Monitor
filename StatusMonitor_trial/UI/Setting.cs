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

namespace StatusMonitor_trial
{
    public partial class Setting : BaseForm
    {
        private BindingSource pathBindingSource = new BindingSource();
        public Setting()
        {
            InitializeComponent();
            dgvPath.DataSource = pathBindingSource;
            PathService.PathListChanged += PathService_PathListChanged;

        }
        private void Setting_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
            LoadPaths(cmbVNC, cmbWeb);
        }

        private void PathService_PathListChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            pathBindingSource.DataSource = PathService.GetPaths();
        }
        private void cleartxt()
        {
            txtName.Clear();
            txtPath.Clear();
            cmbRole.Text = "";
        }
        private void dgvPath_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPath.CurrentRow != null && dgvPath.CurrentRow.DataBoundItem is PathInfo path)
            {
                txtName.Text = path.Name;
                txtPath.Text = path.Path;
                cmbRole.SelectedItem = path.Type;
                cmbRole.Text = path.Type;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Length > 0 && txtPath.Text.Length > 0 && cmbRole.SelectedItem != null)
                {
                    var path = new PathInfo
                    {
                        Name = txtName.Text,
                        Path = txtPath.Text,
                        Type = cmbRole.SelectedItem.ToString()
                    };

                    PathService.AddPath(path);
                    LoadPaths(cmbVNC, cmbWeb);
                    cleartxt();

                }
                else MessageBox.Show("Please enter completely.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error {ex}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPath.CurrentRow != null && dgvPath.CurrentRow.DataBoundItem is PathInfo path)
            {
                var updatedPath = dgvPath.CurrentRow.DataBoundItem as PathInfo;
                path.Name = txtName.Text;
                path.Path = txtPath.Text;
                path.Type = cmbRole.SelectedItem.ToString();

                PathService.UpdatePath(updatedPath);

                LoadPaths(cmbVNC, cmbWeb);
                cleartxt();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvPath.CurrentRow != null && dgvPath.CurrentRow.DataBoundItem is PathInfo path)
            {
                PathService.DeletePath(path.Name);
                LoadPaths(cmbVNC, cmbWeb);
                cleartxt();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_FormClosing();
        }
    }
}
