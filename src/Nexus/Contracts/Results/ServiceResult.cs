using Nexus.Contracts.Responses;

namespace Nexus.Contracts.Results
{
    public class ServiceResult<T> where T : class
    {
        public ErrorResponse Error { get; set; }
        public T Ok { get; set; }
        public bool IsSuccess => Error == null;
    }
}