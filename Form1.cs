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


            fromDp.Value = DateTime.Today.AddMonths(-1); // Last Month
            toDp.Value = DateTime.Today;


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

        public async Task loadEmployees()
        {

            addButton.Enabled = true;
            employeeIdColumn.DataPropertyName = "id";
            employeeNameColumn.DataPropertyName = "name";
            employeeEmailColumn.DataPropertyName = "email";
            employeePositonColumn.DataPropertyName = "position";
            employeesDateHiredColumn.DataPropertyName = "DateHiredFormatted";
            employeeLastPaidColumn.DataPropertyName = "LastPaidFormatted";
            employeeDaysLeftColumn.DataPropertyName = "DaysUntilNextPayment";

            salaryEmployeeId.DataPropertyName = "id";
            salaryName.DataPropertyName = "name";
            salaryEmail.DataPropertyName = "email";
            salaryPosition.DataPropertyName = "position";
            salaryDateHired.DataPropertyName = "DateHiredFormatted";
            salaryLastPaid.DataPropertyName = "LastPaidFormatted";
            salaryDaysLeft.DataPropertyName = "DaysUntilNextPayment";


            employeesTable.DataSource = null;
            salaryTable.DataSource = null;


            var employees = await employeeRepository.GetAllEmployees();

            if (employees != null && employees.Count > 0)
            {

                var formattedEmployees = employees.Select(e => new
                {
                    e.id,
                    e.name,
                    e.email,
                    e.position,
                    e.date_hired,
                    DateHiredFormatted = e.date_hired.ToShortDateString(),
                    LastPaidFormatted = e.last_payment_date.HasValue ? e.last_payment_date.Value.ToShortDateString() : "Never paid",
                    DaysUntilNextPayment = e.DaysUntilNextPayment()
                }).ToList();

                employeesTable.DataSource = formattedEmployees;
                salaryTable.DataSource = formattedEmployees;
            }


            if (employeesTable.Rows.Count > 0)
            {
                employeesTable.ClearSelection();
                salaryTable.ClearSelection();
            }
            isInitialLoad = false;


            await loadPayrollEmployees();
        }

        public async Task loadArchiveEmployees()
        {
            archiveIdColumn.DataPropertyName = "id";
            archiveNameColumn.DataPropertyName = "name";
            archiveEmailColumn.DataPropertyName = "email";
            archivePositionColumn.DataPropertyName = "position";

            await loadArchivePeople(archiveTable);


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
            payrollLastPaidColumn.DataPropertyName = "LastPaymentFormatted";
            paryollSalaryColumn.DataPropertyName = "Salary";

            payrollTable.DataSource = null;

            var employees = await payrollRepository.GetEmployeesEligibleForPayment();

            // Always provide a list (even if empty) to prevent empty row display
            var employeesWithSalary = new List<dynamic>();

            if (employees != null && employees.Count > 0)
            {
                employeesWithSalary = employees.Select(e => new
                {
                    e.id,
                    e.name,
                    e.position,
                    e.last_payment_date,
                    LastPaymentFormatted = e.last_payment_date.HasValue
                        ? e.last_payment_date.Value.ToShortDateString()
                        : "Never paid",
                    DaysUntilNextPayment = e.DaysUntilNextPayment(),
                    Salary = positionSalaries.TryGetValue(e.position, out decimal salary) ? salary : 0m
                }).ToList<dynamic>();
            }

            payrollTable.DataSource = employeesWithSalary;

            if (payrollTable.Rows.Count > 0)
            {
                payrollTable.ClearSelection();
            }
            isInitialPayrollLoad = false;
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

        public async Task loadArchivePeople(DataGridView dataTable)
        {


            dataTable.DataSource = null;


            var employees = await employeeRepository.GetAllArchivedEmployees();

            dataTable.DataSource = employees;

            if (dataTable.Rows.Count > 0)
            {
                dataTable.ClearSelection();
            }
            isInitialLoad = false;
        }


        public void clearEmployeeFields()
        {
            employeeIdLabel.Text = "N/A";
            addButton.Enabled = true;
            editButton.Enabled = false;
            //viewHistory.Enabled = false;
            employeeDateHiredTxt.Text = DateTime.Now.ToShortDateString();
            //employeeIdTxt.Text = string.Empty;
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
                await loadHistory();
                await loadPayrollEmployees();
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
                //viewHistory.Enabled = true;
                DataGridViewRow selectedRow = employeesTable.SelectedRows[0];


                //employeeIdTxt.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                employeeeNameTxt.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                employeeEmailTxt.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                employeeDateHiredTxt.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                employeeIdLabel.Text = selectedRow.Cells[0].Value?.ToString() ?? "N/A";

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
            employeeDateHiredTxt.Text = DateTime.Now.ToShortDateString();
            clearEmployeeFields();
            employeesTable.ClearSelection();
            employeePositionCb.SelectedIndex = 0;
            employeePositionCb.Refresh();
            editButton.Enabled = false;
            //viewHistory.Enabled = false;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            editButton.Enabled = false;
            //viewHistory.Enabled = false;
            viewPayHistory.Enabled = false;
            payEmployeeButton.Enabled = false;
            employeeDateHiredTxt.Text = DateTime.Now.ToShortDateString();
            await loadEmployees();
            await loadArchiveEmployees();
            await loadPayrollEmployees();
            await loadHistory();
        }

        private async void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                validateEmployeeFields();

                //int employeeId = int.Parse(employeeIdTxt.Text.Trim());
                if (employeeIdLabel.Text.Equals("N/A"))
                {
                    MessageBox.Show("Please select an employee to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int employeeId = int.Parse(employeeIdLabel.Text.Trim());


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

                await employeeRepository.UpdateEmployee(currentEmployee);


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


                if (employeeIdLabel.Text.Equals("N/A"))
                {
                    MessageBox.Show("Please select an employee to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int employeeId = int.Parse(employeeIdLabel.Text.Trim());

                var currentEmployee = await employeeRepository.GetEmployeeById(employeeId);
                if (currentEmployee == null)
                {
                    MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await employeeRepository.DeleteEmployee(employeeId);
                MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await loadEmployees();
                await loadPayrollEmployees();
                await loadArchiveEmployees();
                clearEmployeeFields();

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
            try
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
                await loadPayrollEmployees(); // Refresh the payroll table to remove paid employees
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Payment failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void clearHistoryFields()
        {

            historyDateTxt.Text = string.Empty;
            historyNameTxt.Text = string.Empty;
            historyPositionTxt.Text = string.Empty;
            historyAmountTxt.Text = string.Empty;
            historyTable.ClearSelection();

        }

        private async void historyClearButton_Click(object sender, EventArgs e)
        {
            fromDp.Value = DateTime.Today.AddMonths(-1); // Last Month
            toDp.Value = DateTime.Today;
            await loadHistory();
            clearHistoryFields();
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

                await loadEmployees();
                await loadArchiveEmployees();

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

        private async void payEmployeeButton_Click(object sender, EventArgs e)
        {
            try
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
                await loadEmployees();
                await loadPayrollEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Payment failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void materialButton1_Click_1(object sender, EventArgs e)
        {


            payrollTable.ClearSelection();
            employeesTable.ClearSelection();
            archiveTable.ClearSelection();
            historyTable.ClearSelection();

            await employeeRepository.RefreshData();
            await payrollRepository.RefreshData();
            await loadPayrollEmployees();
            await loadEmployees();
            await loadHistory();
            await loadArchiveEmployees();

        }

        private async void applyFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                clearHistoryFields();

                DateTime fromDate = fromDp.Value.Date;
                DateTime toDate = toDp.Value.Date.AddDays(1).AddTicks(-1); // Include the entire 'to' date

                if (fromDate > toDate)
                {
                    MessageBox.Show("From date must be before or equal to To date",
                                   "Invalid Date Range",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                    return;
                }

                await LoadFilteredHistory(fromDate, toDate);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadFilteredHistory(DateTime fromDate, DateTime toDate)
        {
            historyDateColumn.DataPropertyName = "date";
            historyEmployeeName.DataPropertyName = "employee_name";
            historyPosition.DataPropertyName = "position";
            historyAmount.DataPropertyName = "amount_paid";

            historyTable.DataSource = null;
            var payrollHistory = await payrollRepository.GetPayrollsByDateRange(fromDate, toDate);

            if (payrollHistory != null && payrollHistory.Count > 0)
            {
                historyTable.DataSource = payrollHistory;
            }
            else
            {
                historyTable.DataSource = new List<PayrollHistoryDto>();
                MessageBox.Show("No payment records found in the selected date range.",
                               "No Data",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
        }

        private async void viewHistory_Click(object sender, EventArgs e)
        {
            if (employeeIdLabel.Text.Equals("N/A"))
            {
                MessageBox.Show("Please select an employee to view history.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int employeeId = int.Parse(employeeIdLabel.Text.Trim());


            var currentEmployee = await employeeRepository.GetEmployeeById(employeeId);

            if (currentEmployee == null)
            {
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var employeeForm = new EmployeeDataFrom(employeeId, payrollRepository, employeeRepository);
            employeeForm.ShowDialog();

        }

        private void salaryTable_SelectionChanged(object sender, EventArgs e)
        {
            if (isInitialLoad)
                return;

            if (salaryTable.SelectedRows.Count > 0)
            {

                viewPayHistory.Enabled = true;
                DataGridViewRow selectedRow = salaryTable.SelectedRows[0];

                salaryNameTxt.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                salaryPositionTxt.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                salaryLastPaidTxt.Text = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
                daysLeftTxt.Text = selectedRow.Cells[6].Value?.ToString() ?? string.Empty;
                salaryIdLabel.Text = selectedRow.Cells[0].Value?.ToString() ?? "N/A";



            }
        }

        private async void viewPayHistory_Click(object sender, EventArgs e)
        {
            if (salaryIdLabel.Text.Equals("N/A"))
            {
                MessageBox.Show("Please select an employee to view history.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int employeeId = int.Parse(salaryIdLabel.Text.Trim());


            var currentEmployee = await employeeRepository.GetEmployeeById(employeeId);

            if (currentEmployee == null)
            {
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var employeeForm = new EmployeeDataFrom(employeeId, payrollRepository, employeeRepository);
            employeeForm.ShowDialog();
        }

        private void salaryClearButton_Click(object sender, EventArgs e)
        {
            salaryIdLabel.Text = "N/A";
            salaryNameTxt.Text = string.Empty;
            salaryPositionTxt.Text = string.Empty;
            salaryLastPaidTxt.Text = string.Empty;
            daysLeftTxt.Text = string.Empty;
            viewPayHistory.Enabled = false;
        }
    }
}
