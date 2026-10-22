using System;
using System.Collections.Generic;
using System.Text;
using SportsHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace SportsHub.Infrastructure.Persistence.Repositories
{
    public class AthleteRepository
    {
        private readonly SportsHubDbContext _sportContext;
        
        public AthleteRepository(SportsHubDbContext sportContext)
        {
            _sportContext = sportContext;
        }

        public async Task AddAsync(Athletes athlete)
        {
            await _sportContext.Athletes.AddAsync(athlete);
            await _sportContext.SaveChangesAsync();
        }
        public async Task<Athletes?> GetByIdAsync(int id)
        {
            return await _sportContext.Athletes.FindAsync(id);
        }
        public async Task<IEnumerable<Athletes>> GetAllAsync()
        {
            return await _sportContext.Athletes.ToListAsync();
        }
        public async Task UpdateAsync(Athletes athlete)
        {
            _sportContext.Athletes.Update(athlete);
            await _sportContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(Athletes athlete)
        {
            _sportContext.Athletes.Remove(athlete);
            await _sportContext.SaveChangesAsync();
        }
        public async Task<Athletes?> GetByNameAsync(string name)
        {
            return await _sportContext.Athletes.FirstOrDefaultAsync(a => a.FirstName + " " + a.LastName == name);
        }
        public async Task<ICollection<Athletes>> GetByTeamAsync(Guid teamId)
        {
            return await _sportContext.Athletes
                .Where(a => a.TeamAthletes.Any(ta => ta.TeamId == teamId))
                .ToListAsync();
        }
    }
}
