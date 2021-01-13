using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebPhotoHostGeneral.Pages
{
    
    public class IndexModel : PageModel
    {
      
        public IActionResult OnPost()
        {
            return RedirectToPage("Publications/Publications");
        }
    }
}
