using employee_payroll.IRepositories;
using employee_payroll.Models.Entities;
using employee_payroll.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;
namespace employee_payroll
{
    public partial class Form1 : MaterialForm
    {

        private readonly IEmployeeRepository employeeRepository;
        private bool isInitialLoad = true;
        public Form1(IEmployeeRepository employeeRepository)
        {

            InitializeComponent();
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            this.employeeRepository = employeeRepository;
            addButton.Enabled = true;
            employeesTable.SelectionChanged += employeesTable_SelectionChanged;
        }

        public Employee getEmployeeFields()
        {
            return new Employee(
                is_active: true,
                name: employeeeNameTxt.Text.Trim(),
                email: employeeEmailTxt.Text.Trim(),
                position: employeePositionCb.Text.Trim()
            );
        }

        public async Task loadEmployees()
        {
            addButton.Enabled = true;
            employeeIdColumn.DataPropertyName = "id";
            employeeNameColumn.DataPropertyName = "name";
            employeeEmailColumn.DataPropertyName = "email";
            employeePositonColumn.DataPropertyName = "position";

            await loadPeople(employeesTable);
            await loadPayrollEmployees();
        }

        public async Task loadPayrollEmployees()
        {

            Dictionary<string, decimal> positionSalaries = new Dictionary<string, decimal>
            {
                { "Software Engineer", 35000m },
                { "DevOps Engineer", 45000m },
                { "Tech Lead", 70000m },
                { "Front-end Developer", 28000m },
                { "Backend Developer", 29000m },
                { "Intern", 15000m }
            };


            payrollIdColumn.DataPropertyName = "id";
            payrollNameColumn.DataPropertyName = "name";
            payrollPositionColumn.DataPropertyName = "position";


            paryollSalaryColumn.DataPropertyName = "Salary";


            payrollTable.DataSource = null;


            var employees = await employeeRepository.GetAllEmployees();
            if (employees != null && employees.Count > 0)
            {
                var employeesWithSalary = employees.Select(e => new
                {
                    e.id,
                    e.name,
                    e.position,
                    Salary = positionSalaries.TryGetValue(e.position, out decimal salary) ? salary : 0m
                }).ToList();

                
                payrollTable.DataSource = employeesWithSalary;

                if (payrollTable.Rows.Count > 0)
                {
                    payrollTable.ClearSelection();
                }
            }

        }

        public async Task loadPeople(DataGridView dataTable)
        {
            dataTable.DataSource = null;
            var employees = await employeeRepository.GetAllEmployees();
            dataTable.DataSource = employees;

            if (dataTable.Rows.Count > 0)
            {
                dataTable.ClearSelection();
            }
            isInitialLoad = false;
        }

        //public void enableAddButton(Boolean status)
        //{
        //    addButton.Enabled = status;
        //}

        public void clearEmployeeFields()
        {
            addButton.Enabled = true;
            editButton.Enabled = false;
            employeeIdTxt.Text = string.Empty;
            employeeeNameTxt.Text = string.Empty;
            employeePositionCb.Text = string.Empty;
            employeeEmailTxt.Text = string.Empty;
            employeePositionCb.SelectedIndex = 0;
            employeePositionCb.Refresh();
        }

        public void validateEmployeeFields()
        {
            if (string.IsNullOrWhiteSpace(employeeeNameTxt.Text) ||
                string.IsNullOrWhiteSpace(employeePositionCb.Text) ||
                string.IsNullOrWhiteSpace(employeeEmailTxt.Text) || employeePositionCb.Text.Equals("Select Position"))
            {
                throw new ArgumentException("All fields are required.");

            }
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            try
            {

                validateEmployeeFields();
                var employee = getEmployeeFields();



                if (await employeeRepository.GetEmployeeByEmail(employee.email) != null)
                {
                    MessageBox.Show("Employee with this email already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await employeeRepository.AddEmployee(employee);

                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await loadEmployees();
                clearEmployeeFields();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void employeesTable_SelectionChanged(object sender, EventArgs e)
        {
            // Skip this event during initial data loading
            if (isInitialLoad)
                return;

            if (employeesTable.SelectedRows.Count > 0)
            {
                addButton.Enabled = false;
                editButton.Enabled = true;
                // Get the selected row
                DataGridViewRow selectedRow = employeesTable.SelectedRows[0];

                // Use either column index or the property name mapped in DataPropertyName
                employeeIdTxt.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                employeeeNameTxt.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                employeeEmailTxt.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;

                switch (selectedRow.Cells[3].Value?.ToString())
                {
                    case "Select Position":
                        employeePositionCb.SelectedIndex = 0;
                        break;
                    case "Software Engineer":
                        employeePositionCb.SelectedIndex = 1;
                        break;
                    case "DevOps Engineer":
                        employeePositionCb.SelectedIndex = 2;
                        break;
                    case "Tech Lead":
                        employeePositionCb.SelectedIndex = 3;
                        break;
                    case "Front-end Developer":
                        employeePositionCb.SelectedIndex = 4;
                        break;
                    case "Backend Developer":
                        employeePositionCb.SelectedIndex = 5;
                        break;
                    case "Intern":
                        employeePositionCb.SelectedIndex = 6;
                        break;
                    default:
                        employeePositionCb.SelectedIndex = -1;
                        break;
                }
                employeePositionCb.Refresh();

            }
        }
        private void unselectButton_Click(object sender, EventArgs e)
        {
            //enableAddButton(true);
            addButton.Enabled = true;
            clearEmployeeFields();
            employeesTable.ClearSelection();
            employeePositionCb.SelectedIndex = 0;
            employeePositionCb.Refresh();
            editButton.Enabled = false;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            editButton.Enabled = false;

            await loadEmployees();
            await loadPayrollEmployees();
        }

        private async void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                validateEmployeeFields();

                int employeeId = int.Parse(employeeIdTxt.Text.Trim());

                var currentEmployee = await employeeRepository.GetEmployeeById(employeeId);
                if (currentEmployee == null)
                {
                    MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var updatedEmployee = getEmployeeFields();

                var existingEmployee = await employeeRepository.GetEmployeeByEmail(updatedEmployee.email);
                if (existingEmployee != null && existingEmployee.id != employeeId)
                {
                    MessageBox.Show("Another employee with this email already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                currentEmployee.SetEmail(updatedEmployee.email);
                currentEmployee.SetName(updatedEmployee.name);
                currentEmployee.SetPosition(updatedEmployee.position);

                MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await loadEmployees();
                clearEmployeeFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {

            try
            {
                int employeeId = int.Parse(employeeIdTxt.Text.Trim());

                var currentEmployee = await employeeRepository.GetEmployeeById(employeeId);
                if (currentEmployee == null)
                {
                    MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await employeeRepository.DeleteEmployee(employeeId);
                MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await loadEmployees();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
