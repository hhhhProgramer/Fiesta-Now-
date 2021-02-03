
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
           
            Academia academy = await GetById(academia.Id);
            academia.CuentaID = academy.CuentaID;
            academia.cuenta = null;
            

            _unitOfWork.AcademiasRepository.Update(academia);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAcademy(int id)
        {
            await _unitOfWork.AcademiasRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task AddAcademia(Academia academia)
        {
            await _unitOfWork.AcademiasRepository.Add(academia);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<Academia> GetById(int id)
        {
            return await _unitOfWork.AcademiasRepository.GetById(id);
        }

    }
}