using API.Identity;
using Finbuckle.MultiTenant.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace API.Data;

public class APIContext : MultiTenantIdentityDbContext<User, Roles, Guid, IdentityUserClaim<Guid>, IdentityUserRole<Guid>, IdentityUserLogin<string>, ApplicationRoleClaim, IdentityUserToken<Guid>>
{
    public APIContext()
        : base()
    { }
}
