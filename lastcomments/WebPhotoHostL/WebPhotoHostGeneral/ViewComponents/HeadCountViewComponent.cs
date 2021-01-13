using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPhotoHostL.Models;
using WebPhotoHostL.Services;

namespace WebPhotoHostGeneral.ViewComponents
{
    
    public class HeadCountViewComponent : ViewComponent
    {
        private readonly IPublicationRepository _publicationRepository;

        //конструктор
        public HeadCountViewComponent(IPublicationRepository publicationRepository)
        {
            _publicationRepository = publicationRepository;
        }

        //реализация метода publicationcountbydebt
        public IViewComponentResult Invoke(Dept? department = null)
        {
            var result = _publicationRepository.PublicationCountByDept(department);
            return View(result);
        }
    }
}
