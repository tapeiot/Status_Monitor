namespace StatusMonitor_trial
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            panel1 = new Panel();
            clockComponent1 = new ClockComponent();
            btnWebRemote = new Button();
            btnVNCRemote = new Button();
            cmbWeb = new ComboBox();
            cmbVNC = new ComboBox();
            groupBox2 = new GroupBox();
            cmbRole = new ComboBox();
            label1 = new Label();
            dgvPath = new DataGridView();
            label2 = new Label();
            txtPath = new TextBox();
            label3 = new Label();
            btnDel = new Button();
            txtName = new TextBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            menuStrip1 = new MenuStrip();
            mnsOperator = new ToolStripMenuItem();
            mnsTCP = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            mnsSetting = new ToolStripMenuItem();
            mnsLog = new ToolStripMenuItem();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPath).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(clockComponent1);
            panel1.Controls.Add(btnWebRemote);
            panel1.Controls.Add(btnVNCRemote);
            panel1.Controls.Add(cmbWeb);
            panel1.Controls.Add(cmbVNC);
            panel1.Location = new Point(0, 31);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 105);
            panel1.TabIndex = 33;
            // 
            // clockComponent1
            // 
            clockComponent1.Location = new Point(3, 8);
            clockComponent1.Margin = new Padding(3, 2, 3, 2);
            clockComponent1.Name = "clockComponent1";
            clockComponent1.Size = new Size(168, 91);
            clockComponent1.TabIndex = 5;
            // 
            // btnWebRemote
            // 
            btnWebRemote.Font = new Font("Segoe UI", 14F);
            btnWebRemote.Location = new Point(705, 60);
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
            btnVNCRemote.Location = new Point(705, 14);
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
            cmbWeb.Items.AddRange(new object[] { "videoJet1 : C:/afkaf", "videoJet2 : C:/afkaf" });
            cmbWeb.Location = new Point(206, 62);
            cmbWeb.Margin = new Padding(3, 2, 3, 2);
            cmbWeb.Name = "cmbWeb";
            cmbWeb.Size = new Size(458, 33);
            cmbWeb.TabIndex = 2;
            cmbWeb.Text = "Path WebBrowser";
            // 
            // cmbVNC
            // 
            cmbVNC.Font = new Font("Segoe UI", 14F);
            cmbVNC.FormattingEnabled = true;
            cmbVNC.Items.AddRange(new object[] { "videoJet1 : C:/afkaf", "videoJet2 : C:/afkaf" });
            cmbVNC.Location = new Point(206, 16);
            cmbVNC.Margin = new Padding(3, 2, 3, 2);
            cmbVNC.Name = "cmbVNC";
            cmbVNC.Size = new Size(458, 33);
            cmbVNC.TabIndex = 1;
            cmbVNC.Text = "Path VNC";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbRole);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dgvPath);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtPath);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnDel);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(12, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(860, 603);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Path Setting";
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI", 16F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "VNC", "Web" });
            cmbRole.Location = new Point(697, 481);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(144, 38);
            cmbRole.TabIndex = 34;
            // 
            // label1
            // 
            label1.BackColor = Color.SaddleBrown;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(697, 442);
            label1.Name = "label1";
            label1.Size = new Size(144, 40);
            label1.TabIndex = 33;
            label1.Text = "Type";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvPath
            // 
            dgvPath.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPath.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPath.Location = new Point(18, 26);
            dgvPath.Margin = new Padding(3, 2, 3, 2);
            dgvPath.Name = "dgvPath";
            dgvPath.RowHeadersWidth = 51;
            dgvPath.Size = new Size(820, 405);
            dgvPath.TabIndex = 23;
            dgvPath.CellContentClick += dgvPath_CellContentClick;
            // 
            // label2
            // 
            label2.BackColor = Color.SandyBrown;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(257, 442);
            label2.Name = "label2";
            label2.Size = new Size(440, 40);
            label2.TabIndex = 25;
            label2.Text = "Web Browser Path";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPath
            // 
            txtPath.Font = new Font("Segoe UI", 16F);
            txtPath.Location = new Point(257, 483);
            txtPath.Margin = new Padding(3, 2, 3, 2);
            txtPath.MaxLength = 20000;
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(440, 36);
            txtPath.TabIndex = 32;
            txtPath.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(0, 0, 192);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 441);
            label3.Name = "label3";
            label3.Size = new Size(239, 41);
            label3.TabIndex = 26;
            label3.Text = "Name";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(192, 0, 0);
            btnDel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(651, 536);
            btnDel.Margin = new Padding(3, 2, 3, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(187, 46);
            btnDel.TabIndex = 31;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 16F);
            txtName.Location = new Point(19, 483);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 36);
            txtName.TabIndex = 28;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 0, 192);
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(354, 536);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(187, 46);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(19, 536);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(187, 46);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            menuStrip1.TabIndex = 36;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnsOperator
            // 
            mnsOperator.BackColor = SystemColors.Control;
            mnsOperator.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnsOperator.ForeColor = Color.Black;
            mnsOperator.Name = "mnsOperator";
            mnsOperator.Size = new Size(85, 25);
            mnsOperator.Text = "Operator";
            mnsOperator.Click += mnsOperator_Click;
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
            mnsSetting.BackColor = Color.Green;
            mnsSetting.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mnsSetting.ForeColor = Color.White;
            mnsSetting.Name = "mnsSetting";
            mnsSetting.Size = new Size(77, 25);
            mnsSetting.Text = "Setting";
            // 
            // mnsLog
            // 
            mnsLog.Name = "mnsLog";
            mnsLog.Size = new Size(48, 25);
            mnsLog.Text = "Log";
            mnsLog.Click += mnsLog_Click;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 861);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Setting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setting";
            FormClosing += Setting_FormClosing;
            Load += Setting_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPath).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private ClockComponent clockComponent1;
        private Button btnWebRemote;
        private Button btnVNCRemote;
        private ComboBox cmbWeb;
        private ComboBox cmbVNC;
        private GroupBox groupBox2;
        private DataGridView dgvPath;
        private Label label2;
        private TextBox txtPath;
        private Label label3;
        private Button btnDel;
        private TextBox txtName;
        private Button btnUpdate;
        private Button btnAdd;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnsOperator;
        private ToolStripMenuItem mnsTCP;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem mnsSetting;
        private ToolStripMenuItem mnsLog;
        private Label label1;
        private ComboBox cmbRole;
    }
}