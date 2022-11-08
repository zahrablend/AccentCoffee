using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace Shop.Web.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential AccountCredential { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // verify credentials
            if (AccountCredential.UserName == "admin" && AccountCredential.Password == "accenture")
            {
                // create security context
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, "admin"),
                    new Claim(ClaimTypes.Email, "zahrablend@gmail.com"),
                    new Claim("Staff", "Manager")
                };
                //adding claims to identity
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                //encrypt and save into cookie
                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);
                return RedirectToPage("/Index");
            }
            return Page();
        }
        public class Credential
        {
            [Required]
            [Display(Name = "User Name")]
            public string UserName { get; set; } = string.Empty;
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; } = string.Empty;
        }
    }
}
