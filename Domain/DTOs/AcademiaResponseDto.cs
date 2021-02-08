namespace Domain.DTOs
{
    public class AcademiaResponseDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Numero { get; set; }
        public string Descripcion { get; set; }
        public string Direction { get; set; }
        public double Longitud { get; set; }
        public double Latitud { get; set; }
        public string Logo { get; set; }
        public int CuentaID { get; set; }
    }
}