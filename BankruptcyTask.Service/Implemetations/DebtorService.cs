using BankruptcyTask.DAL.Interfaces;
using BankruptcyTask.Domain.Response;
using BankruptcyTask.Domain;
using BankruptcyTask.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankruptcyTask.Domain.Entity;
using BankruptcyTask.Models.ViewModel;
using BankruptcyTask.DAL.Repositories;

namespace BankruptcyTask.Service.Implemetations
{
    public class DebtorService : IDebtorService
    {
        private readonly IDebtorRepository _debtorRepository;
        public DebtorService(IDebtorRepository debtorRepository)
        {
            _debtorRepository = debtorRepository;
        }
        public async Task<BaseResponse<IEnumerable<Debtor>>> GetDebtors()
        {
            try
            {
                var debtors = await _debtorRepository.GetAll();
                if (debtors.Count() == 0)
                {
                    return new BaseResponse<IEnumerable<Debtor>>()
                    {
                        Description = "Найдено 0 элементов",
                        StatusCode = StatusCodes.Status204NoContent,
                        Data = debtors
                    };
                }
                return new BaseResponse<IEnumerable<Debtor>>()
                {
                    StatusCode = StatusCodes.Status200OK,
                    Data = debtors
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Debtor>>()
                {
                    Description = $"[GetDebtors] : {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }
        }
        public async Task<BaseResponse<Debtor>> GetDebtor(int id)
        {
            try
            {
                var debtor = await _debtorRepository.GetById(id);
                if (debtor == null)
                {
                    return new BaseResponse<Debtor>()
                    {
                        Description = "Элемент не найден",
                        StatusCode = StatusCodes.Status404NotFound
                    };
                }
                return new BaseResponse<Debtor>()
                {
                    StatusCode = StatusCodes.Status200OK,
                    Data = debtor
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Debtor>()
                {
                    Description = $"[GetById] : {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }
        }
        public async Task<BaseResponse<Debtor>> GetDebtor(string name, string surname)
        {
            try
            {
                var debtor = await _debtorRepository.GetByName(name,surname);
                if (debtor == null)
                {
                    return new BaseResponse<Debtor>()
                    {
                        Description = "Элемент не найден",
                        StatusCode = StatusCodes.Status404NotFound
                    };
                }
                return new BaseResponse<Debtor>()
                {
                    StatusCode = StatusCodes.Status200OK,
                    Data = debtor
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Debtor>()
                {
                    Description = $"[GetByName] : {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }
        }       
        public async Task<BaseResponse<bool>> DeleteDebtor(int id)
        {
            try
            {
                var debtor = await _debtorRepository.GetById(id);
                if (debtor == null)
                {
                    return new BaseResponse<bool>()
                    {
                        Description = "Элемент не найден",
                        StatusCode = StatusCodes.Status404NotFound,
                        Data = false
                    };
                }
                var result = await _debtorRepository.Delete(debtor);
                return new BaseResponse<bool>()
                {
                    StatusCode = StatusCodes.Status200OK,
                    Data = result
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[DeleteDebtor] : {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }
        }
        public async Task<BaseResponse<bool>> Create(DebtorViewModel debtorViewModel)
        {
            try
            {
                var debtor = new Debtor()
                {
                    Name = debtorViewModel.Name,
                    SurName = debtorViewModel.SurName,
                    EstateList = new List<Estate>()
                };

                var result = await _debtorRepository.Create(debtor);
                return new BaseResponse<bool>()
                {
                    StatusCode = StatusCodes.Status200OK,
                    Data = result
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[Create] : {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = false
                };
            }
        }
        public async Task<BaseResponse<Debtor>> AddEstate(int DebtorId, Estate estate)
        {
            try
            {
                var debtor = await _debtorRepository.GetById(DebtorId);
                if (debtor == null)
                {
                    return new BaseResponse<Debtor>()
                    {
                        Description = "Элемент не найден",
                        StatusCode = StatusCodes.Status404NotFound
                    };
                }
                estate.Debtor = debtor;
                estate.DebtorId = debtor.Id;                
                debtor.EstateList.Add(estate);

                return new BaseResponse<Debtor>()
                {
                    StatusCode = StatusCodes.Status200OK,
                    Data = debtor
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Debtor>()
                {
                    Description = $"[AddEstate] : {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }
        }

        public async Task<BaseResponse<Debtor>> Edit(int id, DebtorViewModel debtorViewModel)
        {
            try
            {
                var debtor = await _debtorRepository.GetById(id);
                if (debtor == null)
                {
                    return new BaseResponse<Debtor>()
                    {
                        Description = "Имущество не найдено",
                        StatusCode = StatusCodes.Status404NotFound,
                    };
                }
                debtor.Name = debtorViewModel.Name;
                debtor.SurName = debtorViewModel.SurName;
                debtor.EstateList = debtorViewModel.EstateList;              
                var result = await _debtorRepository.Update(debtor);

                return new BaseResponse<Debtor>()
                {
                    StatusCode = StatusCodes.Status200OK,
                    Data = result
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Debtor>()
                {
                    Description = $"[Edit] : {ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }
        }
    }
}
