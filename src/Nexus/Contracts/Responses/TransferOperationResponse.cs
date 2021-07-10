using System;
using Nexus.Enums;

namespace Nexus.Contracts.Responses
{
    public class TransferOperationResponse
    {
        public string Comment { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public OperationType Type { get; set; }
        public DateTime Date { get; set; }
    }
}
