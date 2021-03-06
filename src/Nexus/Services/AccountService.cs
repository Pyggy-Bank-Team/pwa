using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nexus.Contracts.Requests.Accounts;
using Nexus.Contracts.Responses;
using Nexus.Interfaces;

namespace Nexus.Services
{
    public class AccountService : PiggyServiceBase, IAccountService
    {
        public AccountService(IHttpClientFactory httpClientFactory,ISettingsService settingsService) 
            : base(httpClientFactory, settingsService)
        {
        }

        public Task<AccountResponse[]> GetAccounts(bool showArchivedAccounts, CancellationToken token)
            => Get<AccountResponse[]>($"accounts?all={showArchivedAccounts}", token);

        public async Task<AccountResponse> CreateAccount(CreateAccountRequest response, CancellationToken token)
        {
            var result = await Post<AccountResponse, CreateAccountRequest>("accounts", response, token);
            return result.IsSuccess ? result.Ok : null;
        }

        public Task<bool> UpdateAccount(UpdateAccountRequest response, CancellationToken token)
            => Put($"accounts/{response.Id}",response, token);

        public Task<bool> DeleteAccount(long id, CancellationToken token)
            => Delete($"accounts/{id}", token);
    }
}