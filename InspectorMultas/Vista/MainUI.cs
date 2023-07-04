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
                MessageBox.Show("El archivo de configuraci�n no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Cargar configuraci�n
            SftpConfig config = LoadConfig();

            // Verificar que los valores de configuraci�n no sean nulos o vac�os
            if (string.IsNullOrWhiteSpace(config.HostName) || string.IsNullOrWhiteSpace(config.UserName) ||
                string.IsNullOrWhiteSpace(config.Password) || string.IsNullOrWhiteSpace(config.SshHostKeyFingerprint) ||
                string.IsNullOrWhiteSpace(config.RemotePath) || string.IsNullOrWhiteSpace(config.DirectorioOrigen))
            {
                MessageBox.Show("Hay valores de configuraci�n que est�n vac�os. Por favor, complete todos los campos en la configuraci�n.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar la conexi�n a Internet
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("No hay conexi�n a Internet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar la conectividad al servidor SFTP
            if (!VerificarConectividadSftp(config))
            {
                return false;
            }

            // Todo est� correcto
            return true;
        }


        private bool VerificarConectividadSftp(SftpConfig config)
        {
            try
            {
                // Configurar las opciones de la sesi�n
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
                    // Intentar abrir una sesi�n
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


        private SftpConfig LoadConfig()
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