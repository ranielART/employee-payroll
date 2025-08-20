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
        public Task PayEmployee(Payroll payroll);
        public Task<List<PayrollHistoryDto>> GetAllPayrolls();

         
    }
}
