namespace Nexus.Enums
{
    public enum CreateUserResultEnum
    {
        Successful,
        UserNotCreated,
        InternalServerError,
        PasswordInvalid,
        DuplicateUserName,
        InvalidUserName
    }
}
