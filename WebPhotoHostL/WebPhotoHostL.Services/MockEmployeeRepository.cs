using System.Linq;
using WebPhotoHostL.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace WebPhotoHostL.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee()
                {
                    Id = 0,
                    Name = "Mary",
                    Email = "mary@example.com",
                    PhotoPath = "avatar2.png",
                    Department = Dept.HR
                },
                new Employee()
                {
                    Id = 1, Name = "Mark", Email = "mark@example.com", PhotoPath = "avatar.png", Department = Dept.IT
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Kolyan",
                    Email = "demonick@example.com",
                    PhotoPath = "avatar4.png",
                    Department = Dept.IT
                },
                new Employee()
                {
                    Id = 3,
                    Name = "Shawn",
                    Email = "shawn@example.com",
                    PhotoPath = "avatar5.png",
                    Department = Dept.Payroll
                },
                new Employee()
                {
                    Id = 4,
                    Name = "Jenifer",
                    Email = "jenifer@example.com",
                    PhotoPath = "avatar3.png",
                    Department = Dept.HR
                },
                new Employee()
                {
                    Id = 5,
                    Name = "Sten",
                    Email = "sten@example.com",
                    Department = Dept.Payroll
                }
            };
        }

        public Employee Add(Employee newEmployee)
        {
            newEmployee.Id = _employeeList.Max(x => x.Id) + 1;
            _employeeList.Add(newEmployee);
            return newEmployee;
        }

        public Employee Delete(int id)
        {
            Employee employeeToDelete = _employeeList.FirstOrDefault(x => x.Id == id);
            if (employeeToDelete != null)
                _employeeList.Remove(employeeToDelete);
            
            return employeeToDelete;
        }

        public IEnumerable<DeptHeadCount> EmployeeCountByDept(Dept? dept)
        {
            IEnumerable<Employee> query = _employeeList;

            if (dept.HasValue)
                query = query.Where(x => x.Department == dept.Value);

            return query.GroupBy(x => x.Department)
                                .Select(x => new DeptHeadCount()
                                {
                                    Deptepartment = x.Key.Value,
                                    Count = x.Count()
                                }).ToList();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Employee> Search(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return _employeeList;

            return _employeeList.Where(x => x.Name.ToLower().Contains(searchTerm.ToLower()) || x.Email.Contains(searchTerm.ToLower()));
        }

        public Employee Update(Employee updatedEmployee)
        {
            Employee employee = _employeeList.FirstOrDefault(x => x.Id == updatedEmployee.Id);

            if(employee != null)
            {
                employee.Name = updatedEmployee.Name;
                employee.Email = updatedEmployee.Email;
                employee.Department = updatedEmployee.Department;
                employee.PhotoPath = updatedEmployee.PhotoPath;
            }
            return employee;
        }
    }
}
