using employee_payroll.Data;
using employee_payroll.IRepositories;
using employee_payroll.Models.DTO;
using employee_payroll.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_payroll.Repositories
{
    public class PayrollRepository : IPayrollRepository
    {

        private readonly ApplicationDbContext dbContext;

        public PayrollRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<PayrollHistoryDto>> GetAllPayrolls()
        {
            var payrolls = await dbContext.payrolls
                .Include(p => p.employee).OrderByDescending(p => p.date_paid)
                .ToListAsync(); 

            
            var payrollHistoryDtos = payrolls.Select(p => new PayrollHistoryDto
            {
                date = p.date_paid,
                employee_name = p.employee.name,
                position = p.employee_position, 
                amount_paid = p.amount_paid.ToString() 
            }).ToList();

            return payrollHistoryDtos;
        }

        public async Task PayEmployee(Payroll payroll)
        {
           await dbContext.payrolls.AddAsync(payroll);
           await dbContext.SaveChangesAsync();
        }
    }
}
