using backend.Entities;

namespace backend.Repositories.Interfaces
{
    public interface IPasswordResetTokenRepository: IGenericRepository<PasswordResetToken>
    {
        Task<PasswordResetToken> GetValidTokenAsync(string token);
    }
}
