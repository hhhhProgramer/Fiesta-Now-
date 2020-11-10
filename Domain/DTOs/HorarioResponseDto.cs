using System;

namespace Domain.DTOs
{
    public class HorarioResponseDto
    {
        public int Id { get; set; }
        public string Apertura { get; set; }
        public string Cierre { get; set; }
        public string Dia { get; set; }
    }
}