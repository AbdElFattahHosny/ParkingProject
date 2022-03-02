using Microsoft.EntityFrameworkCore;
using ParkingProject.Models;
using ParkingProject.Models.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingProject.Repositories
{
    public class UsersRepository : IParkingInteface<Users>
    {
        private readonly ParkingDbContext context;

        public UsersRepository(ParkingDbContext _context)
        {
            context = _context;
        }
        public async Task<int> AddAsync(Users entity)
        {
            await context.Users.AddAsync(entity);
            return await context.SaveChangesAsync();

        }

        public async Task<int> DeleteAsync(Users entity)
        {
            entity.IsActive = false;

            return await context.SaveChangesAsync();
        }
        public async Task<int> RestoreAsync(Users entity)
        {
            entity.IsActive = true;
            return await context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Users>> GetAllAsync()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<Users> GetByIdAsync(long id)
        {

            return await context.Users.Where(x => x.Id == id).FirstOrDefaultAsync();

        }

        public async Task<int> UpdateAsync(Users entity)
        {
            Users oldEntity = await GetByIdAsync(entity.Id);
            oldEntity.ModifiedOn = DateTime.Now;
            oldEntity.ModifiedBy = entity.ModifiedBy;
            oldEntity.FirstName = entity.FirstName;
            oldEntity.LastName = entity.LastName;
            oldEntity.Mobile = entity.Mobile;
            oldEntity.Password = entity.Password;
            oldEntity.Email = entity.Email;
            


            return await context.SaveChangesAsync();

        }
    }
}
