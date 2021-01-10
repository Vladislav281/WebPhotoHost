using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebPhotoHostL.Models;
using WebPhotoHostL.Services;

namespace WebPhotoHostGeneral.Pages.Publications
{
    public class DetailsModel : PageModel
    {
        private readonly IPublicationRepository _publicationRepository;

        public DetailsModel(IPublicationRepository publicationRepository)
        {
            _publicationRepository = publicationRepository;
        }

        public Publication Publication { get; private set; }

        public IActionResult OnGet(int id)
        {
            Publication = _publicationRepository.GetPublication(id);
            if (Publication == null)
                return RedirectToPage("/NotFound");
            return Page();
        }
    }
}
