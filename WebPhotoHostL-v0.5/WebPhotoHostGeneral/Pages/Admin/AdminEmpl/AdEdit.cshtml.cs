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

        public AdEditModel(IPublicationRepository publicationRepository, IWebHostEnvironment webHostEnvironment) // 2-� �������� IWebHostEnvironment ��� ��������� ���� � www.root 
        {
            _publicationRepository = publicationRepository; //����������� ��
            _webHostEnvironment = webHostEnvironment;
        }
        [BindProperty]
        public Publication Publication { get; set; } //����������, �������� ������ � ���������� 

        //�������� �������� �� ���� post ������� 
        [BindProperty]
        public IFormFile Photo { get; set; }

        [BindProperty]
        public bool Notify { get; set; }

        public string Message { get; set; }
        // ��������� ���������� 
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
        //��� �������� ���������� �� ������ ������������ POST
        public IActionResult OnPost()
        {
            if (ModelState.IsValid) // �������� ����������
            {


                if (Photo != null)
                {
                    if (Publication.PhotoPath != null) //���� ���� �� ��������� null(��������)
                    {
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", Publication.PhotoPath); //������������ ���� ���� (���� � www.root, ����� images, �������� ����)
                        if (Publication.PhotoPath != "noimage.png") //�������� �� noimage
                            System.IO.File.Delete(filePath); //�������� 
                    }

                    Publication.PhotoPath = ProcessUploadFile();
                }

                //Tempdata ��� ������ ����������� �� �����
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

        //�����������
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
            string uniqueFileName = null; //���������� ���
            if (Photo != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images"); //1-� ���������� ���� � ����, ��������� � ����� images
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName; //���������� ��� ���� �������������� ��� Guid = ���_���.
                string filePath = Path.Combine(uploadsFolder, uniqueFileName); //�������������� ������� ���� 

                using (var fs = new FileStream(filePath, FileMode.Create)) // 1-� ���� ��������� ����, 2-� ������� ����
                {
                    Photo.CopyTo(fs); // �������� ���� �� ������ �� ������������� ����
                }
            }
            return uniqueFileName; // ���������� ���������� ���
        }
    }
}
