using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MyActiveLife.Web.Models;
using MyActiveLife.Library;
using MyActiveLife.Apis.Strava.Clients;
using MyActiveLife.Apis.Strava.Entities;
using MyActiveLife.Web.Extensions;

namespace MyActiveLife.Web.Controllers
{
    public class Strava : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly IMapper _mapper;
        private readonly IConfigurationSection _clientKeys;

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
            _clientKeys = _configuration.GetSection("Authentication:Strava");
        }
        
        public async Task<IActionResult> Index(int page = 1)
        {
            var user = await _userManager.GetUserAsync(User);
            var token = await _userManager.GetAccessToken(user,"Strava", _clientKeys["ClientId"], _clientKeys["ClientSecret"]);
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
    }
}
