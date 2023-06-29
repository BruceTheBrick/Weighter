using Weighter.Core.Models.Database;

namespace Weighter.Core.Services.Interfaces
{
    public interface IUserService
    {
        void CreateUser(UserModel user);
        void DeleteUser(UserModel user);
    }
}