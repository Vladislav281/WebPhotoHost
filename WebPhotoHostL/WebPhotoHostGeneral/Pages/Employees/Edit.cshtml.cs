using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebPhotoHostL.Models;
using WebPhotoHostL.Services;

namespace WebPhotoHostGeneral.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EditModel(IEmployeeRepository employeeRepository, IWebHostEnvironment webHostEnvironment)
        {
            _employeeRepository = employeeRepository;
            _webHostEnvironment = webHostEnvironment;
        }
        [BindProperty]
        public Employee Employee { get; set; }

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
                Employee = _employeeRepository.GetEmployee(id.Value);
            else
                Employee = new Employee();

            if (Employee == null)
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
                    if (Employee.PhotoPath != null)
                    {
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", Employee.PhotoPath);
                        if(Employee.PhotoPath != "noimage.png")
                            System.IO.File.Delete(filePath);
                    }

                    Employee.PhotoPath = ProcessUploadFile();
                }

                if (Employee.Id > 0)
                {
                    Employee = _employeeRepository.Update(Employee);
                    TempData["SuccessMessage"] = $"Update {Employee.Name} successful!";
                }
                else
                {
                    Employee = _employeeRepository.Add(Employee);
                    TempData["SuccessMessage"] = $"Adding {Employee.Name} successful!";
                }
                return RedirectToPage("Employees");
            }
                return Page();
           
        }

        public void OnPostUpdateNotificationPreferences(int id)
        {
            if (Notify)
                Message = "Thank you for turning on notification";
            else
                Message = "You have turned off email notification";
            Employee = _employeeRepository.GetEmployee(id);
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
