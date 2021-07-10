using System;
using Nexus.Enums;

namespace Nexus.Contracts.Responses
{
    public class BudgetOperationResponse
    {
        public string Comment { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public OperationType Type { get; set; }
        public DateTime Date { get; set; }
    }
}
