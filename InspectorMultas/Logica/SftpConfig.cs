using WinSCP;

namespace InspectorMultas.Logica
{
    public class SftpConfig
    {
        public Protocol Protocol { get; set; }
        public string HostName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PortNumber { get; set; }
        public string SshHostKeyFingerprint { get; set; }
        public string RemotePath { get; set; }
        public string DirectorioOrigen { get; set; }
    }

}
