using System;
using System.Collections.Generic;
using System.Text;
using SportsHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Diagnostics;

namespace SportsHub.Infrastructure.Persistence.Repositories
{
    public class SportRepository
    {
        private readonly SportsHubDbContext _sportContext;
        public SportRepository(SportsHubDbContext sportContext)
        {
            _sportContext = sportContext;
        }

        public async Task AddAsync(Sports sport)
        {
            await _sportContext.Sports.AddAsync(sport);
            await _sportContext.SaveChangesAsync();
        }

        public async Task<Sports?> GetByIdAsync(int id)
        {
            return await _sportContext.Sports.FindAsync(id);
        }

        public async Task<IEnumerable<Sports>> GetAllAsync()
        {
            return await _sportContext.Sports.ToListAsync();
        }

        public async Task UpdateAsync(Sports sport)
        {
            _sportContext.Sports.Update(sport);
            await _sportContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Sports sport)
        {
            _sportContext.Sports.Remove(sport);
            await _sportContext.SaveChangesAsync();
        }
        
        public async Task<bool> ExistsAsync(Sports sport)
        {
            return await _sportContext.Sports.AnyAsync(s => s.Id == sport.Id);
        }

        public async Task<Sports?> GetByNameAsync(string name)
        {
            return await _sportContext.Sports.FirstOrDefaultAsync(s => s.Name == name);
        }
    }
}
