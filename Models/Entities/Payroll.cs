using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_payroll.Models.Entities
{
    public class Payroll
    {
        [Key]
        public int id { get; private set; }

        [Required(ErrorMessage = "Employee ID is required.")]
        public int employee_id { get; private set; }
        [Required(ErrorMessage = "Employee is required.")]
        public Employee employee { get; private set; } 

        [Required(ErrorMessage = "Amount paid is required.")]
        [Precision(18, 2)]
        public decimal amount_paid { get; private set; }
        
        [Required(ErrorMessage = "Date paid is required.")]
        public DateTime date_paid { get; private set; }

        [Required(ErrorMessage = "Employee position is required.")]
        public string employee_position { get; set; }

        public Payroll() { }
        public Payroll(int employee_id, decimal amount_paid, DateTime date_paid, string employee_position)
        {
            //this.id = id;
            this.employee_id = employee_id;
            this.amount_paid = amount_paid;
            this.date_paid = DateTime.Now;
            this.employee_position = employee_position;
        }


    }
}
