using System.Threading;
using System.Threading.Tasks;
using Nexus.Contracts.Requests;
using Nexus.Contracts.Responses;
using Nexus.Contracts.Results;

namespace Nexus.Interfaces
{
    public interface IOperationService : IAuthorization
    {
        Task<PageResult<OperationResponse>> GetOperations(int page, CancellationToken token);
        Task<BudgetOperationResponse> GetBudgetOperation(int id, CancellationToken token);
        Task<TransferOperationResponse> GetTransferOperation(int id, CancellationToken token);
        Task<bool> CreateBudgetOperation(CreateBudgetOperationRequest request, CancellationToken token);
        Task<bool> CreateTransferOperation(CreateTransferOperationRequest request, CancellationToken token);
        Task<bool> UpdateBudgetOperation(int id, UpdateBudgetOperationRequest request, CancellationToken token);
        Task<bool> UpdateTransferOperation(int id, UpdateTransferOperationRequest request, CancellationToken token);
        Task<bool> DeleteTransferOperation(int id, CancellationToken token);
        Task<bool> DeleteBudgetOperation(int id, CancellationToken token);
    }
}