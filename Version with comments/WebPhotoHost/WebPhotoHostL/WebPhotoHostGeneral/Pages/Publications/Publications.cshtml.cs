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
        private readonly IPublicationRepository _db; //приватное поле доступа к базе данных 
        public PublicationsModel(IPublicationRepository db) //передача интерфейса из Services, зависимость базы данных 
        {
            _db = db; //инициализация, из констрктора передаются парметры в переменную
        }

        public IEnumerable<Publication> Publications { get; set; } //свойство модели для использования в представлении
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public void OnGet()
        {
            Publications = _db.Search(SearchTerm); //присваивается метод 
        }
    }
}
