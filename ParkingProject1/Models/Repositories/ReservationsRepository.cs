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
    public class ReservationsRepository : IParkingInteface<Reservations>
    {
        private readonly ParkingDbContext context;

        public ReservationsRepository(ParkingDbContext _context)
        {
            context = _context;
        }
        public async Task<int> AddAsync(Reservations entity)
        {
            await context.Reservations.AddAsync(entity);
            return await context.SaveChangesAsync();

        }

        public async Task<int> DeleteAsync(Reservations entity)
        {
            entity.IsActive = false;

            return await context.SaveChangesAsync();
        }
        public async Task<int> RestoreAsync(Reservations entity)
        {
            entity.IsActive = true;
            return await context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Reservations>> GetAllAsync()
        {
            return await context.Reservations.ToListAsync();
        }

        public async Task<Reservations> GetByIdAsync(long id)
        {

            return await context.Reservations.Where(x => x.Id == id).FirstOrDefaultAsync();

        }

        public async Task<int> UpdateAsync(Reservations entity)
        {
            Reservations oldEntity = await GetByIdAsync(entity.Id);
            oldEntity.ModifiedOn = DateTime.Now;
            oldEntity.ModifiedBy = entity.ModifiedBy;
            oldEntity.AreaId = entity.AreaId;
            oldEntity.SlotId = entity.SlotId;
            oldEntity.From = entity.From;
            oldEntity.To = entity.To;
            oldEntity.TotalHours = entity.TotalHours;
            oldEntity.CustomerId = entity.CustomerId;
            oldEntity.TotalCost = entity.TotalCost;
            return await context.SaveChangesAsync();

        }
    }
}
