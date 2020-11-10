using System.Collections.Generic;
using System.Threading.Tasks;
using Entity;

namespace Domain.Interfaces
{
    public interface ICuentaServices
    {
         IEnumerable<Cuenta> GetCuentas(); 
         Task UpdateCuenta(Cuenta cuenta);
         Task AddCuenta(Cuenta cuenta);
    }
}