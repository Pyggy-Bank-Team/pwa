using System.Threading;
using System.Threading.Tasks;
using Nexus.Contracts.Requests;
using Nexus.Contracts.Responses;
using Nexus.Contracts.Results;

namespace Nexus.Interfaces
{
    public interface IUserService : IAuthorization
    {
        Task<ServiceResult<AccessTokenResponse>> RegistrationUser(CreateUserRequest request, CancellationToken token);

        Task<ServiceResult<AccessTokenResponse>> GetAccessToken(GetTokenRequest request, CancellationToken token);

        Task<CurrencyResponse[]> GetAvailableCurrencies(CancellationToken token);

        Task<UserInfoResponse> GetUserInfo(CancellationToken token);

        Task<bool> UpdateUserInfo(UpdateUserInfoRequest request, CancellationToken token);
    }
}
