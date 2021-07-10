using Nexus.Enums;

namespace Nexus.Contracts.Requests.Accounts
{
    public abstract class BaseAccountRequest
    {
        public string Title { get; set; }
        public AccountType Type { get; set; }
        public string Currency { get; set; }
        public double Balance { get; set; }
        public bool IsArchived { get; set; }
    }
}