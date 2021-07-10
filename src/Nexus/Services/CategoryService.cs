using System.Threading;
using System.Threading.Tasks;
using Nexus.Contracts.Requests.Categories;
using Nexus.Contracts.Responses;
using Nexus.Interfaces;

namespace Nexus.Services
{
    public class CategoryService : PiggyServiceBase, ICategoryService
    {
        public CategoryService(IHttpClientFactory httpClientFactory,ISettingsService settingsService) 
            : base(httpClientFactory, settingsService)
        {
        }

        public Task<CategoryResponse[]> GetCategories(bool showArchivedCategories, CancellationToken token)
            => Get<CategoryResponse[]>($"categories?all={showArchivedCategories}", token);

        public async Task<CategoryResponse> CreateCategory(CreateCategoryRequest request, CancellationToken token)
        {
            var result = await Post<CategoryResponse, CreateCategoryRequest>("categories", request, token);
            return result.IsSuccess ? result.Ok : null;
        }

        public Task<bool> UpdateCategory(UpdateCategoryRequest request, CancellationToken token)
            => Put($"categories/{request.Id}", request, token);

        public Task<bool> DeleteCategory(int id, CancellationToken token)
            => Delete($"categories/{id}", token);
    }
}