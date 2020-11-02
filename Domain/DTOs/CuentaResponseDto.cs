namespace Domain.DTOs
{
    public class CuentaResponseDto
    {
        public int Id { get; set; }
        public string correo { get; set; }
        public string password { get; set; }
        public int Rol { get; set; }
        public bool Estatus { get; set; }

        
    }
}