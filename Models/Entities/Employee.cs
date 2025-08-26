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
        protected Employee() { }
        public Employee(string name, string email, string position, Boolean is_active, DateTime? date_hired = null) : base(name, email)
        {
            this.is_active = is_active;
            this.date_hired = date_hired ?? DateTime.Now;
            this.position = position;
            SetEmail(email);
        }

        [Required(ErrorMessage = "Position is required.")]
        public string position { get; private set; }
        public Boolean is_active { get; private set; } = true;


        public List<Payroll> payroll_history { get; set; } = new List<Payroll>(); 



        [Required(ErrorMessage = "Date hired is required.")]
        public DateTime date_hired { get; private set; }

        public DateTime? last_payment_date { get; private set; }


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


        public void SetDateHired(DateTime hireDate)
        {
            this.date_hired = hireDate;
        }

        public void RecordPayment(DateTime paymentDate)
        {
            this.last_payment_date = paymentDate;
        }

        public bool IsEligibleForPaymentToday()
        {
            if (!is_active)
                return false;

            if (!last_payment_date.HasValue)
            {
                return (DateTime.Today - date_hired.Date).TotalDays >= 15;
            }

            return (DateTime.Today - last_payment_date.Value.Date).TotalDays >= DaysUntilNextPayment() &&
                   last_payment_date.Value.Date != DateTime.Today;
        }

        public int DaysUntilNextPayment()
        {
            if (!is_active)
                return -1; 

            DateTime referenceDate = last_payment_date ?? date_hired;
            int daysPassed = (int)(DateTime.Today - referenceDate.Date).TotalDays;

            if (daysPassed >= 15)
                return 0; 

            return 15 - daysPassed;
        }




    }


}
