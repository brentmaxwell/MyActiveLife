using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MyActiveLife.Web.Models;
using MyActiveLife.Library;
using MyActiveLife.Apis.Strava.Clients;
using MyActiveLife.Apis.Strava.Entities;
using MyActiveLife.Web.Extensions;
using MyActiveLife.Database;
using MyActiveLife.Database.Entities;
using MyActiveLife.Apis.Weather;

namespace MyActiveLife.Web.Controllers
{
    public class StravaController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly MyActiveLifeDbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfigurationSection _clientKeys;
        private readonly IWeatherService _weatherClient;

        public StravaController(
            IConfiguration configuration,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IUserStore<IdentityUser> userStore,
            MyActiveLifeDbContext context,
            IMapper mapper,
            IWeatherService weatherClient)
        {
            _configuration = configuration;
            _userManager = userManager;
            _signInManager = signInManager;
            _userStore = userStore;
            _context = context;
            _mapper = mapper;
            _clientKeys = _configuration.GetSection("Authentication:Strava");
            _weatherClient = weatherClient;
        }
        
        public async Task<IActionResult> Index(int page = 1)
        {
            var user = await _userManager.GetUserAsync(User);
            var userId = user.Id;
            var staticMapApiKey = _configuration.GetSection("ApiKeys")["GoogleStaticMaps"];
            var activities = _context.StravaActivities.OrderByDescending(x => x.StartDateTime).Skip((page - 1)*30).Take(30).ToList();
            var activityModel = _mapper.Map<ICollection<StravaActivity>, List<StravaActivityModel>>(activities);

            activityModel.ForEach(x =>
            {
                x.Map.ApiKey = staticMapApiKey;
            });

            return View(activityModel);
        }

        public async Task<IActionResult> Refresh()
        {
            var user = await _userManager.GetUserAsync(User);
            var token = await _userManager.GetAccessToken(user, "Strava", _clientKeys["ClientId"], _clientKeys["ClientSecret"]);
            var client = new ActivityClient(token);
            var numberOfRecords = 0;
            var numberOfActivities = 1;
            while(numberOfActivities > 0)
            {
                var latestActivityDate = DateTimeExtensions.FromUnixTime(0);
                var latestActivity = _context.StravaActivities.OrderByDescending(x => x.StartDateTime).FirstOrDefault();
                if (latestActivity != null)
                {
                    latestActivityDate = latestActivity.StartDateTime;
                }
                var activities = await client.GetAsync(null, latestActivityDate, null, null, false);
                //var staticMapApiKey = _configuration.GetSection("ApiKeys")["GoogleStaticMaps"];            
                var dbActivities = _mapper.Map<ICollection<MyActiveLife.Apis.Strava.Entities.Activity>, List<StravaActivity>>(activities);
                var source = _context.Sources.SingleOrDefault(x => x.SourceName == "Strava");
                foreach (var activity in dbActivities)
                {
                    var entry = _context.Days.SingleOrDefault(x => x.Date == activity.StartDateTime.Date);
                    if (entry == null)
                    {
                        entry = new Day()
                        {
                            DayId = new Guid(),
                            UserId = new Guid(user.Id),
                            Date = activity.StartDateTime.Date
                        };
                        _context.Days.Add(entry);
                        await _context.SaveChangesAsync();
                    }
                    activity.DayId = entry.DayId;
                    activity.Source = source;
                    activity.UserId = new Guid(user.Id);
                }
                await _context.AddRangeAsync(dbActivities);
                numberOfActivities = await _context.SaveChangesAsync();
                numberOfRecords += numberOfActivities;
            }
            
            
            return View(numberOfRecords);
        }


    }
}
