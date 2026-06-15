using backend.Entities;

namespace backend.Repositories.Interfaces
{
    public interface IRefreshTokenRepository: IGenericRepository<RefreshToken>
    {
        Task<RefreshToken> GetByTokenAsync(string token);
        Task<List<RefreshToken>> GetUserTokensAsync(Guid userId);
    }
}
