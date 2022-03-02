using Microsoft.EntityFrameworkCore;
using ParkingProject.Models;
using ParkingProject.Models.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingProject.Repositories
{
    public class RoleRepository : IParkingInteface<Role>
    {
        private readonly ParkingDbContext context;

        public RoleRepository(ParkingDbContext _context)
        {
            context = _context;
        }
        public async Task<int> AddAsync(Role entity)
        {
            await context.Roles.AddAsync(entity);
            return await context.SaveChangesAsync();

        }

        public async Task<int> DeleteAsync(Role entity)
        {
            entity.IsActive = false;

            return await context.SaveChangesAsync();
        }
        public async Task<int> RestoreAsync(Role entity)
        {
            entity.IsActive = true;
            return await context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Role>> GetAllAsync()
        {
            return await context.Roles.ToListAsync();
        }

        public async Task<Role> GetByIdAsync(long id)
        {

            return await context.Roles.Where(x => x.Id == id).FirstOrDefaultAsync();

        }

        public async Task<int> UpdateAsync(Role entity)
        {
            Role oldEntity = await GetByIdAsync(entity.Id);
            oldEntity.ModifiedOn = DateTime.Now;
            oldEntity.ModifiedBy = entity.ModifiedBy;
            oldEntity.Name = entity.Name;

            return await context.SaveChangesAsync();

        }
    }
}

