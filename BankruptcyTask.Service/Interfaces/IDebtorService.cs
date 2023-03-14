using BankruptcyTask.Domain.Response;
using BankruptcyTask.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankruptcyTask.Domain.Entity;
using BankruptcyTask.Models.ViewModel;

namespace BankruptcyTask.Service.Interfaces
{
    public interface IDebtorService
    {
        Task<BaseResponse<IEnumerable<Debtor>>> GetDebtors();
        Task<BaseResponse<Debtor>> GetDebtor(int id);
        Task<BaseResponse<Debtor>> GetDebtor(string name,string surname);
        Task<BaseResponse<bool>> DeleteDebtor(int id);
        Task<BaseResponse<Debtor>> AddEstate(int DebtorId, Estate estate);
        Task<BaseResponse<bool>> Create(DebtorViewModel debtorViewModel);
        Task<BaseResponse<Debtor>> Edit(int id, DebtorViewModel debtorViewModel);
    }
}
