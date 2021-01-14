using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebPhotoHostL.Models;
using WebPhotoHostL.Services;

namespace WebPhotoHostGeneral.Pages
{
    public class AdminlModel : PageModel
    {
        private readonly IAdminRepository _adminRepository;
        private AppDbContext _db;
        public string Msg { get; set; }

        public AdminlModel(AppDbContext db, IAdminRepository adminRepository)
        {
            _db = db;
            _adminRepository = adminRepository;
        }

        public void OnGet()
        {

        }

        /*public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("username");
            return Page();
        }*/

        public IActionResult OnPost(string username, string password, AdminAccount suser) //ÂÕÎÄ---------------
        {
            if (_adminRepository.Checkk(username, password) != null)//ìåòîä ïðîâåðêè check 
            {
                HttpContext.Session.SetString("admin", username);//---------------

                var claims = new List<Claim>// ÄÀÅÒÑß ÐÎËÜ ÄËß ÀÂÒÎÐÈÇÀÖÈÈ-------
                {
                new Claim(ClaimTypes.Name, suser.Username)
                };

                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                HttpContext.SignInAsync(principal);//-------------
                return RedirectToPage("Welcome");

            }
            else
            {
                Msg = "Invalid";
                return Page();
            }
        }

        /*private User Check(string username, string password)
        {
            User account = db.User.SingleOrDefault(a => a.Username.Equals(username));
            if (account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, account.Password))
                {
                    return account;
                }
            }
            return null;
        }*/

        /*public async Task<IActionResult> OnPostRole(User username)
        {
            /*if (!ModelState.IsValid)
            {
                return Page();
            }*/

        /* if(!IsUserAuthenticated(inputModel.Username, inputModel.Password))
         {
             ModelState.AddModelError(string.Empty, "Invalid name or password");
             return Page();
         }*/

        /*var claims = new List<Claim>// ÇÄÅÑÜ
        {
            new Claim(ClaimTypes.Name, username.Username)
        };

        var userIdentity = new ClaimsIdentity(claims, "login");
        ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
        await HttpContext.SignInAsync(principal);

        return Redirect("/");

    }*/

        public async Task<IActionResult> OnPostLogout() // ÂÛÕÎÄ------------
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Adminl");//-------------------
        }

        /* private bool IsUserAuthenticated(string username, string password)
         {
             return true;
         }*/
    }
}
