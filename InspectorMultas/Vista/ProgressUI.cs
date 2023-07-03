using InspectorMultas.Logica;

namespace InspectorMultas
{
    public partial class ProgressUI : Form
    {
        private readonly TransferSftp _transferenciaSftp;
        private static ProgressUI _instance = null!;

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

    }
}
