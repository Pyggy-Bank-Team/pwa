using System.Threading;
using System.Threading.Tasks;
using Nexus.Contracts.Requests.Categories;
using Nexus.Contracts.Responses;

namespace Nexus.Interfaces
{
    public interface ICategoryService : IAuthorization
    {
        Task<CategoryResponse[]> GetCategories(bool showArchivedCategories, CancellationToken token);

        Task<CategoryResponse> CreateCategory(CreateCategoryRequest request, CancellationToken token);

        Task<bool> UpdateCategory(UpdateCategoryRequest response, CancellationToken token);

        Task<bool> DeleteCategory(int id, CancellationToken token);
    }
}