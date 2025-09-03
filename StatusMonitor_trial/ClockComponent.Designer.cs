namespace StatusMonitor_trial
{
    partial class ClockComponent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblClock = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblClock
            // 
            lblClock.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblClock.Location = new Point(5, 0);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(190, 113);
            lblClock.TabIndex = 1;
            lblClock.Text = "00:00:00\r\nWednesday\r\n31/12/2099";
            lblClock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ClockComponent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblClock);
            Name = "ClockComponent";
            Size = new Size(202, 119);
            ResumeLayout(false);
        }

        #endregion

        private Label lblClock;
        private System.Windows.Forms.Timer timer1;
    }
}
