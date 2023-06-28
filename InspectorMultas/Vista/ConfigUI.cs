using InspectorMultas.Logica;
using WinSCP;

namespace InspectorMultas
{
    public partial class ConfigUI : Form
    {
        private string sshHostKeyFingerPrint = "ssh-rsa 2048 isZ3ChcOljIL3Xn+WufO5yXBs0qSCwWQX/9BmpPEjFM";
        private static ConfigUI _instance = null!;

        private ConfigUI()
        {
            InitializeComponent();
        }

        public static ConfigUI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigUI();
                }

                return _instance;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            SftpConfig sftpConfig = new()
            {
                Protocol = Protocol.Sftp,
                HostName = txtHostName.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                PortNumber = int.Parse(txtPortNumber.Text),
                SshHostKeyFingerprint = sshHostKeyFingerPrint,
                RemotePath = "/sin_primitiva/test/"
            };

            TransferenciaFtp transferenciaFtp = new TransferenciaFtp();
            transferenciaFtp.SaveConfiguration(sftpConfig);

            this.Close();
            MainUI mainUI = new();
            mainUI.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUI.Instance.Show();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtHostName.Text) || string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtPortNumber.Text) ||
                string.IsNullOrWhiteSpace(sshHostKeyFingerPrint))
            {
                MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validación del número de puerto
            if (!int.TryParse(txtPortNumber.Text, out int port))
            {
                MessageBox.Show("El número de puerto no es válido. Por favor, ingrese un número entero válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
