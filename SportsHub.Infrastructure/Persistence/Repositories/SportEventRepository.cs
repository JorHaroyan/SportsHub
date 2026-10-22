using System;
using System.Collections.Generic;
using System.Text;
using SportsHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace SportsHub.Infrastructure.Persistence.Repositories
{
    public class SportEventRepository
    {
        private readonly SportsHubDbContext _sportContext;
        public SportEventRepository(SportsHubDbContext sportContext)
        {
            _sportContext = sportContext;
        }

        public async Task AddAsync(SportEvent sportEvent)
        {
            await _sportContext.SportEvents.AddAsync(sportEvent);
            await _sportContext.SaveChangesAsync();
        }
        public async Task<SportEvent?> GetByIdAsync(int id)
        {
            return await _sportContext.SportEvents.FindAsync(id);
        }
        public async Task<IEnumerable<SportEvent>> GetAllAsync()
        {
            return await _sportContext.SportEvents.ToListAsync();
        }
        public async Task UpdateAsync(SportEvent sportEvent)
        {
            _sportContext.SportEvents.Update(sportEvent);
            await _sportContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(SportEvent sportEvent)
        {
            _sportContext.SportEvents.Remove(sportEvent);
            await _sportContext.SaveChangesAsync();
        }
        public async Task<bool> ExistsAsync(SportEvent sportEvent)
        {
            return await _sportContext.SportEvents.AnyAsync(e => e.Id == sportEvent.Id);
        }
        public async Task<SportEvent?> GetByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _sportContext.SportEvents.FirstOrDefaultAsync(e => e.StartDate >= startDate && e.EndDate <= endDate);
        }
        public async Task<IEnumerable<SportEvent>> GetUpcomingAsync()
        {
            return await _sportContext.SportEvents.Where(e => e.StartDate > DateTime.Now).ToListAsync();
        }
    }
}
