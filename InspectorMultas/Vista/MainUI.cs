using InspectorMultas.Logica;
using System.Net.NetworkInformation;

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
                MessageBox.Show("El archivo de configuración no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar la conexión a Internet
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("No hay conexión a Internet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}