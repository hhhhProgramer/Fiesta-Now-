using System.Collections.Generic;
using Entity;

namespace Domain.DTOs
{
    public class ClaseResponseDto
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public int AlumnosMax { get; set; }
        public int CodigoBaileID { get; set; }
        public int AcademiaId { get; set; }
        public string Horarios { get; set; }
    }
}