using System.Collections.Generic;
using Entity;

namespace Domain.DTOs
{
    public class ClaseRequestDto
    {
        public string Nombre { get; set; }
        public int AlumnosMax { get; set; }
        public int CodigoBaileID { get; set; }
        public int AcademiaId { get; set; }
        public ICollection<Horario> Horarios { get; set; }
    }
}