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
        private readonly IEmployeeRepository _employeeRepository;

        public HeadCountViewComponent(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IViewComponentResult Invoke(Dept? department = null)
        {
            var result = _employeeRepository.EmployeeCountByDept(department);
            return View(result);
        }
    }
}
