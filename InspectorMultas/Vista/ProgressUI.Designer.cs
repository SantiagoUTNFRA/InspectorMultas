namespace InspectorMultas
{
    partial class ProgressUI
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
            lblArchivoMoviendo = new Label();
            progressBar1 = new ProgressBar();
            listBox1 = new ListBox();
            label1 = new Label();
            btnExportCsv = new FontAwesome.Sharp.IconButton();
            btnExportPdf = new FontAwesome.Sharp.IconButton();
            btnExportJson = new FontAwesome.Sharp.IconButton();
            lblProgressPercentage = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 25, 25);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 512);
            panel1.TabIndex = 12;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            btnHome.IconColor = Color.Gray;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 70;
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(96, 100);
            btnHome.TabIndex = 8;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            btnHome.MouseEnter += btnHome_MouseEnter;
            btnHome.MouseLeave += btnHome_MouseLeave;
            // 
            // lblArchivoMoviendo
            // 
            lblArchivoMoviendo.AutoSize = true;
            lblArchivoMoviendo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblArchivoMoviendo.Location = new Point(106, 313);
            lblArchivoMoviendo.Name = "lblArchivoMoviendo";
            lblArchivoMoviendo.Size = new Size(0, 21);
            lblArchivoMoviendo.TabIndex = 16;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.ForeColor = Color.Gray;
            progressBar1.Location = new Point(100, 488);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(835, 24);
            progressBar1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Gray;
            listBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(100, 53);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(835, 256);
            listBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(328, 25);
            label1.TabIndex = 18;
            label1.Text = "Archivos transferidos correctamente:";
            // 
            // btnExportCsv
            // 
            btnExportCsv.FlatStyle = FlatStyle.Flat;
            btnExportCsv.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportCsv.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            btnExportCsv.IconColor = Color.Black;
            btnExportCsv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportCsv.IconSize = 40;
            btnExportCsv.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportCsv.Location = new Point(710, 430);
            btnExportCsv.Margin = new Padding(3, 4, 3, 4);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(213, 54);
            btnExportCsv.TabIndex = 19;
            btnExportCsv.Text = "Exportar a CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            btnExportCsv.MouseEnter += btnExportCsv_MouseEnter;
            btnExportCsv.MouseLeave += btnExportCsv_MouseLeave;
            // 
            // btnExportPdf
            // 
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnExportPdf.IconColor = Color.Black;
            btnExportPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportPdf.IconSize = 40;
            btnExportPdf.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportPdf.Location = new Point(710, 373);
            btnExportPdf.Margin = new Padding(3, 4, 3, 4);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(213, 54);
            btnExportPdf.TabIndex = 20;
            btnExportPdf.Text = "Exportar a PDF";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            btnExportPdf.MouseEnter += btnExportPdf_MouseEnter;
            btnExportPdf.MouseLeave += btnExportPdf_MouseLeave;
            // 
            // btnExportJson
            // 
            btnExportJson.FlatStyle = FlatStyle.Flat;
            btnExportJson.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportJson.IconChar = FontAwesome.Sharp.IconChar.FileCode;
            btnExportJson.IconColor = Color.Black;
            btnExportJson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportJson.IconSize = 40;
            btnExportJson.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportJson.Location = new Point(710, 313);
            btnExportJson.Margin = new Padding(3, 4, 3, 4);
            btnExportJson.Name = "btnExportJson";
            btnExportJson.Size = new Size(213, 54);
            btnExportJson.TabIndex = 21;
            btnExportJson.Text = "Exportar a JSON";
            btnExportJson.UseVisualStyleBackColor = true;
            btnExportJson.Click += btnExportJson_Click;
            btnExportJson.MouseEnter += btnExportJson_MouseEnter;
            btnExportJson.MouseLeave += btnExportJson_MouseLeave;
            // 
            // lblProgressPercentage
            // 
            lblProgressPercentage.AutoSize = true;
            lblProgressPercentage.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblProgressPercentage.Location = new Point(488, 454);
            lblProgressPercentage.Name = "lblProgressPercentage";
            lblProgressPercentage.Size = new Size(0, 30);
            lblProgressPercentage.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(100, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(835, 54);
            panel2.TabIndex = 23;
            // 
            // ProgressUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Gray;
            ClientSize = new Size(935, 512);
            Controls.Add(listBox1);
            Controls.Add(panel2);
            Controls.Add(lblProgressPercentage);
            Controls.Add(btnExportJson);
            Controls.Add(btnExportPdf);
            Controls.Add(btnExportCsv);
            Controls.Add(progressBar1);
            Controls.Add(lblArchivoMoviendo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ProgressUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Progreso";
            Load += ProgressUI_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnHome;
        private Label lblArchivoMoviendo;
        private ProgressBar progressBar1;
        private ListBox listBox1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnExportCsv;
        private FontAwesome.Sharp.IconButton btnExportPdf;
        private FontAwesome.Sharp.IconButton btnExportJson;
        private Label lblProgressPercentage;
        private Panel panel2;
    }
}