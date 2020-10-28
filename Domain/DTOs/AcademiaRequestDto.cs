namespace Domain.DTOs
{
    public class AcademiaRequestDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Numero { get; set; }
        public string Descripcion { get; set; }
        public int Longitud { get; set; }
        public int Latitud { get; set; }
        public string Logo { get; set; }

        public int CuentaID { get; set; }
    }
}