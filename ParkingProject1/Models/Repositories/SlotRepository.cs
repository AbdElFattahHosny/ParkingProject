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
    public class SlotRepository : IParkingInteface<Slot>
    {
        private readonly ParkingDbContext context;

        public SlotRepository(ParkingDbContext _context)
        {
            context = _context;
        }
        public async Task<int> AddAsync(Slot entity)
        {
            await context.Slots.AddAsync(entity);
            return await context.SaveChangesAsync();

        }

        public async Task<int> DeleteAsync(Slot entity)
        {
            entity.IsActive = false;

            return await context.SaveChangesAsync();
        }
        public async Task<int> RestoreAsync(Slot entity)
        {
            entity.IsActive = true;
            return await context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Slot>> GetAllAsync()
        {
            return await context.Slots.ToListAsync();
        }

        public async Task<Slot> GetByIdAsync(long id)
        {

            return await context.Slots.Where(x => x.Id == id).FirstOrDefaultAsync();

        }

        public async Task<int> UpdateAsync(Slot entity)
        {
            Slot oldEntity = await GetByIdAsync(entity.Id);
            oldEntity.ModifiedOn = DateTime.Now;
            oldEntity.ModifiedBy = entity.ModifiedBy;
            oldEntity.AreaId = entity.AreaId;
            oldEntity.Number = entity.Number;
            

            return await context.SaveChangesAsync();

        }
    }
}
