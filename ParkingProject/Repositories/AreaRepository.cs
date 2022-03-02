using Microsoft.EntityFrameworkCore;
using ParkingProject.Models;
using ParkingProject.Models.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingProject.Repositories
{
    public class AreaRepository : IParkingInteface<Area>
    {
        private readonly ParkingDbContext context;

        public AreaRepository(ParkingDbContext _context)
        {
            context = _context;
        }
        public async Task<int> AddAsync(Area entity)
        {
             await context.Areas.AddAsync(entity);
            return await context.SaveChangesAsync();

        }

        public async Task<int> DeleteAsync(Area entity)
        {
           entity.IsActive = false;

           return await context.SaveChangesAsync();
        }
        public async Task<int> RestoreAsync(Area entity)
        {
            entity.IsActive = true;
            return await context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Area>> GetAllAsync()
        {
            return await context.Areas.ToListAsync();
        }

        public async Task<Area> GetByIdAsync(long id)
        {
            
            return await context.Areas.Where(x => x.Id == id).FirstOrDefaultAsync();

        }

        public async Task<int> UpdateAsync(Area entity)
        {
            Area oldEntity = await GetByIdAsync(entity.Id);
            oldEntity.ModifiedOn = DateTime.Now;
            oldEntity.ModifiedBy = entity.ModifiedBy;
            oldEntity.Name = entity.Name;
            
            return await context.SaveChangesAsync();

        }
    }
}
