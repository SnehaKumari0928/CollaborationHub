using backend.DTOs.Auth.Request;
using backend.DTOs.Auth.Response;
using backend.Repositories.Interfaces;
using backend.Services.Interfaces;

namespace backend.Services.Implementations
{
    public class AuthService: IAuthService
    {
        private readonly IUserRepository _userRepository;

        public async Task RegisterAsync(RegisterRequestDto dto)
        {

        }
        public async Task<AuthResponseDto> LoginAsync(LoginRequestDto dto)
        {

        }
        public async Task LogoutAsync(string refreshToken)
        {

        }
    }
}
