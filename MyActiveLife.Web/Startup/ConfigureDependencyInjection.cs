using MyActiveLife.Apis.Weather;
using System.Reflection;

namespace MyActiveLife.Web.Startup
{
    public static partial class Startup
    {
        public static WebApplicationBuilder ConfigureDependencyInjection(this WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
            builder.Services.AddSingleton<IWeatherService>(new WeatherClient());

            return builder;
        }
    }
}
