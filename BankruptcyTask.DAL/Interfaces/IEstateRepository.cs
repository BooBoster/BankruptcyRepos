using BankruptcyTask.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptcyTask.DAL.Interfaces
{
    public interface IEstateRepository: IBaseRepository<Estate>
    {
        Task<Estate> GetByName(string name);
        Task<IEnumerable<Estate>> GetByDebtor(int debtorId);

    }
}
