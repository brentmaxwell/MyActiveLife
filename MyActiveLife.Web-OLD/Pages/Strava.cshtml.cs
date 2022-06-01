using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyActiveLife.Web.Pages
{
    public class StravaModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public StravaModel(UserManager<IdentityUser> userManager)
        {
            _userManager= userManager;
        }

        public void OnGet()
        {
            //_userManager.GetAuthenticationTokenAsync(User, "Strava",)    
            //var client = new ApiClient(User.Identities.SingleOrDefault(x => x.Name == "Strava").)
        }
    }
}
