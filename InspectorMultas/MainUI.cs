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
            
        private bool VerificarConfiguracion()
        {
            // Verificar que el archivo de configuración existe
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

            // Otras verificaciones aquí...

            return true;
        }

    }
}