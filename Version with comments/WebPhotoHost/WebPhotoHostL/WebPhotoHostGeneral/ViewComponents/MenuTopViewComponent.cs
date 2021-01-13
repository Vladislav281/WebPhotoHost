using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebPhotoHostL.Models;
using WebPhotoHostL.Services;
using System.Threading.Tasks;

namespace BuildECommerceWithASPNETCoreRazorPages.ViewComponents
{
    [ViewComponent(Name = "MenuTop")]
    public class MenuTopViewComponent : ViewComponent
    {
        public string usernameSession { get; set; }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.usernameSession = HttpContext.Session.GetString("username");
            return View("_LoginPartial");
        }
    }
}
