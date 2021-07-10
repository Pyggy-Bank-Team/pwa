using System.Threading;
using System.Threading.Tasks;
using Nexus.Contracts.Requests;
using Nexus.Contracts.Responses;
using Nexus.Dto;

namespace Nexus.Interfaces
{
    public interface IReportService : IAuthorization
    {
        Task<ItemReport[]> GetChartByCategories(GetReportRequest request, CancellationToken token);
        Task<ChartByExpenseDaysResponse[]> GetChartByExpenseDays(GetChartByExpensePerDaysRequest request, CancellationToken token);
    }
}