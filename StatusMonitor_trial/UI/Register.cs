using Microsoft.VisualBasic.ApplicationServices;
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
using System.Xml.Linq;

namespace StatusMonitor_trial
{

    public partial class Register : BaseForm
    {
        private BindingSource userBindingSource = new BindingSource();
        public Register()
        {
            InitializeComponent();
            dgvUserList.DataSource = userBindingSource;
        }

        private void cleartxt()
        {
            txtUser.Clear();
            txtPass.Clear();
            cmbRole.Text = "";
        }
        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserList.CurrentRow != null && dgvUserList.CurrentRow.DataBoundItem is UserInfo user)
            {
                txtUser.Text = user.Name;
                txtPass.Text = user.Password;
                cmbRole.SelectedItem = user.Role;
                cmbRole.Text = user.Role;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var user = new UserInfo
            {
                Name = txtUser.Text,
                Password = txtPass.Text,
                Role = cmbRole.SelectedItem.ToString()
            };
            if (txtUser.Text.Length > 0 && txtPass.Text.Length > 0 && cmbRole.SelectedItem != null)
            {
                UserService.AddUser(user);
                userBindingSource.DataSource = UserService.GetUsers();
                cleartxt();
            }
            else MessageBox.Show("Please enter completely.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUserList.CurrentRow != null && dgvUserList.CurrentRow.DataBoundItem is UserInfo user)
            {
                var updatedUser = dgvUserList.CurrentRow.DataBoundItem as PathInfo;
                user.Name = txtUser.Text;
                user.Password = txtPass.Text;
                user.Role = cmbRole.SelectedItem.ToString();

                PathService.UpdatePath(updatedUser);

                userBindingSource.DataSource = UserService.GetUsers();
                cleartxt();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvUserList.CurrentRow != null && dgvUserList.CurrentRow.DataBoundItem is User user)
            {
                PathService.DeletePath(user.Name);
                userBindingSource.DataSource = UserService.GetUsers();
                cleartxt();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = UserService.GetUsers();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_FormClosing();
        }
    }
}
