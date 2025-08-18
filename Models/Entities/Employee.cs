using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace employee_payroll.Models.Entities
{
    public class Employee : Person 
    {

        public Employee(string name, string email, string position, Boolean is_active) : base(name, email)
        {
            this.is_active = is_active;
            this.position = position;
            SetEmail(email);
        }
        [Required(ErrorMessage = "Position is required.")]
        public string position { get; private set; }
        public Boolean is_active { get; private set; } = true;

        public List<Payroll> payroll_history { get; set; } = new List<Payroll>(); 

        public override string DisplayInfo()
        {
            return $"ID: {this.id} | Name: {this.name} | Email: {this.email} | Position: {this.position}";
        }

        public override void SetEmail(string email)
        {
            if (Regex.IsMatch(email, @"^[\w\.-]+@company\.com\.ph$"))
            {
                base.SetEmail(email);
            }
            else
            {
                throw new ArgumentException("Email must be a valid company email ending with @company.com.ph.");
            }
        }

        public void SetPosition(string position)
        {
            this.position = position;
        }

        public void SetStatus(Boolean is_active)
        {
            this.is_active = is_active;
        }

    }


}
