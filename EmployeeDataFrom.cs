using employee_payroll.IRepositories;
using employee_payroll.Models.DTO;
using employee_payroll.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_payroll
{
    public partial class EmployeeDataFrom : MaterialForm
    {

        private readonly int employeeId;
        private readonly IPayrollRepository payrollRepository;
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeDataFrom(int employeeId, IPayrollRepository payrollRepository, IEmployeeRepository employeeRepository)
        {
            InitializeComponent();
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            this.employeeId = employeeId;
            this.payrollRepository = payrollRepository;
            this.employeeRepository = employeeRepository;
        }

        private void EmployeeDataFrom_Load(object sender, EventArgs e)
        {
            loadEmployeeData();
        }



        public async void loadEmployeeData()
        {
            try
            {

                var employee = await employeeRepository.GetEmployeeById(employeeId);
                var employeePayrolls = await payrollRepository.GetPayrollsByEmployeeId(employeeId);

                idLabel.Text = employee.id.ToString();
                nameLabel.Text = employee.name;
                emailLabel.Text = employee.email;
                positionLabel.Text = employee.position;
                dateHiredLabel.Text = employee.date_hired.ToString("MMMM dd, yyyy");
                lastPaidLabel.Text = employee.last_payment_date?.ToString("MMMM dd, yyyy") ?? "N/A";
                payDaysLabel.Text = employee.DaysUntilNextPayment().ToString();

                historyDateColumn.DataPropertyName = "date";
                historyPosition.DataPropertyName = "position";
                historyAmount.DataPropertyName = "amount_paid";

                historyTb.DataSource = null;
                var payrollHistory = await payrollRepository.GetPayrollsByEmployeeId(employeeId);

                var formattedPayrollHistory = payrollHistory.Select(p => new
                {
                    date = p.date.ToShortDateString(),
                    employee_name = p.employee_name,
                    position = p.position,
                    amount_paid = decimal.Parse(p.amount_paid).ToString("C2")
                }).ToList();


                if (payrollHistory != null && payrollHistory.Count > 0)
                {
                    historyTb.DataSource = payrollHistory;
                }
                else
                {
                    historyTb.DataSource = new List<PayrollHistoryDto>();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employee data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
