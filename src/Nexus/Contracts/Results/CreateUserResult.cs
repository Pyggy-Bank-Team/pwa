using Nexus.Contracts.Responses;
using Nexus.Enums;

namespace Nexus.Contracts.Results
{
    public class CreateUserResult
    {
        public CreateUserResultEnum Result { get; set; }
        public ErrorResponse Error { get; set; }
        public AccessTokenResponse Token { get; set; }
    }
}
