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
        private string directorioTrabajoSeleccionado;
        private TransferSftp _transferSftp;

        private ConfigUI()
        {
            InitializeComponent();
            _transferSftp = new TransferSftp();
            LoadConfigToUI();
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
                DirectorioOrigen = directorioOrigenSeleccionado,
                DirectorioTrabajo = directorioTrabajoSeleccionado
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

        private void LoadConfigToUI()
        {
            SftpConfig config = _transferSftp.LoadConfig();

            txtHostName.Text = config.HostName;
            txtUserName.Text = config.UserName;
            password = config.Password;
            txtPortNumber.Text = config.PortNumber.ToString();
            sshHostKeyFingerPrint = config.SshHostKeyFingerprint;
            txtRemotePath.Text = config.RemotePath;
            directorioOrigenSeleccionado = config.DirectorioOrigen;
            txtSourcePath.Text = config.DirectorioOrigen;
            txtWorkDirectory.Text = config.DirectorioTrabajo;
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            directorioOrigenSeleccionado = ObtenerDirectorioOrigen();

            if (directorioOrigenSeleccionado != null)
            {
                txtSourcePath.Text = directorioOrigenSeleccionado;
            }
        }

        private void btnWorkDirectory_Click(object sender, EventArgs e)
        {
            directorioTrabajoSeleccionado = ObtenerDirectorioOrigen();

            if (directorioTrabajoSeleccionado != null)
            {
                txtWorkDirectory.Text = directorioTrabajoSeleccionado;
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

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.IconSize = 80;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.IconSize = 70;
        }

        private void btnSaveChanges_MouseEnter(object sender, EventArgs e)
        {
            btnSaveChanges.IconSize = 95;
        }

        private void btnSaveChanges_MouseLeave(object sender, EventArgs e)
        {
            btnSaveChanges.IconSize = 85;
        }

        private void btnSourceFolder_MouseEnter(object sender, EventArgs e)
        {
            btnSourceFolder.IconSize = 30;
        }

        private void btnSourceFolder_MouseLeave(object sender, EventArgs e)
        {
            btnSourceFolder.IconSize = 25;
        }

        
    }
}
