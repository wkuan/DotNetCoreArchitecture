using DotNetCoreArchitecture.Model;

namespace DotNetCoreArchitecture.Domain
{
    public interface IUserDomainService
    {
        void GenerateHashForLoginAndPassword(SignInModel signInModel);

        string GenerateToken(SignedInModel signedInModel);
    }
}
