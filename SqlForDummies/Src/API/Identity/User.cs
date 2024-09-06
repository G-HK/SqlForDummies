using Microsoft.AspNetCore.Identity;

namespace API.Identity;

public class User : IdentityUser<Guid>
{
    public User()
    {
        Id = Guid.NewGuid();
        SecurityStamp = Guid.NewGuid().ToString();
    }

    public User(string userName) : this()
    {
        UserName = userName;
    }

    public string? FirstName { get; set; } = default!;
    public string? LastName { get; set; } = default!;
    public string? ImageUrl { get; set; }
    public bool IsActive { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
}