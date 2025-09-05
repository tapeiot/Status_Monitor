namespace StatusMonitor_trial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            clockComponent1 = new ClockComponent();
            btnWebRemote = new Button();
            btnVNCRemote = new Button();
            cmbWeb = new ComboBox();
            cmbVNC = new ComboBox();
            menuStrip1 = new MenuStrip();
            mnsOperator = new ToolStripMenuItem();
            mnsTCP = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            mnsSetting = new ToolStripMenuItem();
            mnsLog = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            cmbGetMachine = new ComboBox();
            lblStatus0 = new Label();
            lblCountJN = new Label();
            cmbGetJob = new ComboBox();
            btnGetJob = new Button();
            btnGetField = new Button();
            lblCountFN = new Label();
            cmbGetField = new ComboBox();
            lbl1 = new Label();
            lbl2 = new Label();
            cmbField1 = new ComboBox();
            txtField1 = new TextBox();
            txtField2 = new TextBox();
            cmbField2 = new ComboBox();
            cmbField3 = new ComboBox();
            txtField3 = new TextBox();
            cmbField5 = new ComboBox();
            txtField4 = new TextBox();
            cmbField6 = new ComboBox();
            btnSJ1 = new Button();
            btnSJ2 = new Button();
            btnSJ3 = new Button();
            btnSJ4 = new Button();
            btnSJ5 = new Button();
            btnSJ10 = new Button();
            btnSJ9 = new Button();
            btnSJ8 = new Button();
            btnSJ7 = new Button();
            btnSJ6 = new Button();
            btnSendJob = new Button();
            btnReconnect = new Button();
            btnGST = new Button();
            btnRC1 = new Button();
            btnRC2 = new Button();
            btnRC4 = new Button();
            btnRC3 = new Button();
            btnRC6 = new Button();
            btnRC5 = new Button();
            btnRC8 = new Button();
            btnRC7 = new Button();
            btnRC10 = new Button();
            btnRC9 = new Button();
            btnST10 = new Button();
            btnST9 = new Button();
            btnST8 = new Button();
            btnST7 = new Button();
            btnST6 = new Button();
            btnST5 = new Button();
            btnST4 = new Button();
            btnST3 = new Button();
            btnST2 = new Button();
            btnST1 = new Button();
            btnCJM = new Button();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtField5 = new TextBox();
            pbCLRF1 = new PictureBox();
            pbCLRF2 = new PictureBox();
            pbCLRF3 = new PictureBox();
            pbCLRF4 = new PictureBox();
            pbCLRF5 = new PictureBox();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCLRF1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCLRF2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCLRF3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCLRF4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCLRF5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(clockComponent1);
            panel1.Controls.Add(btnWebRemote);
            panel1.Controls.Add(btnVNCRemote);
            panel1.Controls.Add(cmbWeb);
            panel1.Controls.Add(cmbVNC);
            panel1.Location = new Point(0, 31);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 98);
            panel1.TabIndex = 0;
            // 
            // clockComponent1
            // 
            clockComponent1.Location = new Point(12, 6);
            clockComponent1.Margin = new Padding(3, 2, 3, 2);
            clockComponent1.Name = "clockComponent1";
            clockComponent1.Size = new Size(172, 88);
            clockComponent1.TabIndex = 5;
            // 
            // btnWebRemote
            // 
            btnWebRemote.AutoSize = true;
            btnWebRemote.Font = new Font("Segoe UI", 14F);
            btnWebRemote.Location = new Point(717, 56);
            btnWebRemote.Margin = new Padding(3, 2, 3, 2);
            btnWebRemote.Name = "btnWebRemote";
            btnWebRemote.Size = new Size(145, 35);
            btnWebRemote.TabIndex = 4;
            btnWebRemote.Text = "Web Remote";
            btnWebRemote.UseVisualStyleBackColor = true;
            btnWebRemote.Click += btnWebRemote_Click;
            // 
            // btnVNCRemote
            // 
            btnVNCRemote.AutoSize = true;
            btnVNCRemote.Font = new Font("Segoe UI", 14F);
            btnVNCRemote.Location = new Point(717, 10);
            btnVNCRemote.Margin = new Padding(3, 2, 3, 2);
            btnVNCRemote.Name = "btnVNCRemote";
            btnVNCRemote.Size = new Size(145, 35);
            btnVNCRemote.TabIndex = 3;
            btnVNCRemote.Text = "VNC Remote";
            btnVNCRemote.UseVisualStyleBackColor = true;
            btnVNCRemote.Click += btnVNCRemote_Click;
            // 
            // cmbWeb
            // 
            cmbWeb.Font = new Font("Segoe UI", 14F);
            cmbWeb.FormattingEnabled = true;
            cmbWeb.Location = new Point(205, 57);
            cmbWeb.Margin = new Padding(3, 2, 3, 2);
            cmbWeb.Name = "cmbWeb";
            cmbWeb.Size = new Size(426, 33);
            cmbWeb.TabIndex = 2;
            cmbWeb.Text = "Path WebBrowser";
            // 
            // cmbVNC
            // 
            cmbVNC.Font = new Font("Segoe UI", 14F);
            cmbVNC.FormattingEnabled = true;
            cmbVNC.Location = new Point(205, 10);
            cmbVNC.Margin = new Padding(3, 2, 3, 2);
            cmbVNC.Name = "cmbVNC";
            cmbVNC.Size = new Size(426, 33);
            cmbVNC.TabIndex = 1;
            cmbVNC.Text = "Path VNC";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnsOperator, mnsTCP, registerToolStripMenuItem, mnsSetting, mnsLog });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(884, 29);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnsOperator
            // 
            mnsOperator.BackColor = Color.Green;
            mnsOperator.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mnsOperator.ForeColor = Color.White;
            mnsOperator.Name = "mnsOperator";
            mnsOperator.Size = new Size(90, 25);
            mnsOperator.Text = "Operator";
            // 
            // mnsTCP
            // 
            mnsTCP.Name = "mnsTCP";
            mnsTCP.Size = new Size(67, 25);
            mnsTCP.Text = "TCP/IP";
            mnsTCP.Click += mnsTCP_Click;
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(79, 25);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // mnsSetting
            // 
            mnsSetting.Name = "mnsSetting";
            mnsSetting.Size = new Size(71, 25);
            mnsSetting.Text = "Setting";
            mnsSetting.Click += mnsSetting_Click;
            // 
            // mnsLog
            // 
            mnsLog.Name = "mnsLog";
            mnsLog.Size = new Size(48, 25);
            mnsLog.Text = "Log";
            mnsLog.Click += mnsLog_Click;
            // 
            // cmbGetMachine
            // 
            cmbGetMachine.Dock = DockStyle.Fill;
            cmbGetMachine.Font = new Font("Segoe UI", 16F);
            cmbGetMachine.FormattingEnabled = true;
            cmbGetMachine.Location = new Point(3, 2);
            cmbGetMachine.Margin = new Padding(3, 2, 3, 2);
            cmbGetMachine.Name = "cmbGetMachine";
            cmbGetMachine.Size = new Size(702, 38);
            cmbGetMachine.TabIndex = 5;
            cmbGetMachine.Text = "VideoJet IP:Port";
            // 
            // lblStatus0
            // 
            lblStatus0.BackColor = Color.White;
            lblStatus0.BorderStyle = BorderStyle.FixedSingle;
            lblStatus0.Dock = DockStyle.Fill;
            lblStatus0.Font = new Font("Segoe UI", 16F);
            lblStatus0.ForeColor = SystemColors.ButtonHighlight;
            lblStatus0.Location = new Point(711, 0);
            lblStatus0.Name = "lblStatus0";
            lblStatus0.Size = new Size(95, 44);
            lblStatus0.TabIndex = 6;
            lblStatus0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCountJN
            // 
            lblCountJN.BackColor = Color.White;
            lblCountJN.BorderStyle = BorderStyle.FixedSingle;
            lblCountJN.Dock = DockStyle.Fill;
            lblCountJN.Font = new Font("Segoe UI", 16F);
            lblCountJN.ForeColor = Color.Black;
            lblCountJN.Location = new Point(711, 0);
            lblCountJN.Name = "lblCountJN";
            lblCountJN.Size = new Size(95, 44);
            lblCountJN.TabIndex = 8;
            lblCountJN.Text = "1";
            lblCountJN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbGetJob
            // 
            cmbGetJob.Dock = DockStyle.Fill;
            cmbGetJob.Font = new Font("Segoe UI", 16F);
            cmbGetJob.FormattingEnabled = true;
            cmbGetJob.Location = new Point(158, 2);
            cmbGetJob.Margin = new Padding(3, 2, 3, 2);
            cmbGetJob.Name = "cmbGetJob";
            cmbGetJob.Size = new Size(547, 38);
            cmbGetJob.TabIndex = 7;
            cmbGetJob.Text = "JobName";
            // 
            // btnGetJob
            // 
            btnGetJob.Dock = DockStyle.Fill;
            btnGetJob.Font = new Font("Segoe UI", 14F);
            btnGetJob.Location = new Point(3, 2);
            btnGetJob.Margin = new Padding(3, 2, 3, 2);
            btnGetJob.Name = "btnGetJob";
            btnGetJob.Size = new Size(149, 40);
            btnGetJob.TabIndex = 5;
            btnGetJob.Text = "Get Job";
            btnGetJob.UseVisualStyleBackColor = true;
            btnGetJob.Click += btnGetJob_Click;
            // 
            // btnGetField
            // 
            btnGetField.Dock = DockStyle.Fill;
            btnGetField.Font = new Font("Segoe UI", 14F);
            btnGetField.Location = new Point(3, 46);
            btnGetField.Margin = new Padding(3, 2, 3, 2);
            btnGetField.Name = "btnGetField";
            btnGetField.Size = new Size(149, 40);
            btnGetField.TabIndex = 9;
            btnGetField.Text = "Get Field";
            btnGetField.UseVisualStyleBackColor = true;
            btnGetField.Click += btnGetField_Click;
            // 
            // lblCountFN
            // 
            lblCountFN.BackColor = Color.White;
            lblCountFN.BorderStyle = BorderStyle.FixedSingle;
            lblCountFN.Dock = DockStyle.Fill;
            lblCountFN.Font = new Font("Segoe UI", 16F);
            lblCountFN.ForeColor = Color.Black;
            lblCountFN.Location = new Point(711, 44);
            lblCountFN.Name = "lblCountFN";
            lblCountFN.Size = new Size(95, 44);
            lblCountFN.TabIndex = 11;
            lblCountFN.Text = "1";
            lblCountFN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbGetField
            // 
            cmbGetField.Dock = DockStyle.Fill;
            cmbGetField.Font = new Font("Segoe UI", 16F);
            cmbGetField.FormattingEnabled = true;
            cmbGetField.Location = new Point(158, 46);
            cmbGetField.Margin = new Padding(3, 2, 3, 2);
            cmbGetField.Name = "cmbGetField";
            cmbGetField.Size = new Size(547, 38);
            cmbGetField.TabIndex = 10;
            cmbGetField.Text = "fn,dd,mon,year,etc,";
            // 
            // lbl1
            // 
            lbl1.BackColor = Color.FromArgb(0, 0, 192);
            lbl1.BorderStyle = BorderStyle.FixedSingle;
            lbl1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbl1.ForeColor = SystemColors.ButtonHighlight;
            lbl1.Location = new Point(37, 320);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(216, 40);
            lbl1.TabIndex = 12;
            lbl1.Text = "FieldName";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            lbl2.BackColor = Color.SandyBrown;
            lbl2.BorderStyle = BorderStyle.FixedSingle;
            lbl2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbl2.ForeColor = SystemColors.ActiveCaptionText;
            lbl2.Location = new Point(250, 320);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(575, 40);
            lbl2.TabIndex = 13;
            lbl2.Text = "Field Data(Auto Save)";
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbField1
            // 
            cmbField1.BackColor = Color.FromArgb(0, 0, 192);
            cmbField1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbField1.ForeColor = Color.White;
            cmbField1.FormattingEnabled = true;
            cmbField1.Location = new Point(35, 361);
            cmbField1.Margin = new Padding(3, 2, 3, 2);
            cmbField1.Name = "cmbField1";
            cmbField1.Size = new Size(206, 38);
            cmbField1.TabIndex = 5;
            // 
            // txtField1
            // 
            txtField1.BorderStyle = BorderStyle.FixedSingle;
            txtField1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtField1.Location = new Point(250, 363);
            txtField1.Margin = new Padding(3, 2, 3, 2);
            txtField1.Name = "txtField1";
            txtField1.Size = new Size(523, 36);
            txtField1.TabIndex = 14;
            txtField1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtField2
            // 
            txtField2.BorderStyle = BorderStyle.FixedSingle;
            txtField2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtField2.Location = new Point(250, 403);
            txtField2.Margin = new Padding(3, 2, 3, 2);
            txtField2.Name = "txtField2";
            txtField2.Size = new Size(523, 36);
            txtField2.TabIndex = 16;
            txtField2.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbField2
            // 
            cmbField2.BackColor = Color.FromArgb(0, 0, 192);
            cmbField2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbField2.ForeColor = Color.White;
            cmbField2.FormattingEnabled = true;
            cmbField2.Location = new Point(35, 400);
            cmbField2.Margin = new Padding(3, 2, 3, 2);
            cmbField2.Name = "cmbField2";
            cmbField2.Size = new Size(206, 38);
            cmbField2.TabIndex = 15;
            // 
            // cmbField3
            // 
            cmbField3.BackColor = Color.FromArgb(0, 0, 192);
            cmbField3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbField3.ForeColor = Color.White;
            cmbField3.FormattingEnabled = true;
            cmbField3.Location = new Point(35, 442);
            cmbField3.Margin = new Padding(3, 2, 3, 2);
            cmbField3.Name = "cmbField3";
            cmbField3.Size = new Size(206, 38);
            cmbField3.TabIndex = 17;
            // 
            // txtField3
            // 
            txtField3.BorderStyle = BorderStyle.FixedSingle;
            txtField3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtField3.Location = new Point(250, 484);
            txtField3.Margin = new Padding(3, 2, 3, 2);
            txtField3.Name = "txtField3";
            txtField3.Size = new Size(522, 36);
            txtField3.TabIndex = 20;
            txtField3.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbField5
            // 
            cmbField5.BackColor = Color.FromArgb(0, 0, 192);
            cmbField5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbField5.ForeColor = Color.White;
            cmbField5.FormattingEnabled = true;
            cmbField5.Location = new Point(35, 484);
            cmbField5.Margin = new Padding(3, 2, 3, 2);
            cmbField5.Name = "cmbField5";
            cmbField5.Size = new Size(206, 38);
            cmbField5.TabIndex = 19;
            // 
            // txtField4
            // 
            txtField4.BorderStyle = BorderStyle.FixedSingle;
            txtField4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtField4.Location = new Point(250, 525);
            txtField4.Margin = new Padding(3, 2, 3, 2);
            txtField4.Name = "txtField4";
            txtField4.Size = new Size(523, 36);
            txtField4.TabIndex = 22;
            // 
            // cmbField6
            // 
            cmbField6.BackColor = Color.FromArgb(0, 0, 192);
            cmbField6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbField6.ForeColor = Color.White;
            cmbField6.FormattingEnabled = true;
            cmbField6.Location = new Point(35, 525);
            cmbField6.Margin = new Padding(3, 2, 3, 2);
            cmbField6.Name = "cmbField6";
            cmbField6.Size = new Size(207, 38);
            cmbField6.TabIndex = 21;
            // 
            // btnSJ1
            // 
            btnSJ1.BackColor = Color.LightGray;
            btnSJ1.Font = new Font("Segoe UI", 14F);
            btnSJ1.Location = new Point(37, 578);
            btnSJ1.Margin = new Padding(3, 2, 3, 2);
            btnSJ1.Name = "btnSJ1";
            btnSJ1.Size = new Size(48, 38);
            btnSJ1.TabIndex = 23;
            btnSJ1.Text = "1";
            btnSJ1.UseVisualStyleBackColor = false;
            // 
            // btnSJ2
            // 
            btnSJ2.BackColor = Color.LightGray;
            btnSJ2.Font = new Font("Segoe UI", 14F);
            btnSJ2.Location = new Point(99, 578);
            btnSJ2.Margin = new Padding(3, 2, 3, 2);
            btnSJ2.Name = "btnSJ2";
            btnSJ2.Size = new Size(48, 38);
            btnSJ2.TabIndex = 24;
            btnSJ2.Text = "2";
            btnSJ2.UseVisualStyleBackColor = false;
            // 
            // btnSJ3
            // 
            btnSJ3.BackColor = Color.LightGray;
            btnSJ3.Font = new Font("Segoe UI", 14F);
            btnSJ3.Location = new Point(163, 578);
            btnSJ3.Margin = new Padding(3, 2, 3, 2);
            btnSJ3.Name = "btnSJ3";
            btnSJ3.Size = new Size(48, 38);
            btnSJ3.TabIndex = 25;
            btnSJ3.Text = "3";
            btnSJ3.UseVisualStyleBackColor = false;
            // 
            // btnSJ4
            // 
            btnSJ4.BackColor = Color.LightGray;
            btnSJ4.Font = new Font("Segoe UI", 14F);
            btnSJ4.Location = new Point(227, 578);
            btnSJ4.Margin = new Padding(3, 2, 3, 2);
            btnSJ4.Name = "btnSJ4";
            btnSJ4.Size = new Size(48, 38);
            btnSJ4.TabIndex = 26;
            btnSJ4.Text = "4";
            btnSJ4.UseVisualStyleBackColor = false;
            // 
            // btnSJ5
            // 
            btnSJ5.BackColor = Color.LightGray;
            btnSJ5.Font = new Font("Segoe UI", 14F);
            btnSJ5.Location = new Point(292, 578);
            btnSJ5.Margin = new Padding(3, 2, 3, 2);
            btnSJ5.Name = "btnSJ5";
            btnSJ5.Size = new Size(48, 38);
            btnSJ5.TabIndex = 27;
            btnSJ5.Text = "5";
            btnSJ5.UseVisualStyleBackColor = false;
            // 
            // btnSJ10
            // 
            btnSJ10.BackColor = Color.LightGray;
            btnSJ10.Font = new Font("Segoe UI", 14F);
            btnSJ10.Location = new Point(292, 620);
            btnSJ10.Margin = new Padding(3, 2, 3, 2);
            btnSJ10.Name = "btnSJ10";
            btnSJ10.Size = new Size(48, 38);
            btnSJ10.TabIndex = 32;
            btnSJ10.Text = "10";
            btnSJ10.UseVisualStyleBackColor = false;
            // 
            // btnSJ9
            // 
            btnSJ9.BackColor = Color.LightGray;
            btnSJ9.Font = new Font("Segoe UI", 14F);
            btnSJ9.Location = new Point(227, 620);
            btnSJ9.Margin = new Padding(3, 2, 3, 2);
            btnSJ9.Name = "btnSJ9";
            btnSJ9.Size = new Size(48, 38);
            btnSJ9.TabIndex = 31;
            btnSJ9.Text = "9";
            btnSJ9.UseVisualStyleBackColor = false;
            // 
            // btnSJ8
            // 
            btnSJ8.BackColor = Color.LightGray;
            btnSJ8.Font = new Font("Segoe UI", 14F);
            btnSJ8.Location = new Point(163, 620);
            btnSJ8.Margin = new Padding(3, 2, 3, 2);
            btnSJ8.Name = "btnSJ8";
            btnSJ8.Size = new Size(48, 38);
            btnSJ8.TabIndex = 30;
            btnSJ8.Text = "8";
            btnSJ8.UseVisualStyleBackColor = false;
            // 
            // btnSJ7
            // 
            btnSJ7.BackColor = Color.LightGray;
            btnSJ7.Font = new Font("Segoe UI", 14F);
            btnSJ7.Location = new Point(99, 620);
            btnSJ7.Margin = new Padding(3, 2, 3, 2);
            btnSJ7.Name = "btnSJ7";
            btnSJ7.Size = new Size(48, 38);
            btnSJ7.TabIndex = 29;
            btnSJ7.Text = "7";
            btnSJ7.UseVisualStyleBackColor = false;
            // 
            // btnSJ6
            // 
            btnSJ6.BackColor = Color.LightGray;
            btnSJ6.Font = new Font("Segoe UI", 14F);
            btnSJ6.Location = new Point(37, 620);
            btnSJ6.Margin = new Padding(3, 2, 3, 2);
            btnSJ6.Name = "btnSJ6";
            btnSJ6.Size = new Size(48, 38);
            btnSJ6.TabIndex = 28;
            btnSJ6.Text = "6";
            btnSJ6.UseVisualStyleBackColor = false;
            // 
            // btnSendJob
            // 
            btnSendJob.BackColor = Color.Green;
            btnSendJob.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendJob.ForeColor = Color.White;
            btnSendJob.Location = new Point(430, 578);
            btnSendJob.Margin = new Padding(3, 2, 3, 2);
            btnSendJob.Name = "btnSendJob";
            btnSendJob.Size = new Size(395, 100);
            btnSendJob.TabIndex = 33;
            btnSendJob.Text = "SEND JOB";
            btnSendJob.UseVisualStyleBackColor = false;
            btnSendJob.Click += btnSendJob_Click;
            // 
            // btnReconnect
            // 
            btnReconnect.Dock = DockStyle.Fill;
            btnReconnect.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReconnect.Location = new Point(3, 2);
            btnReconnect.Margin = new Padding(3, 2, 3, 2);
            btnReconnect.Name = "btnReconnect";
            btnReconnect.Size = new Size(173, 48);
            btnReconnect.TabIndex = 34;
            btnReconnect.Text = "Reconnect";
            btnReconnect.UseVisualStyleBackColor = true;
            btnReconnect.Click += btnReconnect_Click;
            // 
            // btnGST
            // 
            btnGST.Dock = DockStyle.Fill;
            btnGST.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGST.Location = new Point(3, 54);
            btnGST.Margin = new Padding(3, 2, 3, 2);
            btnGST.Name = "btnGST";
            btnGST.Size = new Size(173, 48);
            btnGST.TabIndex = 35;
            btnGST.Text = "Get Status";
            btnGST.UseVisualStyleBackColor = true;
            btnGST.Click += btnGST_Click;
            // 
            // btnRC1
            // 
            btnRC1.BackColor = Color.LightGray;
            btnRC1.Enabled = false;
            btnRC1.Font = new Font("Segoe UI", 14F);
            btnRC1.Location = new Point(292, 741);
            btnRC1.Margin = new Padding(3, 2, 3, 2);
            btnRC1.Name = "btnRC1";
            btnRC1.Size = new Size(48, 38);
            btnRC1.TabIndex = 36;
            btnRC1.Text = "1";
            btnRC1.UseVisualStyleBackColor = false;
            // 
            // btnRC2
            // 
            btnRC2.BackColor = Color.LightGray;
            btnRC2.Enabled = false;
            btnRC2.Font = new Font("Segoe UI", 14F);
            btnRC2.Location = new Point(346, 741);
            btnRC2.Margin = new Padding(3, 2, 3, 2);
            btnRC2.Name = "btnRC2";
            btnRC2.Size = new Size(48, 38);
            btnRC2.TabIndex = 37;
            btnRC2.Text = "2";
            btnRC2.UseVisualStyleBackColor = false;
            // 
            // btnRC4
            // 
            btnRC4.BackColor = Color.LightGray;
            btnRC4.Enabled = false;
            btnRC4.Font = new Font("Segoe UI", 14F);
            btnRC4.Location = new Point(454, 741);
            btnRC4.Margin = new Padding(3, 2, 3, 2);
            btnRC4.Name = "btnRC4";
            btnRC4.Size = new Size(48, 38);
            btnRC4.TabIndex = 39;
            btnRC4.Text = "4";
            btnRC4.UseVisualStyleBackColor = false;
            // 
            // btnRC3
            // 
            btnRC3.BackColor = Color.LightGray;
            btnRC3.Enabled = false;
            btnRC3.Font = new Font("Segoe UI", 14F);
            btnRC3.Location = new Point(400, 741);
            btnRC3.Margin = new Padding(3, 2, 3, 2);
            btnRC3.Name = "btnRC3";
            btnRC3.Size = new Size(48, 38);
            btnRC3.TabIndex = 38;
            btnRC3.Text = "3";
            btnRC3.UseVisualStyleBackColor = false;
            // 
            // btnRC6
            // 
            btnRC6.BackColor = Color.LightGray;
            btnRC6.Enabled = false;
            btnRC6.Font = new Font("Segoe UI", 14F);
            btnRC6.Location = new Point(563, 741);
            btnRC6.Margin = new Padding(3, 2, 3, 2);
            btnRC6.Name = "btnRC6";
            btnRC6.Size = new Size(48, 38);
            btnRC6.TabIndex = 41;
            btnRC6.Text = "6";
            btnRC6.UseVisualStyleBackColor = false;
            // 
            // btnRC5
            // 
            btnRC5.BackColor = Color.LightGray;
            btnRC5.Enabled = false;
            btnRC5.Font = new Font("Segoe UI", 14F);
            btnRC5.Location = new Point(506, 741);
            btnRC5.Margin = new Padding(3, 2, 3, 2);
            btnRC5.Name = "btnRC5";
            btnRC5.Size = new Size(48, 38);
            btnRC5.TabIndex = 40;
            btnRC5.Text = "5";
            btnRC5.UseVisualStyleBackColor = false;
            // 
            // btnRC8
            // 
            btnRC8.BackColor = Color.LightGray;
            btnRC8.Enabled = false;
            btnRC8.Font = new Font("Segoe UI", 14F);
            btnRC8.Location = new Point(673, 741);
            btnRC8.Margin = new Padding(3, 2, 3, 2);
            btnRC8.Name = "btnRC8";
            btnRC8.Size = new Size(48, 38);
            btnRC8.TabIndex = 43;
            btnRC8.Text = "8";
            btnRC8.UseVisualStyleBackColor = false;
            // 
            // btnRC7
            // 
            btnRC7.BackColor = Color.LightGray;
            btnRC7.Enabled = false;
            btnRC7.Font = new Font("Segoe UI", 14F);
            btnRC7.Location = new Point(617, 741);
            btnRC7.Margin = new Padding(3, 2, 3, 2);
            btnRC7.Name = "btnRC7";
            btnRC7.Size = new Size(48, 38);
            btnRC7.TabIndex = 42;
            btnRC7.Text = "7";
            btnRC7.UseVisualStyleBackColor = false;
            // 
            // btnRC10
            // 
            btnRC10.BackColor = Color.LightGray;
            btnRC10.Enabled = false;
            btnRC10.Font = new Font("Segoe UI", 14F);
            btnRC10.Location = new Point(777, 741);
            btnRC10.Margin = new Padding(3, 2, 3, 2);
            btnRC10.Name = "btnRC10";
            btnRC10.Size = new Size(48, 38);
            btnRC10.TabIndex = 45;
            btnRC10.Text = "10";
            btnRC10.UseVisualStyleBackColor = false;
            // 
            // btnRC9
            // 
            btnRC9.BackColor = Color.LightGray;
            btnRC9.Enabled = false;
            btnRC9.Font = new Font("Segoe UI", 14F);
            btnRC9.Location = new Point(725, 741);
            btnRC9.Margin = new Padding(3, 2, 3, 2);
            btnRC9.Name = "btnRC9";
            btnRC9.Size = new Size(48, 38);
            btnRC9.TabIndex = 44;
            btnRC9.Text = "9";
            btnRC9.UseVisualStyleBackColor = false;
            // 
            // btnST10
            // 
            btnST10.BackColor = Color.LightGray;
            btnST10.Enabled = false;
            btnST10.Font = new Font("Segoe UI", 14F);
            btnST10.Location = new Point(777, 793);
            btnST10.Margin = new Padding(3, 2, 3, 2);
            btnST10.Name = "btnST10";
            btnST10.Size = new Size(48, 38);
            btnST10.TabIndex = 55;
            btnST10.Text = "10";
            btnST10.UseVisualStyleBackColor = false;
            // 
            // btnST9
            // 
            btnST9.BackColor = Color.LightGray;
            btnST9.Enabled = false;
            btnST9.Font = new Font("Segoe UI", 14F);
            btnST9.Location = new Point(724, 793);
            btnST9.Margin = new Padding(3, 2, 3, 2);
            btnST9.Name = "btnST9";
            btnST9.Size = new Size(48, 38);
            btnST9.TabIndex = 54;
            btnST9.Text = "9";
            btnST9.UseVisualStyleBackColor = false;
            // 
            // btnST8
            // 
            btnST8.BackColor = Color.LightGray;
            btnST8.Enabled = false;
            btnST8.Font = new Font("Segoe UI", 14F);
            btnST8.Location = new Point(670, 793);
            btnST8.Margin = new Padding(3, 2, 3, 2);
            btnST8.Name = "btnST8";
            btnST8.Size = new Size(48, 38);
            btnST8.TabIndex = 53;
            btnST8.Text = "8";
            btnST8.UseVisualStyleBackColor = false;
            // 
            // btnST7
            // 
            btnST7.BackColor = Color.LightGray;
            btnST7.Enabled = false;
            btnST7.Font = new Font("Segoe UI", 14F);
            btnST7.Location = new Point(617, 793);
            btnST7.Margin = new Padding(3, 2, 3, 2);
            btnST7.Name = "btnST7";
            btnST7.Size = new Size(48, 38);
            btnST7.TabIndex = 52;
            btnST7.Text = "7";
            btnST7.UseVisualStyleBackColor = false;
            // 
            // btnST6
            // 
            btnST6.BackColor = Color.LightGray;
            btnST6.Enabled = false;
            btnST6.Font = new Font("Segoe UI", 14F);
            btnST6.Location = new Point(563, 793);
            btnST6.Margin = new Padding(3, 2, 3, 2);
            btnST6.Name = "btnST6";
            btnST6.Size = new Size(48, 38);
            btnST6.TabIndex = 51;
            btnST6.Text = "6";
            btnST6.UseVisualStyleBackColor = false;
            // 
            // btnST5
            // 
            btnST5.BackColor = Color.LightGray;
            btnST5.Enabled = false;
            btnST5.Font = new Font("Segoe UI", 14F);
            btnST5.Location = new Point(506, 793);
            btnST5.Margin = new Padding(3, 2, 3, 2);
            btnST5.Name = "btnST5";
            btnST5.Size = new Size(48, 38);
            btnST5.TabIndex = 50;
            btnST5.Text = "5";
            btnST5.UseVisualStyleBackColor = false;
            // 
            // btnST4
            // 
            btnST4.BackColor = Color.LightGray;
            btnST4.Enabled = false;
            btnST4.Font = new Font("Segoe UI", 14F);
            btnST4.Location = new Point(452, 793);
            btnST4.Margin = new Padding(3, 2, 3, 2);
            btnST4.Name = "btnST4";
            btnST4.Size = new Size(48, 38);
            btnST4.TabIndex = 49;
            btnST4.Text = "4";
            btnST4.UseVisualStyleBackColor = false;
            // 
            // btnST3
            // 
            btnST3.BackColor = Color.LightGray;
            btnST3.Enabled = false;
            btnST3.Font = new Font("Segoe UI", 14F);
            btnST3.Location = new Point(399, 793);
            btnST3.Margin = new Padding(3, 2, 3, 2);
            btnST3.Name = "btnST3";
            btnST3.Size = new Size(48, 38);
            btnST3.TabIndex = 48;
            btnST3.Text = "3";
            btnST3.UseVisualStyleBackColor = false;
            // 
            // btnST2
            // 
            btnST2.BackColor = Color.LightGray;
            btnST2.Enabled = false;
            btnST2.Font = new Font("Segoe UI", 14F);
            btnST2.Location = new Point(346, 793);
            btnST2.Margin = new Padding(3, 2, 3, 2);
            btnST2.Name = "btnST2";
            btnST2.Size = new Size(48, 38);
            btnST2.TabIndex = 47;
            btnST2.Text = "2";
            btnST2.UseVisualStyleBackColor = false;
            // 
            // btnST1
            // 
            btnST1.BackColor = Color.LightGray;
            btnST1.Enabled = false;
            btnST1.Font = new Font("Segoe UI", 14F);
            btnST1.Location = new Point(292, 793);
            btnST1.Margin = new Padding(3, 2, 3, 2);
            btnST1.Name = "btnST1";
            btnST1.Size = new Size(48, 38);
            btnST1.TabIndex = 46;
            btnST1.Text = "1";
            btnST1.UseVisualStyleBackColor = false;
            // 
            // btnCJM
            // 
            btnCJM.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCJM.Location = new Point(35, 662);
            btnCJM.Margin = new Padding(3, 2, 3, 2);
            btnCJM.Name = "btnCJM";
            btnCJM.Size = new Size(303, 41);
            btnCJM.TabIndex = 56;
            btnCJM.Text = "Check Job Match";
            btnCJM.UseVisualStyleBackColor = true;
            btnCJM.Click += btnCJM_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(430, 680);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 57;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.51545F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4845486F));
            tableLayoutPanel2.Controls.Add(cmbGetMachine, 0, 0);
            tableLayoutPanel2.Controls.Add(lblStatus0, 1, 0);
            tableLayoutPanel2.Location = new Point(35, 149);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(809, 44);
            tableLayoutPanel2.TabIndex = 59;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.9548874F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.04511F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.Controls.Add(btnGetJob, 0, 0);
            tableLayoutPanel3.Controls.Add(btnGetField, 0, 1);
            tableLayoutPanel3.Controls.Add(lblCountJN, 2, 0);
            tableLayoutPanel3.Controls.Add(lblCountFN, 2, 1);
            tableLayoutPanel3.Controls.Add(cmbGetField, 1, 1);
            tableLayoutPanel3.Controls.Add(cmbGetJob, 1, 0);
            tableLayoutPanel3.Location = new Point(35, 199);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 51F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 49F));
            tableLayoutPanel3.Size = new Size(809, 88);
            tableLayoutPanel3.TabIndex = 60;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnReconnect, 0, 0);
            tableLayoutPanel4.Controls.Add(btnGST, 0, 1);
            tableLayoutPanel4.Location = new Point(39, 733);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(179, 104);
            tableLayoutPanel4.TabIndex = 61;
            // 
            // txtField5
            // 
            txtField5.BorderStyle = BorderStyle.FixedSingle;
            txtField5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtField5.Location = new Point(250, 442);
            txtField5.Margin = new Padding(3, 2, 3, 2);
            txtField5.Name = "txtField5";
            txtField5.Size = new Size(523, 36);
            txtField5.TabIndex = 62;
            txtField5.TextAlign = HorizontalAlignment.Center;
            // 
            // pbCLRF1
            // 
            pbCLRF1.BackColor = Color.White;
            pbCLRF1.BorderStyle = BorderStyle.FixedSingle;
            pbCLRF1.Image = Properties.Resources.close;
            pbCLRF1.Location = new Point(777, 363);
            pbCLRF1.Name = "pbCLRF1";
            pbCLRF1.Size = new Size(48, 36);
            pbCLRF1.SizeMode = PictureBoxSizeMode.Zoom;
            pbCLRF1.TabIndex = 63;
            pbCLRF1.TabStop = false;
            pbCLRF1.Click += pbCLRF1_Click;
            // 
            // pbCLRF2
            // 
            pbCLRF2.BackColor = Color.White;
            pbCLRF2.BorderStyle = BorderStyle.FixedSingle;
            pbCLRF2.Image = Properties.Resources.close;
            pbCLRF2.Location = new Point(777, 402);
            pbCLRF2.Name = "pbCLRF2";
            pbCLRF2.Size = new Size(48, 36);
            pbCLRF2.SizeMode = PictureBoxSizeMode.Zoom;
            pbCLRF2.TabIndex = 64;
            pbCLRF2.TabStop = false;
            pbCLRF2.Click += pbCLRF2_Click;
            // 
            // pbCLRF3
            // 
            pbCLRF3.BackColor = Color.White;
            pbCLRF3.BorderStyle = BorderStyle.FixedSingle;
            pbCLRF3.Image = Properties.Resources.close;
            pbCLRF3.Location = new Point(777, 442);
            pbCLRF3.Name = "pbCLRF3";
            pbCLRF3.Size = new Size(48, 36);
            pbCLRF3.SizeMode = PictureBoxSizeMode.Zoom;
            pbCLRF3.TabIndex = 65;
            pbCLRF3.TabStop = false;
            pbCLRF3.Click += pbCLRF3_Click;
            // 
            // pbCLRF4
            // 
            pbCLRF4.BackColor = Color.White;
            pbCLRF4.BorderStyle = BorderStyle.FixedSingle;
            pbCLRF4.Image = Properties.Resources.close;
            pbCLRF4.Location = new Point(777, 484);
            pbCLRF4.Name = "pbCLRF4";
            pbCLRF4.Size = new Size(48, 36);
            pbCLRF4.SizeMode = PictureBoxSizeMode.Zoom;
            pbCLRF4.TabIndex = 66;
            pbCLRF4.TabStop = false;
            pbCLRF4.Click += pbCLRF4_Click;
            // 
            // pbCLRF5
            // 
            pbCLRF5.BackColor = Color.White;
            pbCLRF5.BorderStyle = BorderStyle.FixedSingle;
            pbCLRF5.Image = Properties.Resources.close;
            pbCLRF5.Location = new Point(777, 525);
            pbCLRF5.Name = "pbCLRF5";
            pbCLRF5.Size = new Size(48, 36);
            pbCLRF5.SizeMode = PictureBoxSizeMode.Zoom;
            pbCLRF5.TabIndex = 67;
            pbCLRF5.TabStop = false;
            pbCLRF5.Click += pbCLRF5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 861);
            Controls.Add(pbCLRF5);
            Controls.Add(pbCLRF4);
            Controls.Add(pbCLRF3);
            Controls.Add(pbCLRF2);
            Controls.Add(pbCLRF1);
            Controls.Add(txtField5);
            Controls.Add(panel1);
            Controls.Add(btnRC10);
            Controls.Add(btnRC9);
            Controls.Add(btnRC8);
            Controls.Add(btnRC7);
            Controls.Add(btnRC6);
            Controls.Add(btnRC5);
            Controls.Add(btnRC4);
            Controls.Add(btnRC3);
            Controls.Add(btnRC2);
            Controls.Add(btnRC1);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label1);
            Controls.Add(btnCJM);
            Controls.Add(btnST10);
            Controls.Add(btnST9);
            Controls.Add(btnST8);
            Controls.Add(btnST7);
            Controls.Add(btnST6);
            Controls.Add(btnST5);
            Controls.Add(btnST4);
            Controls.Add(btnST3);
            Controls.Add(btnST2);
            Controls.Add(btnST1);
            Controls.Add(btnSendJob);
            Controls.Add(btnSJ10);
            Controls.Add(btnSJ9);
            Controls.Add(btnSJ8);
            Controls.Add(btnSJ7);
            Controls.Add(btnSJ6);
            Controls.Add(btnSJ5);
            Controls.Add(btnSJ4);
            Controls.Add(btnSJ3);
            Controls.Add(btnSJ2);
            Controls.Add(btnSJ1);
            Controls.Add(txtField4);
            Controls.Add(cmbField6);
            Controls.Add(txtField3);
            Controls.Add(cmbField5);
            Controls.Add(cmbField3);
            Controls.Add(txtField2);
            Controls.Add(cmbField2);
            Controls.Add(txtField1);
            Controls.Add(cmbField1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCLRF1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCLRF2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCLRF3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCLRF4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCLRF5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnsOperator;
        private ToolStripMenuItem mnsSetting;
        private ToolStripMenuItem mnsTCP;
        private System.Windows.Forms.Timer timer1;
        private ComboBox cmbVNC;
        private ToolStripMenuItem mnsLog;
        private Button btnWebRemote;
        private Button btnVNCRemote;
        private ComboBox cmbWeb;
        private ComboBox cmbGetMachine;
        private Label lblStatus0;
        private Label lblCountJN;
        private ComboBox cmbGetJob;
        private Button btnGetJob;
        private Button btnGetField;
        private Label lblCountFN;
        private ComboBox cmbGetField;
        private Label lbl1;
        private Label lbl2;
        private ComboBox cmbField1;
        private TextBox txtField1;
        private TextBox txtField2;
        private ComboBox cmbField2;
        private ComboBox cmbField3;
        private TextBox txtField3;
        private ComboBox cmbField5;
        private TextBox txtField4;
        private ComboBox cmbField6;
        private Button btnSJ1;
        private Button btnSJ2;
        private Button btnSJ3;
        private Button btnSJ4;
        private Button btnSJ5;
        private Button btnSJ10;
        private Button btnSJ9;
        private Button btnSJ8;
        private Button btnSJ7;
        private Button btnSJ6;
        private Button btnSendJob;
        private Button btnReconnect;
        private Button btnGST;
        private Button btnRC1;
        private Button btnRC2;
        private Button btnRC4;
        private Button btnRC3;
        private Button btnRC6;
        private Button btnRC5;
        private Button btnRC8;
        private Button btnRC7;
        private Button btnRC10;
        private Button btnRC9;
        private Button btnST10;
        private Button btnST9;
        private Button btnST8;
        private Button btnST7;
        private Button btnST6;
        private Button btnST5;
        private Button btnST4;
        private Button btnST3;
        private Button btnST2;
        private Button btnST1;
        private ClockComponent clockComponent1;
        private ToolStripMenuItem registerToolStripMenuItem;
        private Button btnCJM;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox txtField5;
        private PictureBox pbCLRF1;
        private PictureBox pbCLRF2;
        private PictureBox pbCLRF3;
        private PictureBox pbCLRF4;
        private PictureBox pbCLRF5;
    }
}
