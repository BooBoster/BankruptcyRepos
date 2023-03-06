using BankruptcyTask.Domain;
using BankruptcyTask.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptcyTask.DAL.Interfaces
{
    public interface IDebtorRepository : IBaseRepository<Debtor>
    {
        Task<Debtor> GetByName(string name, string surname);
    }
}
