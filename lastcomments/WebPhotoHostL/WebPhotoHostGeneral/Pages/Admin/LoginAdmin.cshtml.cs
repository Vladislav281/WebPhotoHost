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

namespace WebPhotoHostGeneral.Pages.Admin
{
    public class LoginAdminModel : PageModel
    {
        private readonly IAdminRepository _adminRepository;
        private AppDbContext _db;
        public string Msg { get; set; }

        public LoginAdminModel(AppDbContext db, IAdminRepository adminRepository)
        {
            _db = db;
            _adminRepository = adminRepository;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost(string username, string password, AdminAccount suser) //¬’Œƒ---------------
        {
            if (_adminRepository.Checkk(username, password) != null)//ÏÂÚÓ‰ ÔÓ‚ÂÍË check 
            {
                HttpContext.Session.SetString("username", username);//---------------

                var claims = new List<Claim>// ƒ¿≈“—ﬂ –ŒÀ‹ ƒÀﬂ ¿¬“Œ–»«¿÷»»-------
                {
                new Claim(ClaimTypes.Name, suser.Username)
                };

                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                HttpContext.SignInAsync(principal);//-------------
                return RedirectToPage("/Admin/AdminEmpl/AdPublications");

            }
            else
            {
                Msg = "Invalid";
                return Page();
            }
        }


        public async Task<IActionResult> OnPostLogout() // ¬€’Œƒ------------
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Login");//-------------------
        }
    }
}
