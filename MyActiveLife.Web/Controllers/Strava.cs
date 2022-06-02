﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MyActiveLife.Web.Models;
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
        
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var token = await _userManager.GetAuthenticationTokenAsync(user, "Strava", "access_token");
            var client = new ActivityClient(token);
            var activities = await client.GetAsync();
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
