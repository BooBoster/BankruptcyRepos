using BankruptcyTask.Domain;
using BankruptcyTask.Domain.Response;
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
    }
}
