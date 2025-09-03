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
    public partial class ClockComponent : UserControl
    {
        public ClockComponent()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                lblClock.Text = DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine +
                                DateTime.Now.ToString("dddd") + Environment.NewLine +
                                DateTime.Now.ToString("dd/MM/yyyy");
            }
        }
        private void ClockControl_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void ClockControl_Resize(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
