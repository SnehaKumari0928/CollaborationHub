using backend.Entities;

namespace backend.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task GetByIdAsync(int id);
        Task SaveChangesAsync();

    }
}
