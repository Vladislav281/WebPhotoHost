using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebPhotoHostL.Models;
using WebPhotoHostL.Services;

namespace WebPhotoHostGeneral.Pages.Publications
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly IPublicationRepository _publicationRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EditModel(IPublicationRepository publicationRepository, IWebHostEnvironment webHostEnvironment)
        {
            _publicationRepository = publicationRepository;
            _webHostEnvironment = webHostEnvironment;
        }
        [BindProperty]
        public Publication Publication { get; set; }

        //Свойства доступны во всех post методах 
        [BindProperty]
        public IFormFile Photo { get; set; }

        [BindProperty]
        public bool Notify { get; set; }

        public string Message { get; set; }
        // получение информации 
        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
                Publication = _publicationRepository.GetPublication(id.Value);
            else
                Publication = new Publication();

            if (Publication == null)
                return RedirectToPage("/NotFound");
            return Page();
        }
        // отправка информации 
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {


                if (Photo != null)
                {
                    if (Publication.PhotoPath != null)
                    {
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", Publication.PhotoPath);
                        if(Publication.PhotoPath != "noimage.png")
                            System.IO.File.Delete(filePath);
                    }

                    Publication.PhotoPath = ProcessUploadFile();
                }

                if (Publication.Id > 0)
                {
                    Publication = _publicationRepository.Update(Publication);
                    TempData["SuccessMessage"] = $"Update {Publication.Name} successful!";
                }
                else
                {
                    Publication = _publicationRepository.Add(Publication);
                    TempData["SuccessMessage"] = $"Adding {Publication.Name} successful!";
                }
                return RedirectToPage("Publications");
            }
                return Page();
           
        }

        public void OnPostUpdateNotificationPreferences(int id)
        {
            if (Notify)
                Message = "Thank you for turning on notification";
            else
                Message = "You have turned off email notification";
            Publication = _publicationRepository.GetPublication(id);
        }

        private string ProcessUploadFile()
        {
            string uniqueFileName = null;
            if (Photo != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fs = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fs);
                }
            }
            return uniqueFileName;
        }
    }
}
