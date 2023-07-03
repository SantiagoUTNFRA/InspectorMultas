using InspectorMultas.Logica;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
                _transferenciaSftp.TransferenciaProgreso += TransferenciaSftp_TransferenciaProgreso;

                _transferenciaSftp.ArchivoTransferido += (sender, e) =>
                {
                    Invoke((Action)(() =>
                    {
                        string nombreArchivo = Path.GetFileName(((ArchivoTransferidoEventArgs)e).FileName);
                        listBox1.Items.Add(nombreArchivo);
                        _subidaArchivo[nombreArchivo] = DateTime.Now;
                    }));
                };

                System.Threading.Tasks.Task.Run(() => _transferenciaSftp.RealizarTransferencia(_transferenciaSftp.GetDirectorioOrigen()));
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


        private void ExportarInforme()
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("Informe.pdf", FileMode.Create));
            document.Open();

            // Establecer la fuente
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fontTitle = new Font(baseFont, 20, iTextSharp.text.Font.BOLD);
            Font fontHeader = new Font(baseFont, 18, iTextSharp.text.Font.NORMAL, new BaseColor(20, 25, 25));
            Font fontBody = new Font(baseFont, 16, iTextSharp.text.Font.NORMAL);
            Font fontFirma = new Font(baseFont, 18, iTextSharp.text.Font.NORMAL, new BaseColor(20, 25, 25));

            // Título del documento
            Paragraph title = new Paragraph("Vial Control - Informe de transferencias de archivos", fontTitle);
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            // Agregar espacio después del título
            document.Add(new Paragraph("\n"));

            PdfPTable table = new PdfPTable(3);  // Crea una tabla con 3 columnas

            // Agregar encabezados de las columnas
            PdfPCell cell = new PdfPCell(new Phrase("Nombre del archivo", fontHeader));
            cell.BackgroundColor = new BaseColor(210, 210, 210);
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Estado", fontHeader));
            cell.BackgroundColor = new BaseColor(210, 210, 210);
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Fecha y Hora de Subida", fontHeader));
            cell.BackgroundColor = new BaseColor(210, 210, 210);
            table.AddCell(cell);

            // Itera a través de los archivos a mover
            foreach (string nombreArchivo in _transferenciaSftp.GetArchivosAMover())
            {
                table.AddCell(new Phrase(nombreArchivo, fontBody));

                // Comprueba si el archivo ha sido transferido correctamente
                if (listBox1.Items.Contains(nombreArchivo))
                {
                    cell = new PdfPCell(new Phrase("Transferido correctamente", fontBody));
                    //cell.BackgroundColor = new BaseColor(210, 210, 210);
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase(_subidaArchivo[nombreArchivo].ToString(), fontBody));
                    //cell.BackgroundColor = new BaseColor(210, 210, 210);
                    table.AddCell(cell);
                }
                else
                {
                    cell = new PdfPCell(new Phrase("No transferido", fontBody));
                    cell.BackgroundColor = new BaseColor(255, 102, 102);  // Color de fondo rojo claro para destacar el error
                    table.AddCell(cell);

                    cell = new PdfPCell();  // Agrega una celda vacía ya que no hay fecha y hora de subida para los archivos no transferidos
                    cell.BackgroundColor = new BaseColor(210, 210, 210);
                    table.AddCell(cell);
                }
            }

            document.Add(table);  // Agrega la tabla al documento

            // Agregar espacio después de la tabla
            document.Add(new Paragraph("\n"));

            // Agregar fecha y hora del informe
            Paragraph date = new Paragraph($"Informe generado el: {DateTime.Now.ToString()}", fontBody);
            date.Alignment = Element.ALIGN_RIGHT;
            document.Add(date);

            // Agregar firma de la empresa
            Paragraph firma = new Paragraph("\n\nVial Control", fontFirma);
            firma.Alignment = Element.ALIGN_RIGHT;
            document.Add(firma);

            document.Close();
        }


        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            ExportarInforme();
            MessageBox.Show("Informe exportado correctamente");
        }
    }
}
