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

        public DetailsModel(IPublicationRepository publicationRepository)// в качестве параметра передается интерфейс
        {
            _publicationRepository = publicationRepository;
        }

        public Publication Publication { get; private set; }

        public IActionResult OnGet(int id) //метод принимает параметр id (IActionResult используется для возврата значений)
        {
            Publication = _publicationRepository.GetPublication(id); //применение метода
            if (Publication == null) //если null, то переадресовывает на страницу 404
                return RedirectToPage("/NotFound");
            return Page();//если нет, то возвращает на страницу 
        }
    }
}
