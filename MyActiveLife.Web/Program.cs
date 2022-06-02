using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyActiveLife.Web.Data;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();;

// Add services to the container.
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

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



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
