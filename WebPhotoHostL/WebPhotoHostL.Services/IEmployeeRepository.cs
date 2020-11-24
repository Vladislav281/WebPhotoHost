using System;
using System.Collections.Generic;
using System.Text;
using WebPhotoHostL.Models;

namespace WebPhotoHostL.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        Employee Update(Employee updatedEmployee);
        Employee Add(Employee newEmployee);
    }
}
