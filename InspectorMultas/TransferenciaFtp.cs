using Newtonsoft.Json;
using WinSCP;

namespace InspectorMultas
{
    public class TransferenciaFtp
    {
        private SftpConfig _config;
        private const string RemotePath = "/sin_primitiva/test/";
        public static string ConfigFilePath { get; } = "appsettings.json";

        public TransferenciaFtp()
        {
            if (!File.Exists(ConfigFilePath))
            {
                SftpConfig defaultConfig = new SftpConfig()
                {
                    Protocol = Protocol.Sftp,
                    HostName = "da750eaf9bb4.sn.mynetname.net",
                    UserName = "srv04",
                    Password = "vialcontrol1",
                    PortNumber = 10022,
                    SshHostKeyFingerprint = "ssh-rsa 2048 isZ3ChcOljIL3Xn+WufO5yXBs0qSCwWQX/9BmpPEjFM"
                };
                SaveConfiguration(defaultConfig);
                _config = defaultConfig;
            }
            else
            {
                using (StreamReader file = File.OpenText(ConfigFilePath))
                {
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    var sftpConfig = (SftpConfig)serializer.Deserialize(file, typeof(SftpConfig))!;
                    _config = sftpConfig;
                }
            }
        }

        public void SaveConfiguration(SftpConfig sftpConfig)
        {
            string json = JsonConvert.SerializeObject(sftpConfig, Newtonsoft.Json.Formatting.Indented);

            using (StreamWriter sw = new StreamWriter(ConfigFilePath))
            {
                sw.Write(json);
            }

            _config = sftpConfig; // Update the current configuration
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
                transferResult = session.PutFiles(directorioOrigen + "\\*", RemotePath, false, transferOptions);

                // Verificar errores
                transferResult.Check();

                string logFilePath = directorioOrigen + "\\transferencias.txt";

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
