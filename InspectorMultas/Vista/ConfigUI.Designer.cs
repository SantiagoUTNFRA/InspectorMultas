namespace InspectorMultas
{
    partial class ConfigUI
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
            btnHome = new FontAwesome.Sharp.IconButton();
            btnSaveChanges = new FontAwesome.Sharp.IconButton();
            lblTittle = new Label();
            pnlConfig = new Panel();
            gbxConfigFolder = new GroupBox();
            lblRemotePath = new Label();
            btnSourceFolder = new FontAwesome.Sharp.IconButton();
            txtSourcePath = new TextBox();
            lblSourcePath = new Label();
            txtRemotePath = new TextBox();
            gbxConfigServer = new GroupBox();
            lblHostName = new Label();
            txtHostName = new TextBox();
            txtUserName = new TextBox();
            lblUserName = new Label();
            lblPortNumber = new Label();
            txtPortNumber = new TextBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            pnlConfig.SuspendLayout();
            gbxConfigFolder.SuspendLayout();
            gbxConfigServer.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 25, 25);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 511);
            panel1.TabIndex = 11;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            btnHome.IconColor = Color.Gray;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 70;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(96, 100);
            btnHome.TabIndex = 8;
            btnHome.TextAlign = ContentAlignment.BottomCenter;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            btnHome.MouseEnter += btnHome_MouseEnter;
            btnHome.MouseLeave += btnHome_MouseLeave;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Dock = DockStyle.Bottom;
            btnSaveChanges.FlatStyle = FlatStyle.Popup;
            btnSaveChanges.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveChanges.ForeColor = Color.Gray;
            btnSaveChanges.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnSaveChanges.IconColor = Color.Gray;
            btnSaveChanges.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSaveChanges.IconSize = 85;
            btnSaveChanges.Location = new Point(0, -4);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(830, 100);
            btnSaveChanges.TabIndex = 11;
            btnSaveChanges.Text = "Guardar";
            btnSaveChanges.TextAlign = ContentAlignment.MiddleRight;
            btnSaveChanges.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            btnSaveChanges.MouseEnter += btnSaveChanges_MouseEnter;
            btnSaveChanges.MouseLeave += btnSaveChanges_MouseLeave;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTittle.ForeColor = Color.FromArgb(20, 25, 25);
            lblTittle.Location = new Point(310, 25);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(194, 32);
            lblTittle.TabIndex = 12;
            lblTittle.Text = "Vial Control S.A";
            // 
            // pnlConfig
            // 
            pnlConfig.BackColor = Color.Gray;
            pnlConfig.Controls.Add(gbxConfigFolder);
            pnlConfig.Controls.Add(gbxConfigServer);
            pnlConfig.Controls.Add(lblTittle);
            pnlConfig.Dock = DockStyle.Top;
            pnlConfig.ForeColor = Color.FromArgb(20, 25, 25);
            pnlConfig.Location = new Point(100, 0);
            pnlConfig.Name = "pnlConfig";
            pnlConfig.Size = new Size(834, 411);
            pnlConfig.TabIndex = 13;
            // 
            // gbxConfigFolder
            // 
            gbxConfigFolder.Controls.Add(lblRemotePath);
            gbxConfigFolder.Controls.Add(btnSourceFolder);
            gbxConfigFolder.Controls.Add(txtSourcePath);
            gbxConfigFolder.Controls.Add(lblSourcePath);
            gbxConfigFolder.Controls.Add(txtRemotePath);
            gbxConfigFolder.FlatStyle = FlatStyle.Flat;
            gbxConfigFolder.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            gbxConfigFolder.ForeColor = Color.FromArgb(20, 25, 25);
            gbxConfigFolder.Location = new Point(6, 181);
            gbxConfigFolder.Name = "gbxConfigFolder";
            gbxConfigFolder.Size = new Size(368, 222);
            gbxConfigFolder.TabIndex = 20;
            gbxConfigFolder.TabStop = false;
            gbxConfigFolder.Text = "Carpeta";
            // 
            // lblRemotePath
            // 
            lblRemotePath.AutoSize = true;
            lblRemotePath.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRemotePath.ForeColor = Color.FromArgb(20, 25, 25);
            lblRemotePath.Location = new Point(11, 109);
            lblRemotePath.Name = "lblRemotePath";
            lblRemotePath.Size = new Size(66, 21);
            lblRemotePath.TabIndex = 18;
            lblRemotePath.Text = "Destino";
            lblRemotePath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSourceFolder
            // 
            btnSourceFolder.AutoEllipsis = true;
            btnSourceFolder.BackColor = Color.Gray;
            btnSourceFolder.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnSourceFolder.FlatAppearance.BorderSize = 0;
            btnSourceFolder.FlatStyle = FlatStyle.Popup;
            btnSourceFolder.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSourceFolder.ForeColor = Color.White;
            btnSourceFolder.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            btnSourceFolder.IconColor = Color.FromArgb(20, 25, 25);
            btnSourceFolder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSourceFolder.IconSize = 25;
            btnSourceFolder.Location = new Point(313, 50);
            btnSourceFolder.Margin = new Padding(0);
            btnSourceFolder.Name = "btnSourceFolder";
            btnSourceFolder.Size = new Size(31, 29);
            btnSourceFolder.TabIndex = 21;
            btnSourceFolder.UseVisualStyleBackColor = false;
            btnSourceFolder.Click += btnSourceFolder_Click;
            btnSourceFolder.MouseEnter += btnSourceFolder_MouseEnter;
            btnSourceFolder.MouseLeave += btnSourceFolder_MouseLeave;
            // 
            // txtSourcePath
            // 
            txtSourcePath.BackColor = Color.Gray;
            txtSourcePath.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSourcePath.Location = new Point(83, 50);
            txtSourcePath.Name = "txtSourcePath";
            txtSourcePath.Size = new Size(227, 29);
            txtSourcePath.TabIndex = 13;
            // 
            // lblSourcePath
            // 
            lblSourcePath.AutoSize = true;
            lblSourcePath.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSourcePath.ForeColor = Color.FromArgb(20, 25, 25);
            lblSourcePath.Location = new Point(11, 53);
            lblSourcePath.Name = "lblSourcePath";
            lblSourcePath.Size = new Size(60, 21);
            lblSourcePath.TabIndex = 15;
            lblSourcePath.Text = "Origen";
            lblSourcePath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRemotePath
            // 
            txtRemotePath.BackColor = Color.Gray;
            txtRemotePath.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRemotePath.Location = new Point(83, 108);
            txtRemotePath.Name = "txtRemotePath";
            txtRemotePath.Size = new Size(227, 29);
            txtRemotePath.TabIndex = 17;
            // 
            // gbxConfigServer
            // 
            gbxConfigServer.Controls.Add(lblHostName);
            gbxConfigServer.Controls.Add(txtHostName);
            gbxConfigServer.Controls.Add(txtUserName);
            gbxConfigServer.Controls.Add(lblUserName);
            gbxConfigServer.Controls.Add(lblPortNumber);
            gbxConfigServer.Controls.Add(txtPortNumber);
            gbxConfigServer.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            gbxConfigServer.ForeColor = Color.FromArgb(20, 25, 25);
            gbxConfigServer.Location = new Point(454, 181);
            gbxConfigServer.Name = "gbxConfigServer";
            gbxConfigServer.Size = new Size(368, 222);
            gbxConfigServer.TabIndex = 19;
            gbxConfigServer.TabStop = false;
            gbxConfigServer.Text = "Server";
            // 
            // lblHostName
            // 
            lblHostName.AutoSize = true;
            lblHostName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHostName.ForeColor = Color.FromArgb(20, 25, 25);
            lblHostName.Location = new Point(16, 56);
            lblHostName.Name = "lblHostName";
            lblHostName.Size = new Size(73, 21);
            lblHostName.TabIndex = 11;
            lblHostName.Text = "Servidor";
            lblHostName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHostName
            // 
            txtHostName.BackColor = Color.Gray;
            txtHostName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHostName.ForeColor = Color.White;
            txtHostName.Location = new Point(95, 50);
            txtHostName.Name = "txtHostName";
            txtHostName.Size = new Size(227, 29);
            txtHostName.TabIndex = 9;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.Gray;
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(95, 108);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(227, 29);
            txtUserName.TabIndex = 10;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.FromArgb(20, 25, 25);
            lblUserName.Location = new Point(16, 109);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(65, 21);
            lblUserName.TabIndex = 12;
            lblUserName.Text = "Usuario";
            lblUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPortNumber
            // 
            lblPortNumber.AutoSize = true;
            lblPortNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPortNumber.ForeColor = Color.FromArgb(20, 25, 25);
            lblPortNumber.Location = new Point(16, 165);
            lblPortNumber.Name = "lblPortNumber";
            lblPortNumber.Size = new Size(59, 21);
            lblPortNumber.TabIndex = 16;
            lblPortNumber.Text = "Puerto";
            lblPortNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPortNumber
            // 
            txtPortNumber.BackColor = Color.Gray;
            txtPortNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPortNumber.Location = new Point(95, 163);
            txtPortNumber.Name = "txtPortNumber";
            txtPortNumber.Size = new Size(227, 29);
            txtPortNumber.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(20, 25, 25);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnSaveChanges);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(100, 411);
            panel3.Name = "panel3";
            panel3.Size = new Size(834, 100);
            panel3.TabIndex = 16;
            // 
            // ConfigUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DimGray;
            ClientSize = new Size(934, 511);
            Controls.Add(panel3);
            Controls.Add(pnlConfig);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ConfigUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panel1.ResumeLayout(false);
            pnlConfig.ResumeLayout(false);
            pnlConfig.PerformLayout();
            gbxConfigFolder.ResumeLayout(false);
            gbxConfigFolder.PerformLayout();
            gbxConfigServer.ResumeLayout(false);
            gbxConfigServer.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnHome;
        private Label lblTittle;
        private FontAwesome.Sharp.IconButton btnSaveChanges;
        private Panel pnlConfig;
        private Label lblPortNumber;
        private Label lblSourcePath;
        private TextBox txtPortNumber;
        private TextBox txtSourcePath;
        private Label lblUserName;
        private Label lblHostName;
        private TextBox txtUserName;
        private TextBox txtHostName;
        private Label lblRemotePath;
        private TextBox txtRemotePath;
        private Panel panel3;
        private GroupBox gbxConfigServer;
        private GroupBox gbxConfigFolder;
        private FontAwesome.Sharp.IconButton btnSourceFolder;
    }
}