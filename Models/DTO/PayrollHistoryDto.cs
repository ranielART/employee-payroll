using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_payroll.Models.DTO
{
    public class PayrollHistoryDto
    {
        public DateTime date { get; set; }
        public string employee_name { get; set; } = string.Empty;

        public string position { get; set; } = string.Empty;

        public string amount_paid { get; set; } = string.Empty;
    }
}
