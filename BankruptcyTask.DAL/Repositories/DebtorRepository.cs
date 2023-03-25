using BankruptcyTask.DAL.Interfaces;
using BankruptcyTask.Domain;
using BankruptcyTask.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptcyTask.DAL.Repositories
{
    public class DebtorRepository : IDebtorRepository
    {
        private readonly ApplicationDbContext _context;
        public DebtorRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> Create(Debtor entity)
        {
            await _context.Debtors.AddAsync(entity);
            var count = await _context.SaveChangesAsync();
            return count > 0;
        }

        public async Task<bool> Delete(Debtor entity)
        {
            _context.Remove(entity);
            var count = await _context.SaveChangesAsync();
            return count > 0;
        }

        public async Task<Debtor> GetById(int id)
        {
            return await _context.Debtors.Include(debtor => debtor.EstateList)
                .FirstOrDefaultAsync(debtor => debtor.Id == id);
        }        

        public async Task<IEnumerable<Debtor>> GetAll()
        {
            return await _context.Debtors.ToListAsync();
        }

        public async Task<Debtor> Update(Debtor entity)
        {
            _context.Debtors.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
