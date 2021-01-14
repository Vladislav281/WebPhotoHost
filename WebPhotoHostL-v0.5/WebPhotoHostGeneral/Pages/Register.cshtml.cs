using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPhotoHostL.Models;
using WebPhotoHostL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebPhotoHostGeneral.Pages
{
    public class RegisterModel : PageModel
    {
        private AppDbContext _db;

        [BindProperty]
        public User user { get; set; }

        public RegisterModel(AppDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            user = new User();
        }

        public IActionResult OnPost()
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);//отправка зашифрованного пароля
            
            _db.User.Add(user);//имени
            _db.SaveChanges();
           
            _db.SaveChanges();
            return RedirectToPage("login");
        }
    }
}