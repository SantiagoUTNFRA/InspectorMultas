namespace InspectorMultas.Logica
{
    public class TransferenciaProgresoEventArgs : EventArgs
    {
        public int Porcentaje { get; }
        public string NombreArchivo { get; }

        public TransferenciaProgresoEventArgs(int porcentaje, string nombreArchivo)
        {
            Porcentaje = porcentaje;
            NombreArchivo = nombreArchivo;
        }
    }
}
