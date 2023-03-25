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
        //возможно что-то понадобится конкретно для Debtor
    }
}
