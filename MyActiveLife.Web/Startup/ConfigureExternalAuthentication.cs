using Microsoft.AspNetCore.Authentication;

namespace MyActiveLife.Web.Startup
{
    public static partial class Startup
    {
        public static WebApplicationBuilder ConfigureExternalAuthentication(this WebApplicationBuilder builder)
        {
            builder.Services.AddAuthentication()
                .AddStrava(options =>
                {
                    IConfigurationSection stravaOAuthConfigSection = builder.Configuration.GetSection("Authentication:Strava");
                    options.ClientId = stravaOAuthConfigSection["ClientId"];
                    options.ClientSecret = stravaOAuthConfigSection["ClientSecret"];
                    options.SaveTokens = true;
                    options.Events.OnCreatingTicket = ctx =>
                    {
                        List<AuthenticationToken> tokens = ctx.Properties.GetTokens().ToList();

                        tokens.Add(new AuthenticationToken()
                        {
                            Name = "TicketCreated",
                            Value = DateTime.UtcNow.ToString()
                        });

                        ctx.Properties.StoreTokens(tokens);

                        return Task.CompletedTask;
                    };
                });

            return builder;
        }
    }
}
