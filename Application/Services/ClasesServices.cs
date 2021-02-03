using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Entity;

namespace Application.Services
{
    public class ClasesServices : IClaseServices
    {
        private readonly IUnitOfWork _unitOfWork;
<<<<<<< HEAD
        
=======
>>>>>>> 41a9133... add server dbstring
        public ClasesServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task AddClase(Clase horario)
        {
            await _unitOfWork.ClaseRepository.Add(horario);
            await _unitOfWork.SaveChangesAsync();
        }

        public IEnumerable<Clase> GetClases()
        {
            return _unitOfWork.ClaseRepository.GetAll();
        }

        public async Task UpdateClase(Clase horario)
        {
            _unitOfWork.ClaseRepository.Update(horario);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteClase(int id)
        {
            await _unitOfWork.AcademiasRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}