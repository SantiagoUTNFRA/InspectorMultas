namespace InspectorMultas.Logica
{
    public class ArchivoTransferidoEventArgs : EventArgs
    {
        public string FileName { get; }

        public ArchivoTransferidoEventArgs(string fileName)
        {
            FileName = fileName;
        }
    }

}
