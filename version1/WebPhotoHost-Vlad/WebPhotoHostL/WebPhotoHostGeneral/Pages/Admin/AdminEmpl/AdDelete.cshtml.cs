using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebPhotoHostL.Models;
using WebPhotoHostL.Services;

namespace WebPhotoHostGeneral.Pages.Admin.AdminEmpl
{
    public class AdDeleteModel : PageModel
    {
        private readonly IPublicationRepository _publicationRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdDeleteModel(IPublicationRepository publicationRepository, IWebHostEnvironment webHostEnvironment)
        {
            _publicationRepository = publicationRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        [BindProperty]
        public Publication Publication { get; set; }

        public IActionResult OnGet(int id)
        {
            Publication = _publicationRepository.GetPublication(id);

            if (Publication == null)
                return RedirectToPage("/NotFound");
            return Page();
        }
        public IActionResult OnPost()
        {
            Publication deletedPublication = _publicationRepository.Delete(Publication.Id);
            if (deletedPublication.PhotoPath != null)
            {
                string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", deletedPublication.PhotoPath);
                if (deletedPublication.PhotoPath != "noimage.png")
                    System.IO.File.Delete(filePath);
            }

            if (deletedPublication == null)
                return RedirectToPage("/NotFound");

            return RedirectToPage("/Admin/AdminEmpl/AdPublications");
        }
    }
}
