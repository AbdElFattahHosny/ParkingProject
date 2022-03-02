using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkingProject.Models.InterFaces
{
    public interface IParkingInteface<T>
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(long id);

        Task<int> AddAsync(T entity);

        Task<int> UpdateAsync(T entity);

        Task<int> DeleteAsync(T entity);

        Task<int> RestoreAsync(T entity);
    }
}
