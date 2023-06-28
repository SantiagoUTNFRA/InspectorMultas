namespace InspectorMultas
{
    public partial class MainUI : Form
    {
        private readonly TransferenciaFtp _transferenciaFtp;

        public MainUI()
        {
            InitializeComponent();
            _transferenciaFtp = new TransferenciaFtp();
        }

        private void Form1_Load(object sender, EventArgs e) { }

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

        private void btnConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConfigUI configUI = new ConfigUI();
            configUI.Show();
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

                // Verifica que directorioOrigen no sea nulo antes de proceder
                if (string.IsNullOrEmpty(directorioOrigen))
                {
                    lblEstadoTransferencia.Text = "Ning�n directorio seleccionado. Transferencia cancelada.";
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
            
        private bool VerificarConfiguracion()
        {
            // Verificar que el archivo de configuraci�n existe
            if (!File.Exists(TransferenciaFtp.ConfigFilePath))
            {
                MessageBox.Show("El archivo de configuraci�n no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar la conexi�n a Internet
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("No hay conexi�n a Internet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Otras verificaciones aqu�...

            return true;
        }

    }
}