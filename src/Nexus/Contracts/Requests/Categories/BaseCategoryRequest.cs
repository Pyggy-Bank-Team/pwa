using Nexus.Enums;

namespace Nexus.Contracts.Requests.Categories
{
    public class BaseCategoryRequest
    {
        public string Title { get; set; }
        public string HexColor { get; set; }
        public CategoryType Type { get; set; }
        public bool IsArchived { get; set; }
    }
}