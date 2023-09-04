using New_folder.Models;

namespace New_folder.Reposatory
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, UserDTO user);
        bool ValidateToken(string key, string issuer, string token);
    }

}