using BankruptcyTask.Domain;
using BankruptcyTask.Domain.Response;
using BankruptcyTask.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptcyTask.Service.Interfaces
{
    public interface IEstateService
    {
        Task<BaseResponse<IEnumerable<Estate>>> GetEstates();
        Task<BaseResponse<Estate>> GetById(int id);
        Task<BaseResponse<Estate>> GetByName(string name);
        Task<BaseResponse<IEnumerable<Estate>>> GetByDebtor(int id);
        Task<BaseResponse<bool>> DeleteEstate(int id);
        Task<BaseResponse<bool>> Create(EstateViewModel estateViewModel);
        Task<BaseResponse<bool>> Edit(int id, EstateViewModel estateViewModel);
    }
}
