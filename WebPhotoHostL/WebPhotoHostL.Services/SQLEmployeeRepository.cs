using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebPhotoHostL.Models;

namespace WebPhotoHostL.Services
{ //методы реальной бд
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public SQLEmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public Employee Add(Employee newEmployee)
        {
            _context.Employees.Add(newEmployee);
            _context.SaveChanges();
            return newEmployee;
        }

        public Employee Delete(int id)
        {
            var employeeToDelete = _context.Employees.Find(id);
            if(employeeToDelete != null)
            {
                _context.Employees.Remove(employeeToDelete);
                _context.SaveChanges();
            }
            return employeeToDelete;
        }

        public IEnumerable<DeptHeadCount> EmployeeCountByDept(Dept? dept)
        {
            IEnumerable<Employee> query = _context.Employees;

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
            return _context.Employees;
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.Find(id);
        }

        public IEnumerable<Employee> Search(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return _context.Employees;

            return _context.Employees.Where(x => x.Name.ToLower().Contains(searchTerm.ToLower()) || x.Email.Contains(searchTerm.ToLower()));
        }

        public Employee Update(Employee updatedEmployee)
        {
            var employee = _context.Employees.Attach(updatedEmployee);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updatedEmployee;
        }
    }
}
