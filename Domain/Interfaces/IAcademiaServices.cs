using System.Collections.Generic;
using System.Threading.Tasks;
using Entity;

namespace Domain.Interfaces
{
    public interface IAcademiaServices
    {
         IEnumerable<Academia> GetAcademias(); 
         Task UpdateAcademia(Academia academia);
    }
}