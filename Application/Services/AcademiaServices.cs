
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Entity;
using Infrestructure.Repositories;

namespace Application.Services
{
    public class AcademiaServices : IAcademiaServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public AcademiaServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<Academia> GetAcademias()
        {
            return _unitOfWork.AcademiasRepository.GetAll();
        }

        public async Task UpdateAcademia(Academia academia)
        {
            _unitOfWork.AcademiasRepository.Update(academia);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task AddAnimal(Academia academia)
        {
            await _unitOfWork.AcademiasRepository.Add(academia);
        }

        public async Task DeleteAnimal(int id)
        {
            await _unitOfWork.AcademiasRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}