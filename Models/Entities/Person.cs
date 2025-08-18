using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_payroll.Models.Entities
{
    public abstract class Person
    {

        protected Person(string name, string email)
        {
            
            this.email = email;
            this.name = name;
        }

        [Required(ErrorMessage = "ID is required")]
        [Key]
        public int id { get; private set; }

        [Required(ErrorMessage = "Name is required")]
        public string name { get; private set; }

        [Required(ErrorMessage = "Email is required")]
        public string email { get; private set; }

        public abstract string DisplayInfo();

        public void SetName(string name)
        {
            this.name = name;
        }

        public virtual void SetEmail(string email)
        {
            this.email = email;
        }
    }
}
