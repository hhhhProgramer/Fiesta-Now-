using Entity;

namespace Domain.Entities
{
    public class CodigoBaile_Academia : BaseEntity
    {
        public int CodigoBaileId { get; set; }
        public  CodigoBaile CodigoBaile { get; set; }
        public int AcademiaId { get; set; }
        public Academia Academia { get; set; }
    }
}