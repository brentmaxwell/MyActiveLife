using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using MyActiveLife.Library.Api;
using MyActiveLife.Apis.Strava.Clients;

namespace MyActiveLife.Web.Controllers
{
    public class Strava : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IUserStore<IdentityUser> _userStore;

        public Strava(
            IConfiguration configuration,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IUserStore<IdentityUser> userStore)
        {
            _configuration = configuration;
            _userManager = userManager;
            _signInManager = signInManager;
            _userStore = userStore;
        }
        
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var token = await _userManager.GetAuthenticationTokenAsync(user, "Strava", "access_token");
            var client = new ActivityClient(token);
            var activities = await client.GetAsync();
            var staticMapToken = _configuration.GetSection("ApiKeys")["GoogleStaticMaps"];

            foreach(var activity in activities)
            {
                activity.StaticMap = new Apis.Google.StaticMap(staticMapToken)
                {
                    Height = 400,
                    Width = 400,
                    Path = new Apis.Google.Path()
                    {
                        PathLine = "enc:" + activity.Map.SummaryPolyline
                    }
                };
            }

            return View(activities);
        }
    }
}
