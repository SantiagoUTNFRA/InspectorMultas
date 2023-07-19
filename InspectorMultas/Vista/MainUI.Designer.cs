namespace InspectorMultas
{
    partial class MainUI
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
            lblTitulo = new Label();
            btnStartTransfer = new FontAwesome.Sharp.IconButton();
            btnConfig = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2 = new Panel();
            btnSftpConnection = new FontAwesome.Sharp.IconPictureBox();
            label5 = new Label();
            btnFileConfig = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            btnUpdateList = new FontAwesome.Sharp.IconPictureBox();
            btnInternetConnection = new FontAwesome.Sharp.IconPictureBox();
            btnConfigOk = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSftpConnection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnFileConfig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdateList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnInternetConnection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnConfigOk).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(20, 25, 25);
            lblTitulo.Location = new Point(310, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(194, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Vial Control S.A";
            // 
            // btnStartTransfer
            // 
            btnStartTransfer.Dock = DockStyle.Bottom;
            btnStartTransfer.FlatStyle = FlatStyle.Popup;
            btnStartTransfer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartTransfer.ForeColor = Color.Gray;
            btnStartTransfer.IconChar = FontAwesome.Sharp.IconChar.Play;
            btnStartTransfer.IconColor = Color.Gray;
            btnStartTransfer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStartTransfer.IconSize = 85;
            btnStartTransfer.Location = new Point(0, -1);
            btnStartTransfer.Name = "btnStartTransfer";
            btnStartTransfer.Size = new Size(830, 100);
            btnStartTransfer.TabIndex = 8;
            btnStartTransfer.Text = "Iniciar";
            btnStartTransfer.TextAlign = ContentAlignment.MiddleRight;
            btnStartTransfer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStartTransfer.UseVisualStyleBackColor = true;
            btnStartTransfer.Click += btnStartTransfer_Click;
            btnStartTransfer.MouseEnter += btnStartTransfer_MouseEnter;
            btnStartTransfer.MouseLeave += btnStartTransfer_MouseLeave;
            // 
            // btnConfig
            // 
            btnConfig.Dock = DockStyle.Top;
            btnConfig.FlatStyle = FlatStyle.Popup;
            btnConfig.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfig.ForeColor = Color.White;
            btnConfig.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            btnConfig.IconColor = Color.Gray;
            btnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfig.IconSize = 70;
            btnConfig.Location = new Point(0, 0);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(96, 100);
            btnConfig.TabIndex = 9;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            btnConfig.MouseEnter += btnConfig_MouseEnter;
            btnConfig.MouseLeave += btnConfig_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 25, 25);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnConfig);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 511);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(btnSftpConnection);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnFileConfig);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnUpdateList);
            panel2.Controls.Add(btnInternetConnection);
            panel2.Controls.Add(btnConfigOk);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblTitulo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(100, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(834, 408);
            panel2.TabIndex = 13;
            // 
            // btnSftpConnection
            // 
            btnSftpConnection.BackColor = Color.Gray;
            btnSftpConnection.ForeColor = SystemColors.ControlText;
            btnSftpConnection.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            btnSftpConnection.IconColor = SystemColors.ControlText;
            btnSftpConnection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSftpConnection.IconSize = 42;
            btnSftpConnection.Location = new Point(376, 122);
            btnSftpConnection.Name = "btnSftpConnection";
            btnSftpConnection.Size = new Size(42, 42);
            btnSftpConnection.TabIndex = 28;
            btnSftpConnection.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(20, 25, 25);
            label5.Location = new Point(424, 132);
            label5.Name = "label5";
            label5.Size = new Size(130, 21);
            label5.TabIndex = 27;
            label5.Text = "Conexión a SFTP";
            // 
            // btnFileConfig
            // 
            btnFileConfig.BackColor = Color.Gray;
            btnFileConfig.ForeColor = SystemColors.ControlText;
            btnFileConfig.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            btnFileConfig.IconColor = SystemColors.ControlText;
            btnFileConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFileConfig.IconSize = 42;
            btnFileConfig.Location = new Point(50, 122);
            btnFileConfig.Name = "btnFileConfig";
            btnFileConfig.Size = new Size(42, 42);
            btnFileConfig.TabIndex = 26;
            btnFileConfig.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(20, 25, 25);
            label4.Location = new Point(98, 132);
            label4.Name = "label4";
            label4.Size = new Size(214, 21);
            label4.TabIndex = 25;
            label4.Text = "Existe archivo configuración";
            // 
            // btnUpdateList
            // 
            btnUpdateList.BackColor = Color.Gray;
            btnUpdateList.ForeColor = SystemColors.ControlText;
            btnUpdateList.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            btnUpdateList.IconColor = SystemColors.ControlText;
            btnUpdateList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdateList.IconSize = 42;
            btnUpdateList.Location = new Point(376, 213);
            btnUpdateList.Name = "btnUpdateList";
            btnUpdateList.Size = new Size(42, 42);
            btnUpdateList.TabIndex = 24;
            btnUpdateList.TabStop = false;
            // 
            // btnInternetConnection
            // 
            btnInternetConnection.BackColor = Color.Gray;
            btnInternetConnection.ForeColor = SystemColors.ControlText;
            btnInternetConnection.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            btnInternetConnection.IconColor = SystemColors.ControlText;
            btnInternetConnection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInternetConnection.IconSize = 42;
            btnInternetConnection.Location = new Point(50, 304);
            btnInternetConnection.Name = "btnInternetConnection";
            btnInternetConnection.Size = new Size(42, 42);
            btnInternetConnection.TabIndex = 23;
            btnInternetConnection.TabStop = false;
            // 
            // btnConfigOk
            // 
            btnConfigOk.BackColor = Color.Gray;
            btnConfigOk.ForeColor = SystemColors.ControlText;
            btnConfigOk.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            btnConfigOk.IconColor = SystemColors.ControlText;
            btnConfigOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfigOk.IconSize = 42;
            btnConfigOk.Location = new Point(50, 213);
            btnConfigOk.Name = "btnConfigOk";
            btnConfigOk.Size = new Size(42, 42);
            btnConfigOk.TabIndex = 22;
            btnConfigOk.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(20, 25, 25);
            label3.Location = new Point(424, 223);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 21;
            label3.Text = "Lista actualizada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(20, 25, 25);
            label2.Location = new Point(98, 313);
            label2.Name = "label2";
            label2.Size = new Size(153, 21);
            label2.TabIndex = 20;
            label2.Text = "Conexión a internet";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(20, 25, 25);
            label1.Location = new Point(98, 223);
            label1.Name = "label1";
            label1.Size = new Size(186, 21);
            label1.TabIndex = 19;
            label1.Text = "Configuración completa";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(20, 25, 25);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnStartTransfer);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(100, 408);
            panel3.Name = "panel3";
            panel3.Size = new Size(834, 103);
            panel3.TabIndex = 15;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DimGray;
            ClientSize = new Size(934, 511);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subir información";
            Load += MainUI_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSftpConnection).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnFileConfig).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdateList).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnInternetConnection).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnConfigOk).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnStartTransfer;
        private FontAwesome.Sharp.IconButton btnConfig;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox btnConfigOk;
        private FontAwesome.Sharp.IconPictureBox btnUpdateList;
        private FontAwesome.Sharp.IconPictureBox btnInternetConnection;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox btnFileConfig;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox btnSftpConnection;
        private Label label5;
    }
}