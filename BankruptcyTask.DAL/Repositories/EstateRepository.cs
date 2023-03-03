﻿using BankruptcyTask.DAL.Interfaces;
using BankruptcyTask.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankruptcyTask.DAL.Repositories
{
    public class EstateRepository : IEstateRepository
    {
        private readonly ApplicationDbContext _context;
        public EstateRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> Create(Estate entity)
        {
            await _context.Estates.AddAsync(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(Estate entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Estate> GetById(int id)
        {
            return await _context.Estates.FirstOrDefaultAsync(estate=> estate.Id == id);
        }

        public async Task<IEnumerable<Estate>> GetByDebtor(int debtorId)
        {
            return await _context.Estates.Where(esstate => esstate.DebtorId == debtorId)
                .ToListAsync();
        }

        public async Task<Estate> GetByName(string name)
        {
            return await _context.Estates.FirstOrDefaultAsync(estate => estate.Name == name);
        }

        public async Task<IEnumerable<Estate>> GetAll()
        {
            return await _context.Estates.ToListAsync();
        }

        public async Task<Estate> Update(Estate entity)
        {
            _context.Estates.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
