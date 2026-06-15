using backend.Repositories.Interfaces;

namespace backend.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        IRefreshTokenRepository RefreshTokens { get; }
        IPasswordResetTokenRepository PasswordResetTokens { get; }
        Task<int> SaveChangesAsync();
    }
}
