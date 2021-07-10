using System;
using Nexus.Enums;

namespace Nexus.Contracts.Requests
{
    public class GetReportRequest
    {
        public CategoryType Type { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}