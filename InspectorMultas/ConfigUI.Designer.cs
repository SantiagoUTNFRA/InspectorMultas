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
            btnSaveChanges = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            lblEstadoTrasnferencia = new Label();
            panel2 = new Panel();
            lblRemotePath = new Label();
            textBox1 = new TextBox();
            lblPortNumber = new Label();
            lblPassword = new Label();
            txtPortNumber = new TextBox();
            txtPassword = new TextBox();
            lblUserName = new Label();
            lblHostName = new Label();
            txtUserName = new TextBox();
            txtHostName = new TextBox();
            lblEstadoTransferencia = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 18, 18);
            panel1.Controls.Add(btnSaveChanges);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 450);
            panel1.TabIndex = 11;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Dock = DockStyle.Top;
            btnSaveChanges.FlatStyle = FlatStyle.Popup;
            btnSaveChanges.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnSaveChanges.IconColor = Color.DimGray;
            btnSaveChanges.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSaveChanges.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveChanges.Location = new Point(0, 137);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(225, 137);
            btnSaveChanges.TabIndex = 11;
            btnSaveChanges.Text = "Guardar";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
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
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(225, 137);
            btnHome.TabIndex = 8;
            btnHome.Text = "Inicio";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // lblEstadoTrasnferencia
            // 
            lblEstadoTrasnferencia.AutoSize = true;
            lblEstadoTrasnferencia.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoTrasnferencia.ForeColor = Color.White;
            lblEstadoTrasnferencia.Location = new Point(417, 9);
            lblEstadoTrasnferencia.Name = "lblEstadoTrasnferencia";
            lblEstadoTrasnferencia.Size = new Size(184, 32);
            lblEstadoTrasnferencia.TabIndex = 12;
            lblEstadoTrasnferencia.Text = "Vial Control S.A";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblRemotePath);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lblPortNumber);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(txtPortNumber);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(lblUserName);
            panel2.Controls.Add(lblHostName);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(txtHostName);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(225, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 316);
            panel2.TabIndex = 13;
            // 
            // lblRemotePath
            // 
            lblRemotePath.AutoSize = true;
            lblRemotePath.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRemotePath.ForeColor = Color.White;
            lblRemotePath.Location = new Point(141, 262);
            lblRemotePath.Name = "lblRemotePath";
            lblRemotePath.Size = new Size(66, 21);
            lblRemotePath.TabIndex = 18;
            lblRemotePath.Text = "Destino";
            lblRemotePath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DimGray;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(213, 259);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 29);
            textBox1.TabIndex = 17;
            // 
            // lblPortNumber
            // 
            lblPortNumber.AutoSize = true;
            lblPortNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPortNumber.ForeColor = Color.White;
            lblPortNumber.Location = new Point(148, 205);
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
            lblPassword.Location = new Point(115, 147);
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
            txtPortNumber.Location = new Point(213, 202);
            txtPortNumber.Name = "txtPortNumber";
            txtPortNumber.Size = new Size(227, 29);
            txtPortNumber.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.DimGray;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(213, 145);
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
            lblUserName.Location = new Point(142, 90);
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
            lblHostName.Location = new Point(134, 31);
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
            txtUserName.Location = new Point(213, 88);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(227, 29);
            txtUserName.TabIndex = 10;
            // 
            // txtHostName
            // 
            txtHostName.BackColor = Color.DimGray;
            txtHostName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHostName.ForeColor = Color.White;
            txtHostName.Location = new Point(213, 31);
            txtHostName.Name = "txtHostName";
            txtHostName.Size = new Size(227, 29);
            txtHostName.TabIndex = 9;
            // 
            // lblEstadoTransferencia
            // 
            lblEstadoTransferencia.AutoSize = true;
            lblEstadoTransferencia.BackColor = Color.DimGray;
            lblEstadoTransferencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoTransferencia.ForeColor = Color.White;
            lblEstadoTransferencia.Location = new Point(449, 110);
            lblEstadoTransferencia.Name = "lblEstadoTransferencia";
            lblEstadoTransferencia.Size = new Size(113, 21);
            lblEstadoTransferencia.TabIndex = 14;
            lblEstadoTransferencia.Text = "Configuración";
            // 
            // ConfigUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEstadoTransferencia);
            Controls.Add(panel2);
            Controls.Add(lblEstadoTrasnferencia);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ConfigUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfigUI";
            Load += ConfigUI_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}