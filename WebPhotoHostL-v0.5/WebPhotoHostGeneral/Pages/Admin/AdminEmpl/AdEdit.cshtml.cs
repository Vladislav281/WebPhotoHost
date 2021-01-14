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

namespace WebPhotoHostGeneral.Pages.Admin.AdminEmpl
{
    [Authorize]
    public class AdEditModel : PageModel
    {
        private readonly IPublicationRepository _publicationRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdEditModel(IPublicationRepository publicationRepository, IWebHostEnvironment webHostEnvironment) // 2-й параметр IWebHostEnvironment для получение пути к www.root 
        {
            _publicationRepository = publicationRepository; //зависимость бд
            _webHostEnvironment = webHostEnvironment;
        }
        [BindProperty]
        public Publication Publication { get; set; } //переменная, хранящая данные о публикации 

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
        //для отправки информации на сервер используется POST
        public IActionResult OnPost()
        {
            if (ModelState.IsValid) // проверка валидности
            {


                if (Photo != null)
                {
                    if (Publication.PhotoPath != null) //если фото не равняется null(удаление)
                    {
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", Publication.PhotoPath); //присваивется путь фото (путь к www.root, папка images, название фото)
                        if (Publication.PhotoPath != "noimage.png") //проверка на noimage
                            System.IO.File.Delete(filePath); //удаление 
                    }

                    Publication.PhotoPath = ProcessUploadFile();
                }

                //Tempdata для вывода уведомлений на ленте
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
                return RedirectToPage("/Admin/AdminEmpl/AdPublications");
            }
            return Page();

        }

        //Уведомления
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
            string uniqueFileName = null; //уникальное имя
            if (Photo != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images"); //1-е возвращает путь к фото, сохраняет в папку images
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName; //уникальное имя фото присваеивается код Guid = код_имя.
                string filePath = Path.Combine(uploadsFolder, uniqueFileName); //комбинирование полного пути 

                using (var fs = new FileStream(filePath, FileMode.Create)) // 1-е куда сохранять фото, 2-е создает файл
                {
                    Photo.CopyTo(fs); // копируем фото на сервер по обозначенному пути
                }
            }
            return uniqueFileName; // возвращаем уникальное имя
        }
    }
}
