using API.Data;
using Microsoft.AspNetCore.Identity;

namespace API.Identity;

internal static class StartUp
{
    internal static IServiceCollection AddIdentity(this IServiceCollection services) =>
        services.AddIdentity<User, Roles>(opts =>
        {
            opts.Password.RequireDigit = true;
            opts.Password.RequireLowercase = false;
            opts.Password.RequireUppercase = false;
            opts.Password.RequiredUniqueChars = 3;
            opts.Password.RequiredLength = 7;
            opts.User.RequireUniqueEmail = true;
            opts.Lockout.MaxFailedAccessAttempts = 50;
            opts.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(60);
            opts.SignIn.RequireConfirmedEmail = true;
            opts.SignIn.RequireConfirmedAccount = true;
            opts.Stores.ProtectPersonalData = true;
        })
        .AddEntityFrameworkStores<APIContext>()
        .AddDefaultTokenProviders()
        .Services;
}
