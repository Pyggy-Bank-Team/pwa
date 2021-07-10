using System.Collections.Generic;

namespace Nexus.Contracts.Responses
{
    public class ErrorResponse
    {
        public string Type { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}