using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MyActiveLife.Web.Models;
using MyActiveLife.Library;
using MyActiveLife.Apis.Strava.Clients;
using MyActiveLife.Apis.Strava.Entities;

namespace MyActiveLife.Web.Controllers
{
    public class Strava : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly IMapper _mapper;

        public Strava(
            IConfiguration configuration,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IUserStore<IdentityUser> userStore,
            IMapper mapper)
        {
            _configuration = configuration;
            _userManager = userManager;
            _signInManager = signInManager;
            _userStore = userStore;
            _mapper = mapper;
        }
        
        public async Task<IActionResult> Index(int page = 1)
        {
            var user = await _userManager.GetUserAsync(User);

            var token = await GetAccessToken(user);
            var client = new ActivityClient(token);
            var activities = await client.GetAsync(null,null,page,null,false);
            var staticMapApiKey = _configuration.GetSection("ApiKeys")["GoogleStaticMaps"];

            var activityModel = _mapper.Map<ICollection<Activity>, List<StravaActivityModel>>(activities);

            activityModel.ForEach(x =>
            {
                x.Map.ApiKey = staticMapApiKey;
            });

            return View(activityModel);
        }

        public async Task<string> GetAccessToken(IdentityUser user)
        {
            var tokenExpires = DateTime.Parse(await _userManager.GetAuthenticationTokenAsync(user, "Strava", "expires_at"));
            if (tokenExpires < DateTime.Now)
            {
                var refreshToken = await _userManager.GetAuthenticationTokenAsync(user, "Strava", "refresh_token");
                var clientKeys = _configuration.GetSection("Authentication:Strava");
                var tokenClient = new TokenClient(clientKeys["ClientId"], clientKeys["ClientSecret"]);
                var authTokens = await tokenClient.RefreshToken(refreshToken);
                foreach (var authToken in authTokens)
                {
                    await _userManager.SetAuthenticationTokenAsync(user, "Strava", authToken.Name, authToken.Value);
                }
            }
            return await _userManager.GetAuthenticationTokenAsync(user, "Strava", "access_token");
        }
    }
}
