using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class SignOutModel : PageModel
    {
        public IActionResult OnGet()
        {

            return SignOut("Cookies", "oidc");
        }
    }
}
