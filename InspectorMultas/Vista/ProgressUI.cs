using CsvHelper;
using InspectorMultas.Logica;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Formats.Asn1;
using System.Globalization;
using Font = iTextSharp.text.Font;

namespace InspectorMultas
{
    public partial class ProgressUI : Form
    {
        private readonly TransferSftp _transferenciaSftp;
        private static ProgressUI _instance = null!;
        private readonly Dictionary<string, DateTime> _subidaArchivo;

        public static ProgressUI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProgressUI();
                }
                return _instance;
            }
        }

        public ProgressUI()
        {
            InitializeComponent();
            _transferenciaSftp = new TransferSftp();
            _subidaArchivo = new Dictionary<string, DateTime>();
        }

        public void ResetUI()
        {
            progressBar1.Value = 0;
            listBox1.Items.Clear();
            lblArchivoMoviendo.Text = "";
            lblProgressPercentage.Text = "0%";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUI.Instance.Show();
        }

        private void ProgressUI_Load(object sender, EventArgs e)
        {
            try
            {
                _transferenciaSftp.TransferenciaProgreso += TransferenciaSftp_TransferenciaProgreso!;

                _transferenciaSftp.ArchivoTransferido += (sender, e) =>
                {
                    Invoke(() =>
                    {
                        string nombreArchivo = Path.GetFileName(e.FileName);
                        listBox1.Items.Add(nombreArchivo);
                        _subidaArchivo[nombreArchivo] = DateTime.Now;
                    });
                };

                // Cargar configuración
                SftpConfig config = _transferenciaSftp.LoadConfig();

                Task.Run(() => _transferenciaSftp.RealizarTransferencia(config.DirectorioTrabajo));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TransferenciaSftp_TransferenciaProgreso(object sender, TransferenciaProgresoEventArgs e)
        {
            this.Invoke((Action)(() =>
            {
                progressBar1.Value = e.Porcentaje;

                // Obtén solo el nombre del archivo
                string nombreArchivo = Path.GetFileName(e.NombreArchivo);
                lblArchivoMoviendo.Text = $"Moviendo el archivo: {nombreArchivo}";

                lblProgressPercentage.Text = $"{e.Porcentaje}%";
            }));
        }


        private void ExportarInforme(string rutaArchivo)
        {
            Document document = new();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(rutaArchivo, FileMode.Create));
            document.Open();

            // Establecer la fuente
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fontTitle = new(baseFont, 20, iTextSharp.text.Font.BOLD);
            Font fontHeader = new(baseFont, 18, iTextSharp.text.Font.NORMAL, new BaseColor(20, 25, 25));
            Font fontBody = new(baseFont, 16, iTextSharp.text.Font.NORMAL);
            Font fontFirma = new(baseFont, 18, iTextSharp.text.Font.NORMAL, new BaseColor(20, 25, 25));

            // Título del documento
            Paragraph title = new("Vial Control - Informe de transferencias de archivos", fontTitle)
            {
                Alignment = Element.ALIGN_CENTER
            };
            document.Add(title);
            document.Add(new Paragraph("\n"));

            PdfPTable table = new(3);

            //encabezados de las columnas
            PdfPCell cell = new(new Phrase("Nombre del archivo", fontHeader))
            {
                BackgroundColor = new BaseColor(210, 210, 210)
            };
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Estado", fontHeader))
            {
                BackgroundColor = new BaseColor(210, 210, 210)
            };
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Fecha y Hora de Subida", fontHeader))
            {
                BackgroundColor = new BaseColor(210, 210, 210)
            };
            table.AddCell(cell);

            // Itera a través de los archivos a mover
            foreach (string nombreArchivo in _transferenciaSftp.GetArchivosAMover())
            {
                table.AddCell(new Phrase(nombreArchivo, fontBody));

                if (listBox1.Items.Contains(nombreArchivo))
                {
                    cell = new PdfPCell(new Phrase("Transferido correctamente", fontBody));
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(_subidaArchivo[nombreArchivo].ToString(), fontBody));
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase("No transferido", fontBody))
                    {
                        BackgroundColor = new BaseColor(255, 102, 102)
                    };
                    table.AddCell(cell);

                    cell = new PdfPCell
                    {
                        BackgroundColor = new BaseColor(210, 210, 210)
                    };
                    table.AddCell(cell);
                }
            }

            document.Add(table);
            document.Add(new Paragraph("\n"));

            // Agregar fecha y hora del informe
            Paragraph date = new($"Informe generado el: {DateTime.Now}", fontBody)
            {
                Alignment = Element.ALIGN_RIGHT
            };
            document.Add(date);

            // Agregar firma de la empresa
            Paragraph firma = new("\n\nVial Control", fontFirma)
            {
                Alignment = Element.ALIGN_RIGHT
            };
            document.Add(firma);

            document.Close();
        }

        private List<InformeFila> CrearInforme()
        {
            List<InformeFila> informe = new();

            foreach (string nombreArchivo in _transferenciaSftp.GetArchivosAMover())
            {
                InformeFila fila = new()
                {
                    NombreDelArchivo = nombreArchivo
                };
                if (listBox1.Items.Contains(nombreArchivo))
                {
                    fila.Estado = "Transferido correctamente";
                    fila.FechaYHoraDeSubida = _subidaArchivo[nombreArchivo].ToString();
                }
                else
                {
                    fila.Estado = "No transferido";
                    fila.FechaYHoraDeSubida = "";  // Vacío para los archivos no transferidos
                }
                informe.Add(fila);
            }

            return informe;
        }

        private void ExportarInformeJson(string ruta)
        {
            List<InformeFila> informe = CrearInforme();
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(informe, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(Path.Combine(ruta, "Informe.json"), json);
        }

        private void ExportarInformeCsv(string ruta)
        {
            List<InformeFila> informe = CrearInforme();
            using (var writer = new StreamWriter(Path.Combine(ruta, "Informe.csv")))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(informe);
            }
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            string directorio = ObtenerDirectorioOrigen()!;
            if (directorio != null)
            {
                ExportarInforme(Path.Combine(directorio, "Informe.pdf"));
                MessageBox.Show("Informe exportado correctamente");
            }
        }

        private void btnExportJson_Click(object sender, EventArgs e)
        {
            string? rutaArchivo = ObtenerDirectorioOrigen();
            if (rutaArchivo != null)
            {
                ExportarInformeJson(rutaArchivo);
                MessageBox.Show("Informe exportado correctamente");
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            string? rutaArchivo = ObtenerDirectorioOrigen();
            if (rutaArchivo != null)
            {
                ExportarInformeCsv(rutaArchivo);
                MessageBox.Show("Informe exportado correctamente");
            }
        }

        private string? ObtenerDirectorioOrigen()
        {
            using (FolderBrowserDialog folderBrowserDialog = new())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    return folderBrowserDialog.SelectedPath;
                }
            }

            return null;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.IconSize = 80;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.IconSize = 70;
        }

        private void btnExportJson_MouseEnter(object sender, EventArgs e)
        {
            btnExportJson.IconSize = 48;
        }

        private void btnExportJson_MouseLeave(object sender, EventArgs e)
        {
            btnExportJson.IconSize = 40;
        }

        private void btnExportPdf_MouseEnter(object sender, EventArgs e)
        {
            btnExportPdf.IconSize = 48;
        }

        private void btnExportPdf_MouseLeave(object sender, EventArgs e)
        {
            btnExportPdf.IconSize = 40;
        }

        private void btnExportCsv_MouseEnter(object sender, EventArgs e)
        {
            btnExportCsv.IconSize = 48;
        }

        private void btnExportCsv_MouseLeave(object sender, EventArgs e)
        {
            btnExportCsv.IconSize = 40;
        }
    }
}
