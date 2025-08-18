using employee_payroll.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_payroll.IRepositories
{
    public interface IEmployeeRepository
    {
        Task AddEmployee(Employee employee); 
        Task<Employee> GetEmployeeById(int id);

        Task<List<Employee>> GetAllEmployees();

        Task DeleteEmployee(int id);

        Task<Employee> GetEmployeeByEmail(string email);
    }
}
