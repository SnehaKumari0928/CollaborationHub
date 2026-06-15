using backend.Data;
using backend.Entities;
using backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories.Implementations
{
    public class RefreshTokenRepository: GenericRepository<RefreshToken>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(AppDbContext context) : base(context) { }

        public async Task<RefreshToken> GetByTokenAsync(string token)
        {
            return await _dbSet
                 .Include(rt => rt.User)
                 .FirstOrDefaultAsync(rt => rt.Token == token 
                 && !rt.IsRevoked 
                 && rt.ExpiresAt > DateTime.UtcNow);
        }
        public async Task<List<RefreshToken>> GetUserTokensAsync(Guid userId)
        {
            return await _dbSet.Where(rt => rt.UserId == userId).ToListAsync();
        }
    }
}
