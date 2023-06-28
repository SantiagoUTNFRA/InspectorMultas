namespace InspectorMultas
{
    public partial class MainUI : Form
    {
        private readonly TransferenciaFtp _transferenciaFtp;
        private static MainUI _instance = null!;

        public MainUI()
        {
            InitializeComponent();
            _transferenciaFtp = new TransferenciaFtp();
        }

        public static MainUI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainUI();
                }

                return _instance;
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConfigUI.Instance.Show();
        }

        private void btnStartTransfer_Click(object sender, EventArgs e)
        {
            if (!VerificarConfiguracion())
            {
                return;
            }

            try
            {
                lblEstadoTransferencia.Text = "Transferencia iniciada";

                string directorioOrigen = ObtenerDirectorioOrigen();

                if (string.IsNullOrEmpty(directorioOrigen))
                {
                    lblEstadoTransferencia.Text = "Ningún directorio seleccionado. Transferencia cancelada.";
                    return;
                }

                _transferenciaFtp.RealizarTransferencia(directorioOrigen);

                lblEstadoTransferencia.Text = "Transferencia finalizada";
            }
            catch (Exception ex)
            {
                lblTitulo.Text = "Transferencia con error";

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerDirectorioOrigen()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    return folderBrowserDialog.SelectedPath;
                }
            }

            return null!;
        }

        private bool VerificarConfiguracion()
        {
            if (!File.Exists(TransferenciaFtp.ConfigFilePath))
            {
                MessageBox.Show("El archivo de configuración no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar la conexión a Internet
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("No hay conexión a Internet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}