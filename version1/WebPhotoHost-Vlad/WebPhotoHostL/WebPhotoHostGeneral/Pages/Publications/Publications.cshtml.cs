using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using WebPhotoHostL.Models;
using WebPhotoHostL.Services;



namespace WebPhotoHostGeneral.Pages.Publications
{
    public class PublicationsModel : PageModel
    {
        private readonly IPublicationRepository _db;
        public PublicationsModel(IPublicationRepository db)
        {
            _db = db;
        }

        public IEnumerable<Publication> Publications { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public void OnGet()
        {
            Publications = _db.Search(SearchTerm);
        }
    }
}
