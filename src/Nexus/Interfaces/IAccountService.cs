using System.Threading;
using System.Threading.Tasks;
using Nexus.Contracts.Requests.Accounts;
using Nexus.Contracts.Responses;

namespace Nexus.Interfaces
{
    public interface IAccountService : IAuthorization
    {
        Task<AccountResponse[]> GetAccounts(bool showArchivedAccounts, CancellationToken token);

        Task<AccountResponse> CreateAccount(CreateAccountRequest response, CancellationToken token);

        Task<bool> UpdateAccount(UpdateAccountRequest response, CancellationToken token);

        Task<bool> DeleteAccount(long id, CancellationToken token);
    }
}