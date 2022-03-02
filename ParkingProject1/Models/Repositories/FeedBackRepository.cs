using Microsoft.EntityFrameworkCore;
using ParkingProject1.Models;
using ParkingProject1.Models.InterFaces;
using ParkingProject11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingProject1.Repositories
{
    public class FeedBackRepository : IParkingInteface<FeedBacks>
    {
        private readonly ParkingDbContext context;

        public FeedBackRepository(ParkingDbContext _context)
        {
            context = _context;
        }
        public async Task<int> AddAsync(FeedBacks entity)
        {
            await context.FeedBacks.AddAsync(entity);
            return await context.SaveChangesAsync();

        }

        public async Task<int> DeleteAsync(FeedBacks entity)
        {
            entity.IsActive = false;

            return await context.SaveChangesAsync();
        }
        public async Task<int> RestoreAsync(FeedBacks entity)
        {
            entity.IsActive = true;
            return await context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<FeedBacks>> GetAllAsync()
        {
            return await context.FeedBacks.ToListAsync();
        }

        public async Task<FeedBacks> GetByIdAsync(long id)
        {

            return await context.FeedBacks.Where(x => x.Id == id).FirstOrDefaultAsync();

        }

        public async Task<int> UpdateAsync(FeedBacks entity)
        {
            FeedBacks oldEntity = await GetByIdAsync(entity.Id);
            oldEntity.ModifiedOn = DateTime.Now;
            oldEntity.ModifiedBy = entity.ModifiedBy;
            oldEntity.Message = entity.Message;

            return await context.SaveChangesAsync();

        }
    }
}
