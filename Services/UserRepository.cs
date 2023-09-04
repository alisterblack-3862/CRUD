using New_folder.Models;
using New_folder.Reposatory;
using New_folder.UserFunction;

namespace New_folder.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly List<UserDTO> users = new List<UserDTO>();
        UsersFunction objuser= new UsersFunction();
        public UserRepository()
        {
            users.Add(new UserDTO
            {
                UserName = "joydipkanjilal",
                Password = "joydip123",
                Role = "manager"
            });
            users.Add(new UserDTO
            {
                UserName = "michaelsanders",
                Password = "michael321",
                Role = "developer"
            });
            users.Add(new UserDTO
            {
                UserName = "stephensmith",
                Password = "stephen123",
                Role = "tester"
            });
            users.Add(new UserDTO
            {
                UserName = "rodpaddock",
                Password = "rod123",
                Role = "admin"
            });
            users.Add(new UserDTO
            {
                UserName = "rexwills",
                Password = "rex321",
                Role = "admin"
            });
        }
        public UserDTO GetUser(UserModel userModel)
        {
            var data=objuser.getloginuser(userModel);

            UserDTO userdto=new UserDTO();
            if(data!=null)
            {
                userdto.UserName=data.UserName;
                userdto.Password=data.Password;
            }
            //if(userdto.UserName==data.UserName && userdto.Password==data.Password)
            return userdto;
        }
    }
}