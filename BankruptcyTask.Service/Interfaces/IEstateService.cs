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
        Task<BaseResponse<Estate>> GetEstate(int id);
        Task<BaseResponse<IEnumerable<Estate>>> GetByDebtor(int id);
        Task<BaseResponse<bool>> DeleteEstate(int id);
        Task<BaseResponse<bool>> Create(EstateCreateDto estateCreateDto);
        Task<BaseResponse<Estate>> Edit(int id, EstateCreateDto estateCreateDto);
    }
}
