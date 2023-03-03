using BankruptcyTask.DAL.Interfaces;
using BankruptcyTask.Domain;
using BankruptcyTask.Domain.Entity;
using BankruptcyTask.Domain.Enum;
using BankruptcyTask.Domain.Response;
using BankruptcyTask.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptcyTask.Service.Implemetations
{
    public class EstateService : IEstateService
    {
        private readonly IEstateRepository _estateRepository;
        public EstateService(IEstateRepository estateRepository) 
        {
            _estateRepository = estateRepository;
        }
        public async Task<BaseResponse<IEnumerable<Estate>>> GetEstates()
        {
            try
            {
                var estates = await _estateRepository.GetAll();
                if(estates.Count() == 0 ) 
                {
                    return new BaseResponse<IEnumerable<Estate>>()
                    {
                        Description = "Найдено 0 элементов",
                        StatusCode = StatusCode.Success,
                        Data = estates
                    };
                }
                return new BaseResponse<IEnumerable<Estate>>()
                {
                    StatusCode = StatusCode.Success,
                    Data = estates
                };
            }
            catch (Exception ex) 
            {
                return new BaseResponse<IEnumerable<Estate>>()
                {
                    Description = $"[GetEstates] : {ex.Message}",
                    StatusCode = StatusCode.IternalServerEror                 
                };
            }
        }
        public async Task<BaseResponse<Estate>> GetById(int id)
        {
            try
            {
                var estate = await _estateRepository.GetById(id);
                if(estate == null)
                {
                    return new BaseResponse<Estate>()
                    {
                        Description = "Элемент не найден",
                        StatusCode = StatusCode.EstateNotFound
                    };
                }
                return new BaseResponse<Estate>()
                {                    
                    StatusCode = StatusCode.Success,
                    Data = estate
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Estate>()
                {
                    Description = $"[GetById] : {ex.Message}",
                    StatusCode = StatusCode.IternalServerEror
                };
            }
        }
        public async Task<BaseResponse<Estate>> GetByName(string name)
        {
            try
            {
                var estate = await _estateRepository.GetByName(name);
                if (estate == null)
                {
                    return new BaseResponse<Estate>()
                    {
                        Description = "Элемент не найден",
                        StatusCode = StatusCode.EstateNotFound
                    };
                }
                return new BaseResponse<Estate>()
                {
                    StatusCode = StatusCode.Success,
                    Data = estate
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Estate>()
                {
                    Description = $"[GetByName] : {ex.Message}",
                    StatusCode = StatusCode.IternalServerEror
                };
            }
        }
        public async Task<BaseResponse<IEnumerable<Estate>>> GetByDebtor(int id)
        {
            try
            {
                var estates = await _estateRepository.GetByDebtor(id);
                if (estates.Count() == 0)
                {
                    return new BaseResponse<IEnumerable<Estate>>()
                    {
                        Description = "Найдено 0 элементов",
                        StatusCode = StatusCode.EstateNotFound
                    };
                }
                return new BaseResponse<IEnumerable<Estate>>()
                {
                    StatusCode = StatusCode.Success,
                    Data = estates
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Estate>>()
                {
                    Description = $"[GetByDebtor] : {ex.Message}",
                    StatusCode = StatusCode.IternalServerEror
                };
            }
        }
        public async Task<BaseResponse<bool>> DeleteEstate(int id)
        {
            try
            {
                var estate = await _estateRepository.GetById(id);
                if (estate == null)
                {
                    return new BaseResponse<bool>()
                    {
                        Description = "Элемент не найден",
                        StatusCode = StatusCode.EstateNotFound,
                        Data = false
                    };
                }
                var result = await _estateRepository.Delete(estate);
                return new BaseResponse<bool>()
                {
                    StatusCode = StatusCode.Success,
                    Data = result
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[DeleteEstate] : {ex.Message}",
                    StatusCode = StatusCode.IternalServerEror
                };
            }
        }
    }
}
