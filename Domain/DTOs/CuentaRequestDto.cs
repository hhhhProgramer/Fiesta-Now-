namespace  Domain.DTOs
{
    public class CuentaRequestDto
    {
        
        public string correo { get; set; }
        public string password { get; set; }
        public int Rol { get; set; }
        public bool Estatus { get; set; }
    }
}