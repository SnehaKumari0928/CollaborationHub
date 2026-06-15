using backend.Data;
using backend.Repositories.Implementations;
using backend.Repositories.Interfaces;

namespace backend.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IUserRepository Users { get; }
        public IRefreshTokenRepository RefreshTokens { get; }
        public IPasswordResetTokenRepository PasswordResetTokens { get; }

        public UnitOfWork(AppDbContext context, IUserRepository users, IRefreshTokenRepository refreshTokens, IPasswordResetTokenRepository passwordResetTokens)
        {
            _context = context;
            Users = users;
            RefreshTokens = refreshTokens;
            PasswordResetTokens = passwordResetTokens;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();   
        }
    }
}
