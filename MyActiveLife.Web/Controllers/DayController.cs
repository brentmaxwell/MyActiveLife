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
    public class DayController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly MyActiveLifeDbContext _context;
        private readonly IMapper _mapper;

        public DayController(
            IConfiguration configuration,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IUserStore<IdentityUser> userStore,
            MyActiveLifeDbContext context,
            IMapper mapper)
        {
            _configuration = configuration;
            _userManager = userManager;
            _signInManager = signInManager;
            _userStore = userStore;
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<IActionResult> Index(int page = 1)
        {
            var user = await _userManager.GetUserAsync(User);
            var userId = user.Id;
            var staticMapApiKey = _configuration.GetSection("ApiKeys")["GoogleStaticMaps"];
            var days = _context.Days.OrderByDescending(x => x.Date).Skip(page*20).Take(20).ToList();
            var dayModel = _mapper.Map<List<Day>,List<DayModel>>(days);
            dayModel.ForEach(x =>
            {
                x.Activities.ForEach(y => 
                {
                    y.Map.ApiKey = staticMapApiKey;
                });
            });

            return View(dayModel);
        }
    }
}
