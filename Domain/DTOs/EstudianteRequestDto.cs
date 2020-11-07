namespace  Domain.DTOs
{

    public class EstudianteRequestDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
        public int CuentaID { get; set; }
    }    
}