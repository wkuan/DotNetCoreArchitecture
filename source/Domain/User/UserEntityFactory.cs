using DotNetCoreArchitecture.Model;

namespace DotNetCoreArchitecture.Domain
{
    public static class UserEntityFactory
    {
        public static UserEntity Create(UserDomain userDomain)
        {
            return new UserEntity
            (
                userDomain.UserId,
                userDomain.Name,
                userDomain.Surname,
                userDomain.Email,
                userDomain.SignIn.Login,
                userDomain.SignIn.Password,
                userDomain.Roles,
                userDomain.Status
            );
        }
    }
}
