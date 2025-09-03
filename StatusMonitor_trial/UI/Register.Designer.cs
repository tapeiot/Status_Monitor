namespace StatusMonitor_trial
{
    partial class Register
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
            label1 = new Label();
            txtUser = new TextBox();
            label2 = new Label();
            txtPass = new TextBox();
            btnSave = new Button();
            btnDel = new Button();
            btnUpdate = new Button();
            dgvUserList = new DataGridView();
            cmbRole = new ComboBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).BeginInit();
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
            menuStrip1.TabIndex = 4;
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
            mnsTCP.BackColor = SystemColors.Control;
            mnsTCP.ForeColor = Color.Black;
            mnsTCP.Name = "mnsTCP";
            mnsTCP.Size = new Size(67, 25);
            mnsTCP.Text = "TCP/IP";
            mnsTCP.Click += mnsTCP_Click;
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.BackColor = Color.Green;
            registerToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerToolStripMenuItem.ForeColor = Color.White;
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(84, 25);
            registerToolStripMenuItem.Text = "Register";
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
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 0, 192);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 518);
            label1.Name = "label1";
            label1.Size = new Size(178, 36);
            label1.TabIndex = 18;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 16F);
            txtUser.Location = new Point(231, 518);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(441, 36);
            txtUser.TabIndex = 19;
            txtUser.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(192, 64, 0);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 573);
            label2.Name = "label2";
            label2.Size = new Size(178, 36);
            label2.TabIndex = 20;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 16F);
            txtPass.Location = new Point(231, 573);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(441, 36);
            txtPass.TabIndex = 21;
            txtPass.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(47, 688);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(187, 46);
            btnSave.TabIndex = 22;
            btnSave.Text = "Add";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(192, 0, 0);
            btnDel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(646, 688);
            btnDel.Margin = new Padding(3, 2, 3, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(187, 46);
            btnDel.TabIndex = 23;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 0, 192);
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(364, 688);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(187, 46);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvUserList
            // 
            dgvUserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserList.Location = new Point(47, 52);
            dgvUserList.Margin = new Padding(3, 2, 3, 2);
            dgvUserList.Name = "dgvUserList";
            dgvUserList.RowHeadersWidth = 51;
            dgvUserList.Size = new Size(786, 412);
            dgvUserList.TabIndex = 25;
            dgvUserList.CellContentClick += dgvUserList_CellContentClick;
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI", 16F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Operator" });
            cmbRole.Location = new Point(676, 516);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(157, 38);
            cmbRole.TabIndex = 26;
            cmbRole.Text = "Role";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 861);
            Controls.Add(cmbRole);
            Controls.Add(dgvUserList);
            Controls.Add(btnUpdate);
            Controls.Add(btnDel);
            Controls.Add(menuStrip1);
            Controls.Add(btnSave);
            Controls.Add(txtPass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            FormClosing += Register_FormClosing;
            Load += Register_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnsOperator;
        private ToolStripMenuItem mnsLog;
        private ToolStripMenuItem mnsSetting;
        private ToolStripMenuItem mnsTCP;
        private Label label1;
        private TextBox txtUser;
        private Label label2;
        private TextBox txtPass;
        private Button btnSave;
        private Button btnDel;
        private Button btnUpdate;
        private DataGridView dgvUserList;
        private ComboBox cmbRole;
        private ToolStripMenuItem registerToolStripMenuItem;
    }
}