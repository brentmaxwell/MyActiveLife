using Microsoft.AspNetCore.Identity;
using MyActiveLife.Web.Data;

namespace MyActiveLife.Web.Startup
{
    public static partial class Startup
    {
        public static WebApplicationBuilder ConfigureIdentity(this WebApplicationBuilder builder)
        {
            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            return builder;
        }
    }
}
