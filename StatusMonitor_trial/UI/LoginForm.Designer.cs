namespace StatusMonitor_trial
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            clockComponent1 = new ClockComponent();
            pictureBox1 = new PictureBox();
            txtPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            btnCancel = new Button();
            btnLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(clockComponent1);
            panel1.Location = new Point(1, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 113);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(454, 31);
            label1.Name = "label1";
            label1.Size = new Size(407, 45);
            label1.TabIndex = 6;
            label1.Text = "Status Monitoring - Login";
            // 
            // clockComponent1
            // 
            clockComponent1.Anchor = AnchorStyles.None;
            clockComponent1.Location = new Point(10, 8);
            clockComponent1.Margin = new Padding(3, 2, 3, 2);
            clockComponent1.Name = "clockComponent1";
            clockComponent1.Size = new Size(172, 88);
            clockComponent1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.people;
            pictureBox1.Location = new Point(234, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 429);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.None;
            txtPass.Font = new Font("Segoe UI", 18F);
            txtPass.Location = new Point(277, 654);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(441, 39);
            txtPass.TabIndex = 25;
            txtPass.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.FromArgb(192, 64, 0);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(93, 654);
            label2.Name = "label2";
            label2.Size = new Size(166, 39);
            label2.TabIndex = 24;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.FromArgb(0, 0, 192);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(93, 592);
            label3.Name = "label3";
            label3.Size = new Size(166, 39);
            label3.TabIndex = 22;
            label3.Text = "Username";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.None;
            txtUser.Font = new Font("Segoe UI", 18F);
            txtUser.Location = new Point(277, 592);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(441, 39);
            txtUser.TabIndex = 23;
            txtUser.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(528, 747);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(190, 60);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.Green;
            btnLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(332, 747);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(190, 60);
            btnLogin.TabIndex = 26;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 861);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ClockComponent clockComponent1;
        private PictureBox pictureBox1;
        private TextBox txtPass;
        private Label label2;
        private Label label3;
        private TextBox txtUser;
        private Button btnCancel;
        private Button btnLogin;
    }
}