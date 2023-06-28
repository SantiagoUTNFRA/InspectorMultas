using Newtonsoft.Json;
using WinSCP;

namespace InspectorMultas.Logica
{
    public class TransferenciaFtp
    {
        public static string ConfigFilePath { get; } = "appsettings.json";
        private SftpConfig _config;
        private const string RemotePath = "/sin_primitiva/test/";

        public TransferenciaFtp()
        {
            if (!File.Exists(ConfigFilePath))
            {
                SftpConfig defaultConfig = new()
                {
                    Protocol = Protocol.Sftp,
                    HostName = "da750eaf9bb4.sn.mynetname.net",
                    UserName = "srv04",
                    Password = "vialcontrol1",
                    PortNumber = 10022,
                    SshHostKeyFingerprint = "ssh-rsa 2048 isZ3ChcOljIL3Xn+WufO5yXBs0qSCwWQX/9BmpPEjFM",
                    RemotePath = "/sin_primitiva/test/"
                };
                SaveConfiguration(defaultConfig);
                _config = defaultConfig;
            }
            else
            {
                using (StreamReader file = File.OpenText(ConfigFilePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    var sftpConfig = (SftpConfig)serializer.Deserialize(file, typeof(SftpConfig))!;
                    _config = sftpConfig;
                }
            }
        }

        public void SaveConfiguration(SftpConfig sftpConfig)
        {
            string json = JsonConvert.SerializeObject(sftpConfig, Formatting.Indented);

            using (StreamWriter sw = new(ConfigFilePath))
            {
                sw.Write(json);
            }

            _config = sftpConfig;
        }

        public void RealizarTransferencia(string directorioOrigen)
        {
            SessionOptions sessionOptions = new()
            {
                Protocol = _config.Protocol,
                HostName = _config.HostName,
                UserName = _config.UserName,
                Password = _config.Password,
                PortNumber = _config.PortNumber,
                SshHostKeyFingerprint = _config.SshHostKeyFingerprint
            };

            using (Session session = new())
            {
                session.Open(sessionOptions);

                // Enviar los archivos
                TransferOptions transferOptions = new()
                {
                    TransferMode = TransferMode.Binary
                };

                TransferOperationResult transferResult;
                transferResult = session.PutFiles(Path.Combine(directorioOrigen, "*"), RemotePath, false, transferOptions);

                // Verificar errores
                transferResult.Check();

                string logFilePath = Path.Combine(directorioOrigen, "transferencias.txt");

                // Mostrar resultados
                using (StreamWriter streamWriter = new(logFilePath, true))
                {
                    foreach (TransferEventArgs transfer in transferResult.Transfers)
                    {
                        if (transfer.Error == null)
                        {
                            string logMessage = $"Correcto: {transfer.FileName}";
                            streamWriter.WriteLine(logMessage);
                        }
                        else
                        {
                            string logMessage = $"Error al enviar el archivo {transfer.FileName}: {transfer.Error.Message}";
                            streamWriter.WriteLine(logMessage);
                        }
                    }
                }
            }
        }



    }
}
