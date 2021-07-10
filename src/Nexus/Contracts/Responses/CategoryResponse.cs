using System;
using Nexus.Enums;

namespace Nexus.Contracts.Responses
{
    public class CategoryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string HexColor { get; set; }
        public CategoryType Type { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsArchived { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}