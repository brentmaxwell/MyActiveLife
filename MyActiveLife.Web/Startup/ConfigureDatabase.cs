using Microsoft.EntityFrameworkCore;
using MyActiveLife.Database;
using MyActiveLife.Web.Data;

namespace MyActiveLife.Web.Startup
{
    public static partial class Startup
    {
        public static WebApplicationBuilder ConfigureDatabase(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString)); ;

            builder.Services.AddDbContext<MyActiveLifeDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            return builder;
        }
    }
}
