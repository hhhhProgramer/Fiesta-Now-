using System.Collections.Generic;
using System.Threading.Tasks;
using Entity;

namespace Domain.Interfaces{

    public interface IEstudianteServices
    {
        IEnumerable<Estudiante> GetEstudiantes();
        Task UpdateEstudiante(Estudiante estudiante);
        Task AddEstudiante(Estudiante estudiante);
        Task DeleteEstudiante(int id);
        Task<Estudiante> GetById(int id);
    }
}