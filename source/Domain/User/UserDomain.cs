using DotNetCoreArchitecture.Model;

namespace DotNetCoreArchitecture.Domain
{
    public class UserDomain
    {
        protected internal UserDomain(string login, string password)
        {
            SignIn = new SignInValueObject(login, password);
        }

        protected internal UserDomain(long userId, Roles roles)
        {
            UserId = userId;
            Roles = roles;
        }

        protected internal UserDomain
        (
            long userId,
            string name,
            string surname,
            string email,
            string login,
            string password,
            Roles roles
        )
        {
            UserId = userId;
            Name = name;
            Surname = surname;
            Email = email;
            SignIn = new SignInValueObject(login, password);
            Roles = roles;
        }

        public long UserId { get; private set; }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Email { get; private set; }

        public SignInValueObject SignIn { get; private set; }

        public Roles Roles { get; private set; }

        public Status Status { get; private set; }

        public void Add()
        {
            UserId = 0;
            Roles = Roles.User;
            Status = Status.Active;
        }

        public void Update(UpdateUserModel updateUserModel)
        {
            Name = updateUserModel.Name;
            Surname = updateUserModel.Surname;
            Email = updateUserModel.Email;
        }
    }
}
