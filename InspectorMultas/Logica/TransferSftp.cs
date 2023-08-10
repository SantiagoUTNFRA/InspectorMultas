using Newtonsoft.Json;
using WinSCP;
using System.Text.RegularExpressions;


namespace InspectorMultas.Logica
{
    public class TransferSftp
    {
        public static string ConfigFilePath { get; } = "appsettings.json";
        private SftpConfig _config;
        private const string RemotePath = "/sin_primitiva/test/";
        public event EventHandler<TransferenciaProgresoEventArgs> TransferenciaProgreso;
        public event EventHandler<ArchivoTransferidoEventArgs> ArchivoTransferido;

        public TransferSftp()
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
                    RemotePath = "",
                    DirectorioOrigen = "",
                    DirectorioTrabajo = ""
                };
                SaveConfiguration(defaultConfig);
                _config = defaultConfig;
            }
            else
            {
                LoadConfig();
            }
        }

        public SftpConfig LoadConfig()
        {
            using (StreamReader file = File.OpenText(ConfigFilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                var sftpConfig = (SftpConfig)serializer.Deserialize(file, typeof(SftpConfig))!;
                _config = sftpConfig;
                return _config;
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
                session.FileTransferProgress += Session_FileTransferProgress;

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
                Directory.CreateDirectory(directorioOrigen);

                // Crea el archivo si no existe
                if (!File.Exists(logFilePath))
                {
                    File.Create(logFilePath).Dispose();
                }

                try
                {
                    // Mostrar resultados
                    using (StreamWriter streamWriter = new(logFilePath, true))
                    {
                        int i = 0;
                        foreach (TransferEventArgs transfer in transferResult.Transfers)
                        {
                            if (transfer.Error == null)
                            {
                                string logMessage = $"Correcto: {transfer.FileName}";
                                streamWriter.WriteLine(logMessage);

                                // Disparar el evento
                                ArchivoTransferido?.Invoke(this, new ArchivoTransferidoEventArgs(transfer.FileName));
                            }

                            else
                            {
                                string logMessage = $"Error al enviar el archivo {transfer.FileName}: {transfer.Error.Message}";
                                streamWriter.WriteLine(logMessage);
                            }

                            // Notificar el progreso
                            int porcentaje = (i + 1) * 100 / transferResult.Transfers.Count;
                            OnTransferenciaProgreso(porcentaje, transfer.FileName);
                            i++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al escribir el archivo de log: {ex.Message}");
                }
            }
        }

        private void Session_FileTransferProgress(object sender, FileTransferProgressEventArgs e)
        {
            // Calcular el porcentaje de progreso basado en la cantidad de bytes transferidos
            int porcentaje = Convert.ToInt32(e.OverallProgress * 100);

            // Invocar el evento de progreso de la transferencia
            OnTransferenciaProgreso(porcentaje, e.FileName);
        }

        // Método auxiliar para invocar el evento de progreso de la transferencia
        private void OnTransferenciaProgreso(int porcentaje, string nombreArchivo)
        {
            TransferenciaProgreso?.Invoke(this, new TransferenciaProgresoEventArgs(porcentaje, nombreArchivo));
        }

        public string GetDirectorioOrigen()
        {
            return _config.DirectorioOrigen;
        }

        public List<string> GetArchivosAMover()
        {
            string directorioOrigen = _config.DirectorioOrigen;
            List<string> archivosAMover = Directory.GetFiles(directorioOrigen).ToList();

            // Selecciona solo el nombre de los archivos
            for (int i = 0; i < archivosAMover.Count; i++)
            {
                archivosAMover[i] = Path.GetFileName(archivosAMover[i]);
            }

            return archivosAMover;
        }

        public void ProcessFilesInWorkDirectory(string sourceDirectory, string workDirectory)
        {
            var files = Directory.GetFiles(sourceDirectory);

            foreach (var file in files)
            {
                // Check if it's a MP4
                if (Path.GetExtension(file) == ".mp4")
                {
                    // Split the original filename into its components
                    var oldFilenameComponents = Path.GetFileNameWithoutExtension(file).Split('_');

                    // Get the numeric part from the first component
                    string oldId = Regex.Match(oldFilenameComponents[0], @"\d+").Value;

                    // Convert the old ID to the new format
                    string newId;
                    try
                    {
                        newId = ConvertId(int.Parse(oldId));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Error: Unable to convert ID '{oldId}' to an integer.");
                        continue;  // Skip this file
                    }

                    // Form the new filename
                    var newFilename = $"{newId}_{oldFilenameComponents[3]}_A_T000.mp4";
                    var destinationFile = Path.Combine(workDirectory, newFilename);

                    // Copy the file to the working directory
                    File.Copy(file, destinationFile)    ;
                }
            }
        }

        string ConvertId(int id)
        {
            const string base36Chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            id = id - 1;

            int firstDigit = id / 36;
            int secondDigit = id % 36;

            return "X" + base36Chars[firstDigit] + base36Chars[secondDigit];
        }
    }
}
