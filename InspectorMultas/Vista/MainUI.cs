using InspectorMultas.Logica;
using Newtonsoft.Json;
using System.Net.NetworkInformation;
using WinSCP;

namespace InspectorMultas
{
    public partial class MainUI : Form
    {
        private static MainUI _instance = null!;

        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            btnFileConfig.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            btnConfigOk.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            btnInternetConnection.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            btnSftpConnection.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
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
            else
            {
                // Cargar configuración
                SftpConfig config = LoadConfig();

                // Procesa los archivos en el directorio de origen, los copia al directorio de trabajo y cambia sus nombres
                TransferSftp transferenciaFtp = new();
                transferenciaFtp.ProcessFilesInWorkDirectory(config.DirectorioOrigen ,config.DirectorioTrabajo);

                lblTitulo.Text = "Transferencia en progreso";
                this.Hide();
                ProgressUI.Instance.ResetUI(); // Restablecer la interfaz de usuario
                ProgressUI.Instance.Show();
            }
        }

        private bool VerificarConfiguracion()
        {
            if (!File.Exists(TransferSftp.ConfigFilePath))
            {
                btnFileConfig.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                MessageBox.Show("El archivo de configuración no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Cargar configuración
            SftpConfig config = LoadConfig();

            // Verificar que los valores de configuración no sean nulos o vacíos
            if (string.IsNullOrWhiteSpace(config.HostName) || string.IsNullOrWhiteSpace(config.UserName) ||
                string.IsNullOrWhiteSpace(config.Password) || string.IsNullOrWhiteSpace(config.SshHostKeyFingerprint) ||
                string.IsNullOrWhiteSpace(config.RemotePath) || string.IsNullOrWhiteSpace(config.DirectorioOrigen))
            {
                btnConfigOk.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                MessageBox.Show("Hay valores de configuración que están vacíos. Por favor, complete todos los campos en la configuración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar la conexión a Internet
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                btnInternetConnection.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                MessageBox.Show("No hay conexión a Internet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            // Verificar la conectividad al servidor SFTP
            if (!VerificarConectividadSftp(config))
            {
                btnSftpConnection.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                return false;
            }

            // Todo está correcto
            btnFileConfig.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnConfigOk.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnInternetConnection.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnSftpConnection.IconChar = FontAwesome.Sharp.IconChar.Check;

            return true;
        }

        private bool VerificarConectividadSftp(SftpConfig config)
        {
            try
            {
                // Configurar las opciones de la sesión
                SessionOptions sessionOptions = new()
                {
                    Protocol = config.Protocol,
                    HostName = config.HostName,
                    UserName = config.UserName,
                    Password = config.Password,
                    PortNumber = config.PortNumber,
                    SshHostKeyFingerprint = config.SshHostKeyFingerprint
                };

                using (Session session = new())
                {
                    // Intentar abrir una sesión
                    session.Open(sessionOptions);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar al servidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public SftpConfig LoadConfig()
        {
            using (StreamReader file = File.OpenText(TransferSftp.ConfigFilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (SftpConfig)serializer.Deserialize(file, typeof(SftpConfig))!;
            }
        }


        private void btnStartTransfer_MouseEnter(object sender, EventArgs e)
        {
            btnStartTransfer.IconSize = 95;
        }

        private void btnStartTransfer_MouseLeave(object sender, EventArgs e)
        {
            btnStartTransfer.IconSize = 85;

        }

        private void btnConfig_MouseEnter(object sender, EventArgs e)
        {
            btnConfig.IconSize = 80;
        }

        private void btnConfig_MouseLeave(object sender, EventArgs e)
        {
            btnConfig.IconSize = 70;

        }


    }
}