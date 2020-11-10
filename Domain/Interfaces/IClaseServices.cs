using System.Collections.Generic;
using System.Threading.Tasks;
using Entity;

namespace Domain.Interfaces
{
    public interface IClaseServices
    {
        IEnumerable<Clase> GetClases(); 
        Task UpdateClase(Clase horario);
        Task AddClase(Clase horario);
        Task DeleteClase(int id);
    }
}