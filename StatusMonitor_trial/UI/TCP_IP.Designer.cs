namespace StatusMonitor_trial
{
    partial class TCP_IP
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
            menuStrip1 = new MenuStrip();
            mnsOperator = new ToolStripMenuItem();
            mnsTCP = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            mnsSetting = new ToolStripMenuItem();
            mnsLog = new ToolStripMenuItem();
            panel1 = new Panel();
            clockComponent1 = new ClockComponent();
            btnWebRemote = new Button();
            btnVNCRemote = new Button();
            cmbWeb = new ComboBox();
            cmbVNC = new ComboBox();
            dgvMachines = new DataGridView();
            lbl2 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtPort = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDel = new Button();
            txtIP = new TextBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMachines).BeginInit();
            SuspendLayout();
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
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnsOperator
            // 
            mnsOperator.Name = "mnsOperator";
            mnsOperator.Size = new Size(85, 25);
            mnsOperator.Text = "Operator";
            mnsOperator.Click += mnsOperator_Click;
            // 
            // mnsTCP
            // 
            mnsTCP.BackColor = Color.Green;
            mnsTCP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mnsTCP.ForeColor = Color.White;
            mnsTCP.Name = "mnsTCP";
            mnsTCP.Size = new Size(72, 25);
            mnsTCP.Text = "TCP/IP";
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
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(clockComponent1);
            panel1.Controls.Add(btnWebRemote);
            panel1.Controls.Add(btnVNCRemote);
            panel1.Controls.Add(cmbWeb);
            panel1.Controls.Add(cmbVNC);
            panel1.Location = new Point(0, 29);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 105);
            panel1.TabIndex = 3;
            // 
            // clockComponent1
            // 
            clockComponent1.Location = new Point(18, 9);
            clockComponent1.Margin = new Padding(3, 2, 3, 2);
            clockComponent1.Name = "clockComponent1";
            clockComponent1.Size = new Size(168, 91);
            clockComponent1.TabIndex = 5;
            // 
            // btnWebRemote
            // 
            btnWebRemote.Font = new Font("Segoe UI", 14F);
            btnWebRemote.Location = new Point(674, 58);
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
            btnVNCRemote.Font = new Font("Segoe UI", 14F);
            btnVNCRemote.Location = new Point(674, 12);
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
            cmbWeb.Location = new Point(206, 62);
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
            cmbVNC.Location = new Point(206, 16);
            cmbVNC.Margin = new Padding(3, 2, 3, 2);
            cmbVNC.Name = "cmbVNC";
            cmbVNC.Size = new Size(426, 33);
            cmbVNC.TabIndex = 1;
            cmbVNC.Text = "Path VNC";
            // 
            // dgvMachines
            // 
            dgvMachines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMachines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMachines.Location = new Point(33, 152);
            dgvMachines.Margin = new Padding(3, 2, 3, 2);
            dgvMachines.Name = "dgvMachines";
            dgvMachines.RowHeadersWidth = 51;
            dgvMachines.Size = new Size(786, 380);
            dgvMachines.TabIndex = 4;
            dgvMachines.CellContentClick += dgvMachines_CellContentClick;
            // 
            // lbl2
            // 
            lbl2.BackColor = Color.SandyBrown;
            lbl2.BorderStyle = BorderStyle.FixedSingle;
            lbl2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbl2.ForeColor = Color.White;
            lbl2.Location = new Point(270, 573);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(361, 40);
            lbl2.TabIndex = 14;
            lbl2.Text = "IP Address";
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 0, 192);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 573);
            label1.Name = "label1";
            label1.Size = new Size(239, 40);
            label1.TabIndex = 15;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.SaddleBrown;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(631, 573);
            label2.Name = "label2";
            label2.Size = new Size(188, 40);
            label2.TabIndex = 16;
            label2.Text = "Port";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 16F);
            txtName.Location = new Point(32, 614);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 36);
            txtName.TabIndex = 17;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPort
            // 
            txtPort.Font = new Font("Segoe UI", 16F);
            txtPort.Location = new Point(631, 614);
            txtPort.Margin = new Padding(3, 2, 3, 2);
            txtPort.MaxLength = 5;
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(188, 36);
            txtPort.TabIndex = 19;
            txtPort.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(32, 681);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(187, 46);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 0, 192);
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(337, 681);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(187, 46);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(192, 0, 0);
            btnDel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(631, 681);
            btnDel.Margin = new Padding(3, 2, 3, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(187, 46);
            btnDel.TabIndex = 21;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // txtIP
            // 
            txtIP.Font = new Font("Segoe UI", 16F);
            txtIP.Location = new Point(270, 614);
            txtIP.Margin = new Padding(3, 2, 3, 2);
            txtIP.MaxLength = 15;
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(361, 36);
            txtIP.TabIndex = 22;
            txtIP.TextAlign = HorizontalAlignment.Center;
            // 
            // TCP_IP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 861);
            Controls.Add(txtIP);
            Controls.Add(btnDel);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPort);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl2);
            Controls.Add(dgvMachines);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TCP_IP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TCP_IP";
            FormClosing += TCP_IP_FormClosing;
            Load += TCP_IP_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMachines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnsOperator;
        private ToolStripMenuItem mnsLog;
        private ToolStripMenuItem mnsSetting;
        private ToolStripMenuItem mnsTCP;
        private Panel panel1;
        private Button btnWebRemote;
        private Button btnVNCRemote;
        private ComboBox cmbWeb;
        private ComboBox cmbVNC;
        private ClockComponent clockComponent1;
        private DataGridView dgvMachines;
        private Label lbl2;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtPort;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDel;
        private TextBox txtIP;
        private ToolStripMenuItem registerToolStripMenuItem;
    }
}