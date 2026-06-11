using backend.Data;
using backend.Entities;
using backend.Repositories.Interfaces;

namespace backend.Repositories.Implementations
{
    public class GenericRepository<T>: IGenericRepository<T> 
        where T: BaseEntity
    {

        protected readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            
        }
        public async Task<T> UpdateAsync(T entity)
        {

        }
        public async Task DeleteAsync(T entity)
        {

        }
        public async Task GetByIdAsync(int id)
        {

        }
        public async Task SaveChangesAsync()
        {

        }
    }
}
