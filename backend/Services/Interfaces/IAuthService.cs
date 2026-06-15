using backend.DTOs.Auth.Request;
using backend.DTOs.Auth.Response;

namespace backend.Services.Interfaces
{
    public interface IAuthService
    {

        Task RegisterAsync(RegisterRequestDto dto);
        Task<AuthResponseDto> LoginAsync(LoginRequestDto dto);
        Task LogoutAsync(string refreshToken);
    }
}
