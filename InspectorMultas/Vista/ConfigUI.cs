using InspectorMultas.Logica;
using WinSCP;

namespace InspectorMultas
{
    public partial class ConfigUI : Form
    {
        private string sshHostKeyFingerPrint = "ssh-rsa 2048 isZ3ChcOljIL3Xn+WufO5yXBs0qSCwWQX/9BmpPEjFM";
        private string password = "vialcontrol1";
        private static ConfigUI _instance = null!;
        private string directorioOrigenSeleccionado;

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
                Password = password,
                PortNumber = int.Parse(txtPortNumber.Text),
                SshHostKeyFingerprint = sshHostKeyFingerPrint,
                RemotePath = txtRemotePath.Text,
                DirectorioOrigen = directorioOrigenSeleccionado
            };

            TransferSftp transferenciaFtp = new();
            transferenciaFtp.SaveConfiguration(sftpConfig);

            this.Hide();
            MainUI.Instance.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUI.Instance.Show();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtHostName.Text) || string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtSourcePath.Text) || string.IsNullOrWhiteSpace(txtPortNumber.Text) ||
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

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            directorioOrigenSeleccionado = ObtenerDirectorioOrigen();

            if (directorioOrigenSeleccionado != null)
            {
                txtSourcePath.Text = directorioOrigenSeleccionado;
            }
        }


        private string ObtenerDirectorioOrigen()
        {
            using (FolderBrowserDialog folderBrowserDialog = new())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    return folderBrowserDialog.SelectedPath;
                }
            }

            return null!;
        }
    }
}
