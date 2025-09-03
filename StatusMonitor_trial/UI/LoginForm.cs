using StatusMonitor_trial.Helpers;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = UserService.Login(txtUser.Text, txtPass.Text);
            if (user != null)
            {
                SessionManager.Instance.SetUser(user);
                FormManager.OpenForm(this, new Form1());
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        private void LoginForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            this.Close();
        }

    }
}
