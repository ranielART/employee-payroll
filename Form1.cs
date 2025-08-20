using employee_payroll.IRepositories;
using employee_payroll.Models.DTO;
using employee_payroll.Models.Entities;
using employee_payroll.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.Threading.Tasks;
namespace employee_payroll
{
    public partial class Form1 : MaterialForm
    {

        private readonly IEmployeeRepository employeeRepository;
        private readonly IPayrollRepository payrollRepository;
        private bool isInitialLoad = true;
        private bool isInitialPayrollLoad = true;
        public Form1(IEmployeeRepository employeeRepository, IPayrollRepository payrollRepository)
        {

            InitializeComponent();
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            this.employeeRepository = employeeRepository;
            this.payrollRepository = payrollRepository;
            addButton.Enabled = true;
            payEmployeeButton.Enabled = true;
            employeesTable.SelectionChanged += employeesTable_SelectionChanged;
            payrollTable.SelectionChanged += payrollTable_SelectionChanged;
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

        public async Task loadHistory()
        {

            historyDateColumn.DataPropertyName = "date";
            historyEmployeeName.DataPropertyName = "employee_name";
            historyPosition.DataPropertyName = "position";
            historyAmount.DataPropertyName = "amount_paid";


            historyTable.DataSource = null;
            var payrollHistory = await payrollRepository.GetAllPayrolls();

            if (payrollHistory != null && payrollHistory.Count > 0)
            {
                historyTable.DataSource = payrollHistory;
            }
            else
            {
                historyTable.DataSource = new List<PayrollHistoryDto>();
            }
        }

        public async Task loadEmployees(Boolean isArchived)
        {



            addButton.Enabled = true;
            employeeIdColumn.DataPropertyName = "id";
            employeeNameColumn.DataPropertyName = "name";
            employeeEmailColumn.DataPropertyName = "email";
            employeePositonColumn.DataPropertyName = "position";

            archiveIdColumn.DataPropertyName = "id";
            archiveNameColumn.DataPropertyName = "name";
            archiveEmailColumn.DataPropertyName = "email";
            archivePositionColumn.DataPropertyName = "position";


            await loadPeople(employeesTable, !isArchived);
            await loadPeople(archiveTable, isArchived);
            await loadPayrollEmployees();
        }

        public async Task loadPayrollEmployees()
        {

            Dictionary<string, decimal> positionSalaries = new Dictionary<string, decimal>
            {
                { "Software Engineer", 35000.00m },
                { "DevOps Engineer", 45000.00m },
                { "Tech Lead", 70000.00m },
                { "Front-end Developer", 28000.00m },
                { "Backend Developer", 29000.00m },
                { "Intern", 15000.00m }
            };


            payrollIdColumn.DataPropertyName = "id";
            payrollNameColumn.DataPropertyName = "name";
            payrollPositionColumn.DataPropertyName = "position";

            paryollSalaryColumn.DataPropertyName = "Salary";

            payrollTable.DataSource = null;

            var employees = await employeeRepository.GetAllEmployees(false);
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

            }
            if (payrollTable.Rows.Count > 0)
            {
                payrollTable.ClearSelection();
            }
            isInitialPayrollLoad = false;

        }

        public async Task loadPeople(DataGridView dataTable, Boolean isArchived)
        {


            dataTable.DataSource = null;


            var employees = await employeeRepository.GetAllEmployees(isArchived);

            dataTable.DataSource = employees;

            if (dataTable.Rows.Count > 0)
            {
                dataTable.ClearSelection();
            }
            isInitialLoad = false;
        }

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

                await loadEmployees(false);
                clearEmployeeFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void employeesTable_SelectionChanged(object sender, EventArgs e)
        {

            if (isInitialLoad)
                return;

            if (employeesTable.SelectedRows.Count > 0)
            {
                addButton.Enabled = false;
                editButton.Enabled = true;

                DataGridViewRow selectedRow = employeesTable.SelectedRows[0];


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

        private void payrollTable_SelectionChanged(object sender, EventArgs e)
        {

            if (isInitialPayrollLoad)
                return;

            if (payrollTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = payrollTable.SelectedRows[0];
                payEmployeeButton.Enabled = true;
                payrollIdTxt.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                payrollNameTxt.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                payrollPositionTxt.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                payrollSalaryTxt.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;

            }

            isInitialPayrollLoad = false;
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
            payEmployeeButton.Enabled = false;

            await loadEmployees(false);
            await loadEmployees(true);
            await loadPayrollEmployees();
            await loadHistory();
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
                await loadEmployees(false);
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

                await loadEmployees(false);
                await loadEmployees(true);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private Payroll getPayrollDetails()
        {
            return new Payroll(
            employee_id: int.Parse(payrollIdTxt.Text.Trim()),
            amount_paid: decimal.Parse(payrollSalaryTxt.Text.Trim()),
            date_paid: DateTime.Now,
            employee_position: payrollPositionTxt.Text.Trim()
            );
        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {

            var employeeId = payrollIdTxt.Text.Trim();
            if (string.IsNullOrEmpty(employeeId) || !int.TryParse(employeeId, out int id))
            {
                MessageBox.Show("Please select a valid employee from the payroll table.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var payrollDetails = getPayrollDetails();

            await payrollRepository.PayEmployee(payrollDetails);
            MessageBox.Show("Employee paid successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            payrollClearFields();
            await loadHistory();


        }

        private void payrollClearButton_Click(object sender, EventArgs e)
        {
            payrollClearFields();
            payEmployeeButton.Enabled = false;

        }

        private void payrollClearFields()
        {
            payrollIdTxt.Text = string.Empty;
            payrollNameTxt.Text = string.Empty;
            payrollPositionTxt.Text = string.Empty;
            payrollSalaryTxt.Text = string.Empty;
            payEmployeeButton.Enabled = false;
            payrollTable.ClearSelection();
        }

        private void historyTable_SelectionChanged(object sender, EventArgs e)
        {
            if (isInitialPayrollLoad)
                return;
            if (historyTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = historyTable.SelectedRows[0];
                historyDateTxt.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                historyNameTxt.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                historyPositionTxt.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                historyAmountTxt.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
            }
            isInitialPayrollLoad = false;
        }

        private void historyClearButton_Click(object sender, EventArgs e)
        {
            historyDateTxt.Text = string.Empty;
            historyNameTxt.Text = string.Empty;
            historyPositionTxt.Text = string.Empty;
            historyAmountTxt.Text = string.Empty;
            historyTable.ClearSelection();
        }

        private async void restoreButton_Click(object sender, EventArgs e)
        { 
            try
            {
                int employeeId = int.Parse(archiveIdTxt.Text.Trim());

                var currentEmployee = await employeeRepository.GetEmployeeById(employeeId);
                if (currentEmployee == null)
                {
                    MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await employeeRepository.RestoreEmployee(employeeId);
                MessageBox.Show("Employee restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await loadEmployees(false);
                await loadEmployees(true);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void archiveClearButton_Click(object sender, EventArgs e)
        {
            restoreButton.Enabled = false;
            archiveIdTxt.Text = string.Empty;
            archiveNameTxt.Text = string.Empty;
            archiveEmailTxt.Text = string.Empty;
            archivePositionCb.SelectedIndex = 0;
            archivePositionCb.Refresh();
            archiveTable.ClearSelection();
        }

        private void archiveTable_SelectionChanged(object sender, EventArgs e)
        {
            if (isInitialPayrollLoad)
                return;
            if (archiveTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = archiveTable.SelectedRows[0];
                restoreButton.Enabled = true;
                archiveIdTxt.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                archiveNameTxt.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                archiveEmailTxt.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                

                switch (selectedRow.Cells[3].Value?.ToString())
                {
                    case "Select Position":
                        archivePositionCb.SelectedIndex = 0;
                        break;
                    case "Software Engineer":
                        archivePositionCb.SelectedIndex = 1;
                        break;
                    case "DevOps Engineer":
                        archivePositionCb.SelectedIndex = 2;
                        break;
                    case "Tech Lead":
                        archivePositionCb.SelectedIndex = 3;
                        break;
                    case "Front-end Developer":
                        archivePositionCb.SelectedIndex = 4;
                        break;
                    case "Backend Developer":
                        archivePositionCb.SelectedIndex = 5;
                        break;
                    case "Intern":
                        archivePositionCb.SelectedIndex = 6;
                        break;
                    default:
                        archivePositionCb.SelectedIndex = -1;
                        break;
                }
                archivePositionCb.Refresh();

            }
            isInitialPayrollLoad = false;
        }
    }
}
