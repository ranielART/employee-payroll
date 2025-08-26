using employee_payroll.Models.DTO;
using employee_payroll.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_payroll.IRepositories
{
    public interface IPayrollRepository
    {
        public Task<bool> PayEmployee(Payroll payroll);
        public Task<List<PayrollHistoryDto>> GetAllPayrolls();

        public Task<List<Employee>> GetEmployeesEligibleForPayment();

        public Task RefreshData();

        Task<List<PayrollHistoryDto>> GetPayrollsByDateRange(DateTime fromDate, DateTime toDate);

        Task<List<PayrollHistoryDto>> GetPayrollsByEmployeeId(int employeeId);
    }
}
