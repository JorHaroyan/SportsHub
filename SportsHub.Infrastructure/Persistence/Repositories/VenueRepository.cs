using System;
using System.Collections.Generic;
using System.Text;
using SportsHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace SportsHub.Infrastructure.Persistence.Repositories
{
    public class VenueRepository
    {
        private readonly SportsHubDbContext _sportContext;
        public VenueRepository(SportsHubDbContext sportContext)
        {
            _sportContext = sportContext;
        }
        public async Task AddAsync(Venues venue)
        {
            await _sportContext.Venues.AddAsync(venue);
            await _sportContext.SaveChangesAsync();
        }
        public async Task<Venues?> GetByIdAsync(int id)
        {
            return await _sportContext.Venues.FindAsync(id);
        }
        public async Task<IEnumerable<Venues>> GetAllAsync()
        {
            return await _sportContext.Venues.ToListAsync();
        }
        public async Task UpdateAsync(Venues venue)
        {
            _sportContext.Venues.Update(venue);
            await _sportContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(Venues venue)
        {
            _sportContext.Venues.Remove(venue);
            await _sportContext.SaveChangesAsync();
        }
        public async Task<ICollection<Venues>> GetByCityAsync(string city)
        {
            return await _sportContext.Venues.Where(v => v.City == city).ToListAsync();
        }
    }
}
