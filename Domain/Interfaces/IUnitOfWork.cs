using System;
using System.Threading.Tasks;
using Entity;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IRepository<Academia> AcademiasRepository { get; }
        public IRepository<Clase_Suscripciones> ClasesSuscripcionesRepository { get; }
        public IRepository<Clase> ClaseRepository { get; }
        public IRepository<CodigoBaile> CodigoBailesRepository { get; }
        public IRepository<Cuenta> CuentasRepository { get; }
        public IRepository<Estudiante> EstudiantesRepository { get; }
        public IRepository<Horario> HorariosRepository { get; }
        public IRepository<Suscripcion> SuscripcionesRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}