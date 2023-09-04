using New_folder.Models;

namespace New_folder.Reposatory
{
    public interface IUserRepository
    {
        UserDTO GetUser(UserModel userMode);
    }
}