using System;

namespace Nexus.Contracts.Requests
{
    public class CreateBudgetOperationRequest
    {
        public DateTime OperationDate { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }
        public double Amount { get; set; }
        public string Comment { get; set; }
    }
}
