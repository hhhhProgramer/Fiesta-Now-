using System;

namespace Domain.DTOs
{
    public class HorarioRequestDto
    {
        public DateTime Apertura { get; set; }
        public DateTime Cierre { get; set; }
        public string Dia { get; set; }
        public int ClaseId { get; set; }
    }
}