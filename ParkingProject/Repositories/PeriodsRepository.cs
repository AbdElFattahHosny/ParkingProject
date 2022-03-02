using Microsoft.EntityFrameworkCore;
using ParkingProject.Models;
using ParkingProject.Models.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ParkingProject.Repositories
{
    public class PeriodsRepository : IParkingInteface<Period>
    {
        private readonly ParkingDbContext context;

        public PeriodsRepository(ParkingDbContext _context)
        {
            context = _context;
        }
        public async Task<int> AddAsync(Period entity)
        {
            await context.Periods.AddAsync(entity);
            return await context.SaveChangesAsync();

        }

        public async Task<int> DeleteAsync(Period entity)
        {
            entity.IsActive = false;

            return await context.SaveChangesAsync();
        }
        public async Task<int> RestoreAsync(Period entity)
        {
            entity.IsActive = true;
            return await context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Period>> GetAllAsync()
        {
            return await context.Periods.ToListAsync();
        }

        public async Task<Period> GetByIdAsync(long id)
        {

            return await context.Periods.Where(x => x.Id == id).FirstOrDefaultAsync();

        }

        public async Task<int> UpdateAsync(Period entity)
        {
            Period oldEntity = await GetByIdAsync(entity.Id);
            oldEntity.ModifiedOn = DateTime.Now;
            oldEntity.ModifiedBy = entity.ModifiedBy;
            oldEntity.Number = entity.Number;
            oldEntity.From = entity.From;
            oldEntity.To = entity.To;
            return await context.SaveChangesAsync();

        }
    }
}
