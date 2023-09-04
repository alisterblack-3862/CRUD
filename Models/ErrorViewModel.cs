using System.ComponentModel.DataAnnotations;

namespace New_folder.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
public class UserModel
{
    [Required]
    public string UserName { get; set; }
    
    [Required]
    public string Password { get; set; }
}
public class UserDTO
{
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? Role { get; set; }
}