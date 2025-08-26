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

        public async Task<bool> PayEmployee(Payroll payroll)
        {
            // Get the employee
            var employee = await dbContext.employees.FindAsync(payroll.employee_id);

            if (employee == null)
                throw new Exception("Employee not found");

            // Check if eligible for payment today
            if (!employee.IsEligibleForPaymentToday())
                throw new Exception($"Employee {employee.name} is not eligible for payment today.");

            // Set payment date
            payroll.setDatePaid(DateTime.Now);

            // Record the payment
            await dbContext.payrolls.AddAsync(payroll);

            // Update employee's last payment date
            employee.RecordPayment(payroll.date_paid);

            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Employee>> GetEmployeesEligibleForPayment()
        {
            var allActiveEmployees = await dbContext.employees
                .Where(e => e.is_active)
                .ToListAsync();

            return allActiveEmployees.Where(e => e.IsEligibleForPaymentToday()).ToList();
        }

        public async Task RefreshData()
        {
            var trackedEntities = dbContext.ChangeTracker.Entries()
                .Where(e => e.State != EntityState.Detached)
                .ToList();

            foreach (var entry in trackedEntities)
            {
                entry.State = EntityState.Detached;
            }


            await Task.CompletedTask;
        }

        public async Task<List<PayrollHistoryDto>> GetPayrollsByDateRange(DateTime fromDate, DateTime toDate)
        {
            var payrolls = await dbContext.payrolls
                .Include(p => p.employee)
                .Where(p => p.date_paid >= fromDate && p.date_paid <= toDate)
                .OrderByDescending(p => p.date_paid)
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

        public Task<List<PayrollHistoryDto>> GetPayrollsByEmployeeId(int employeeId)
        {
            var employeePayrolls = dbContext.payrolls
                .Include(p => p.employee)
                .Where(p => p.employee_id == employeeId)
                .OrderByDescending(p => p.date_paid)
                .Select(p => new PayrollHistoryDto
                {
                    date = p.date_paid,
                    employee_name = p.employee.name,
                    position = p.employee_position,
                    amount_paid = p.amount_paid.ToString()
                }).ToListAsync();


            return employeePayrolls;
        }
    }
}
