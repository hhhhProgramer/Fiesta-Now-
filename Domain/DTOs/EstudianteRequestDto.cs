namespace  Domain.DTOs
{

    public class EstudianteRequestDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public int Rol { get; set; }
    
    }    
}