using Microsoft.AspNetCore.Identity;

namespace API.Identity;

public class Roles : IdentityRole<Guid>
{
    public Roles()
    {
        Id = Guid.NewGuid();
    }

    public Roles(string roleName) : this()
    {
        Name = roleName;
    }

    public string? Description { get; set; }
    public Roles(string name, string? description = null)
        : base(name)
    {
        Description = description;
        NormalizedName = name.ToUpperInvariant();
    }
}
