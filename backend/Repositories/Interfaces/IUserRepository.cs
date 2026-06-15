using backend.Entities;

namespace backend.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {

         Task<User> GetByEmailAsync(string email);
         Task<bool> EmailExistsAsync(string email);
    }
}
