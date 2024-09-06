using Microsoft.AspNetCore.Identity;

namespace API.Identity;

public class ApplicationRoleClaim : IdentityRoleClaim<Guid>
{
    public string? CreatedBy { get; init; }
    public DateTime CreatedOn { get; init; }
}
