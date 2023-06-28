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
            lblEstadoTransferencia = new Label();
            panel2 = new Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(417, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(184, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Vial Control S.A";
            // 
            // btnStartTransfer
            // 
            btnStartTransfer.Dock = DockStyle.Top;
            btnStartTransfer.FlatStyle = FlatStyle.Popup;
            btnStartTransfer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartTransfer.ForeColor = Color.White;
            btnStartTransfer.IconChar = FontAwesome.Sharp.IconChar.Play;
            btnStartTransfer.IconColor = Color.DimGray;
            btnStartTransfer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStartTransfer.ImageAlign = ContentAlignment.MiddleLeft;
            btnStartTransfer.Location = new Point(0, 137);
            btnStartTransfer.Name = "btnStartTransfer";
            btnStartTransfer.Size = new Size(225, 137);
            btnStartTransfer.TabIndex = 8;
            btnStartTransfer.Text = "Empezar";
            btnStartTransfer.UseVisualStyleBackColor = true;
            btnStartTransfer.Click += btnStartTransfer_Click;
            // 
            // btnConfig
            // 
            btnConfig.Dock = DockStyle.Top;
            btnConfig.FlatStyle = FlatStyle.Popup;
            btnConfig.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfig.ForeColor = Color.White;
            btnConfig.IconChar = FontAwesome.Sharp.IconChar.Tools;
            btnConfig.IconColor = Color.DimGray;
            btnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfig.Location = new Point(0, 0);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(225, 137);
            btnConfig.TabIndex = 9;
            btnConfig.Text = "      Configuración";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 18, 18);
            panel1.Controls.Add(btnStartTransfer);
            panel1.Controls.Add(btnConfig);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 450);
            panel1.TabIndex = 10;
            // 
            // lblEstadoTransferencia
            // 
            lblEstadoTransferencia.AutoSize = true;
            lblEstadoTransferencia.BackColor = Color.DimGray;
            lblEstadoTransferencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoTransferencia.ForeColor = Color.White;
            lblEstadoTransferencia.Location = new Point(412, 110);
            lblEstadoTransferencia.Name = "lblEstadoTransferencia";
            lblEstadoTransferencia.Size = new Size(189, 21);
            lblEstadoTransferencia.TabIndex = 12;
            lblEstadoTransferencia.Text = "Transferencia no iniciada";
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox3);
            panel2.Controls.Add(iconPictureBox2);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(225, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 313);
            panel2.TabIndex = 13;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.DimGray;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 42;
            iconPictureBox3.Location = new Point(165, 173);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(42, 42);
            iconPictureBox3.TabIndex = 24;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.DimGray;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 42;
            iconPictureBox2.Location = new Point(165, 103);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(42, 42);
            iconPictureBox2.TabIndex = 23;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.DimGray;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 42;
            iconPictureBox1.Location = new Point(165, 33);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(42, 42);
            iconPictureBox1.TabIndex = 22;
            iconPictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(213, 184);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 21;
            label3.Text = "Lista actualizada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(213, 114);
            label2.Name = "label2";
            label2.Size = new Size(178, 21);
            label2.TabIndex = 20;
            label2.Text = "Configuración correcta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(213, 43);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 19;
            label1.Text = "Conexión a internet";
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(lblEstadoTransferencia);
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subir información";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnStartTransfer;
        private FontAwesome.Sharp.IconButton btnConfig;
        private Panel panel1;
        private Label lblEstadoTransferencia;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}