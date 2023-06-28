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
            lblEstadoTrasnferencia = new Label();
            panel2 = new Panel();
            lblRemotePath = new Label();
            lblEstadoTransferencia = new Label();
            textBox1 = new TextBox();
            lblPortNumber = new Label();
            lblPassword = new Label();
            txtPortNumber = new TextBox();
            txtPassword = new TextBox();
            lblUserName = new Label();
            lblHostName = new Label();
            txtUserName = new TextBox();
            txtHostName = new TextBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            btnHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            btnHome.IconColor = Color.DimGray;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 70;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(96, 100);
            btnHome.TabIndex = 8;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Dock = DockStyle.Bottom;
            btnSaveChanges.FlatStyle = FlatStyle.Popup;
            btnSaveChanges.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnSaveChanges.IconColor = Color.DimGray;
            btnSaveChanges.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSaveChanges.IconSize = 85;
            btnSaveChanges.Location = new Point(0, -1);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(830, 100);
            btnSaveChanges.TabIndex = 11;
            btnSaveChanges.Text = "Guardar";
            btnSaveChanges.TextAlign = ContentAlignment.MiddleRight;
            btnSaveChanges.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // lblEstadoTrasnferencia
            // 
            lblEstadoTrasnferencia.AutoSize = true;
            lblEstadoTrasnferencia.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoTrasnferencia.ForeColor = Color.FromArgb(20, 25, 25);
            lblEstadoTrasnferencia.Location = new Point(310, 25);
            lblEstadoTrasnferencia.Name = "lblEstadoTrasnferencia";
            lblEstadoTrasnferencia.Size = new Size(194, 32);
            lblEstadoTrasnferencia.TabIndex = 12;
            lblEstadoTrasnferencia.Text = "Vial Control S.A";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblRemotePath);
            panel2.Controls.Add(lblEstadoTransferencia);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lblPortNumber);
            panel2.Controls.Add(lblEstadoTrasnferencia);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(txtPortNumber);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(lblUserName);
            panel2.Controls.Add(lblHostName);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(txtHostName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(100, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(834, 408);
            panel2.TabIndex = 13;
            // 
            // lblRemotePath
            // 
            lblRemotePath.AutoSize = true;
            lblRemotePath.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRemotePath.ForeColor = Color.White;
            lblRemotePath.Location = new Point(46, 360);
            lblRemotePath.Name = "lblRemotePath";
            lblRemotePath.Size = new Size(66, 21);
            lblRemotePath.TabIndex = 18;
            lblRemotePath.Text = "Destino";
            lblRemotePath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEstadoTransferencia
            // 
            lblEstadoTransferencia.AutoSize = true;
            lblEstadoTransferencia.BackColor = Color.DimGray;
            lblEstadoTransferencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoTransferencia.ForeColor = Color.White;
            lblEstadoTransferencia.Location = new Point(65, 89);
            lblEstadoTransferencia.Name = "lblEstadoTransferencia";
            lblEstadoTransferencia.Size = new Size(113, 21);
            lblEstadoTransferencia.TabIndex = 14;
            lblEstadoTransferencia.Text = "Configuración";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DimGray;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(118, 357);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 29);
            textBox1.TabIndex = 17;
            // 
            // lblPortNumber
            // 
            lblPortNumber.AutoSize = true;
            lblPortNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPortNumber.ForeColor = Color.White;
            lblPortNumber.Location = new Point(53, 303);
            lblPortNumber.Name = "lblPortNumber";
            lblPortNumber.Size = new Size(59, 21);
            lblPortNumber.TabIndex = 16;
            lblPortNumber.Text = "Puerto";
            lblPortNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(20, 245);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(92, 21);
            lblPassword.TabIndex = 15;
            lblPassword.Text = "Contraseña";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPortNumber
            // 
            txtPortNumber.BackColor = Color.DimGray;
            txtPortNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPortNumber.Location = new Point(118, 300);
            txtPortNumber.Name = "txtPortNumber";
            txtPortNumber.Size = new Size(227, 29);
            txtPortNumber.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.DimGray;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(118, 243);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(227, 29);
            txtPassword.TabIndex = 13;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(47, 188);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(65, 21);
            lblUserName.TabIndex = 12;
            lblUserName.Text = "Usuario";
            lblUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHostName
            // 
            lblHostName.AutoSize = true;
            lblHostName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHostName.ForeColor = Color.White;
            lblHostName.Location = new Point(39, 129);
            lblHostName.Name = "lblHostName";
            lblHostName.Size = new Size(73, 21);
            lblHostName.TabIndex = 11;
            lblHostName.Text = "Servidor";
            lblHostName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.DimGray;
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(118, 186);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(227, 29);
            txtUserName.TabIndex = 10;
            // 
            // txtHostName
            // 
            txtHostName.BackColor = Color.DimGray;
            txtHostName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHostName.ForeColor = Color.White;
            txtHostName.Location = new Point(118, 129);
            txtHostName.Name = "txtHostName";
            txtHostName.Size = new Size(227, 29);
            txtHostName.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(20, 25, 25);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnSaveChanges);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(100, 408);
            panel3.Name = "panel3";
            panel3.Size = new Size(834, 103);
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
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ConfigUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfigUI";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnHome;
        private Label lblEstadoTrasnferencia;
        private FontAwesome.Sharp.IconButton btnSaveChanges;
        private Panel panel2;
        private Label lblPortNumber;
        private Label lblPassword;
        private TextBox txtPortNumber;
        private TextBox txtPassword;
        private Label lblUserName;
        private Label lblHostName;
        private TextBox txtUserName;
        private TextBox txtHostName;
        private Label lblRemotePath;
        private TextBox textBox1;
        private Label lblEstadoTransferencia;
        private Panel panel3;
    }
}