using backend.Data;
using backend.Entities;
using backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories.Implementations
{
    public class PasswordResetTokenRepository: GenericRepository<PasswordResetToken>, IPasswordResetTokenRepository
    {
        public PasswordResetTokenRepository(AppDbContext context): base(context) { }
        public Task<PasswordResetToken> GetValidTokenAsync(string token)
        {
            return _dbSet.Include(x => x.User)
                .FirstOrDefaultAsync(x => x.Token == token 
                && !x.IsUsed 
                && x.ExpiresAt > DateTime.UtcNow);
        }

    }
}
