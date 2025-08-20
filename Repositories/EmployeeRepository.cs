using employee_payroll.Data;
using employee_payroll.IRepositories;
using employee_payroll.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_payroll.Repositories
{
    public class EmployeeRepository : IEmployeeRepository 
    { 
        private readonly ApplicationDbContext dbContext;

        public EmployeeRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddEmployee(Employee employee)
        {
            await dbContext.employees.AddAsync(employee);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteEmployee(int id)
        {
            var employee = await dbContext.employees.FirstOrDefaultAsync(e => e.id == id && e.is_active == true);
            employee.SetStatus(false);
            await dbContext.SaveChangesAsync();

        }

        public async Task RestoreEmployee(int id)
        {
            var employee = await dbContext.employees.FirstOrDefaultAsync(e => e.id == id && e.is_active == false);
            employee.SetStatus(true);
            await dbContext.SaveChangesAsync();

        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            var employees = await dbContext.employees.Where(e => e.is_active == true).ToListAsync();  

            return employees;
        }

        public async Task<List<Employee>> GetAllArchivedEmployees()
        {
            var employees = await dbContext.employees.Where(e => e.is_active == false).ToListAsync();  

            return employees;
        }

        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            var employee = await dbContext.employees.FirstOrDefaultAsync(e => e.email == email);

            return employee;
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            var employee = await dbContext.employees.FirstOrDefaultAsync(e => e.id == id);

            return employee;
        }

       
    }
}
