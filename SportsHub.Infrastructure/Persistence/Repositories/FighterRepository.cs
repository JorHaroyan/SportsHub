using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SportsHub.Domain.Entities;
using SportsHub.Domain.Enums;

namespace SportsHub.Infrastructure.Persistence.Repositories
{
    public class FighterRepository
    {
        private readonly SportsHubDbContext _sportContext;
        public FighterRepository(SportsHubDbContext sportContext)
        {
            _sportContext = sportContext;
        }
        public async Task AddAsync(Fighters fighter)
        {
            await _sportContext.Fighters.AddAsync(fighter);
            await _sportContext.SaveChangesAsync();
        }
        public async Task<Fighters?> GetByIdAsync(int id)
        {
            return await _sportContext.Fighters.FindAsync(id);
        }
        public async Task<IEnumerable<Fighters>> GetAllAsync()
        {
            return await _sportContext.Fighters.ToListAsync();
        }
        public async Task UpdateAsync(Fighters fighter)
        {
            _sportContext.Fighters.Update(fighter);
            await _sportContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(Fighters fighter)
        {
            _sportContext.Fighters.Remove(fighter);
            await _sportContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<Fighters>> GetByWeightClassAsync(MmaWeightClass mmaWeight)
        {
            return await _sportContext.Fighters
                .Where(f => f.WeightClass == mmaWeight).ToListAsync();
        }
    }
}
