namespace employee_payroll
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            imageList1 = new ImageList(components);
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            employeeTab = new TabPage();
            unselectButton = new MaterialSkin.Controls.MaterialButton();
            deleteButton = new MaterialSkin.Controls.MaterialButton();
            editButton = new MaterialSkin.Controls.MaterialButton();
            addButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            employeesTable = new DataGridView();
            employeeIdColumn = new DataGridViewTextBoxColumn();
            employeeNameColumn = new DataGridViewTextBoxColumn();
            employeeEmailColumn = new DataGridViewTextBoxColumn();
            employeePositonColumn = new DataGridViewTextBoxColumn();
            addedIsActiveBindingSource = new BindingSource(components);
            employeePositionCb = new MaterialSkin.Controls.MaterialComboBox();
            employeeIdTxt = new MaterialSkin.Controls.MaterialTextBox();
            employeeEmailTxt = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            employeeeNameTxt = new MaterialSkin.Controls.MaterialTextBox();
            panel1 = new Panel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            payrollTab = new TabPage();
            payEmployeeButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            payrollTable = new DataGridView();
            payrollIdColumn = new DataGridViewTextBoxColumn();
            payrollNameColumn = new DataGridViewTextBoxColumn();
            payrollPositionColumn = new DataGridViewTextBoxColumn();
            paryollSalaryColumn = new DataGridViewTextBoxColumn();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            payrollSalaryTxt = new MaterialSkin.Controls.MaterialTextBox();
            payrollEmailTxt = new MaterialSkin.Controls.MaterialComboBox();
            payrollIdTxt = new MaterialSkin.Controls.MaterialTextBox();
            payrollNameTxt = new MaterialSkin.Controls.MaterialTextBox();
            panel2 = new Panel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            historyTab = new TabPage();
            materialTabControl1.SuspendLayout();
            employeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addedIsActiveBindingSource).BeginInit();
            panel1.SuspendLayout();
            payrollTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)payrollTable).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "history.png");
            imageList1.Images.SetKeyName(1, "cash.png");
            imageList1.Images.SetKeyName(2, "account-tie.png");
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(employeeTab);
            materialTabControl1.Controls.Add(payrollTab);
            materialTabControl1.Controls.Add(historyTab);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(861, 486);
            materialTabControl1.TabIndex = 0;
            // 
            // employeeTab
            // 
            employeeTab.BackColor = Color.White;
            employeeTab.Controls.Add(unselectButton);
            employeeTab.Controls.Add(deleteButton);
            employeeTab.Controls.Add(editButton);
            employeeTab.Controls.Add(addButton);
            employeeTab.Controls.Add(materialLabel6);
            employeeTab.Controls.Add(materialLabel5);
            employeeTab.Controls.Add(materialLabel4);
            employeeTab.Controls.Add(materialLabel3);
            employeeTab.Controls.Add(employeesTable);
            employeeTab.Controls.Add(employeePositionCb);
            employeeTab.Controls.Add(employeeIdTxt);
            employeeTab.Controls.Add(employeeEmailTxt);
            employeeTab.Controls.Add(materialLabel2);
            employeeTab.Controls.Add(employeeeNameTxt);
            employeeTab.Controls.Add(panel1);
            employeeTab.ImageKey = "account-tie.png";
            employeeTab.Location = new Point(4, 24);
            employeeTab.Name = "employeeTab";
            employeeTab.Padding = new Padding(3);
            employeeTab.Size = new Size(853, 458);
            employeeTab.TabIndex = 0;
            employeeTab.Text = "Employees";
            // 
            // unselectButton
            // 
            unselectButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            unselectButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            unselectButton.Depth = 0;
            unselectButton.HighEmphasis = true;
            unselectButton.Icon = null;
            unselectButton.Location = new Point(722, 86);
            unselectButton.Margin = new Padding(4, 6, 4, 6);
            unselectButton.MouseState = MaterialSkin.MouseState.HOVER;
            unselectButton.Name = "unselectButton";
            unselectButton.NoAccentTextColor = Color.Empty;
            unselectButton.Padding = new Padding(5, 5, 0, 0);
            unselectButton.Size = new Size(66, 36);
            unselectButton.TabIndex = 14;
            unselectButton.Text = "Clear";
            unselectButton.TextAlign = ContentAlignment.MiddleLeft;
            unselectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            unselectButton.UseAccentColor = false;
            unselectButton.UseVisualStyleBackColor = true;
            unselectButton.Click += unselectButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            deleteButton.Depth = 0;
            deleteButton.HighEmphasis = true;
            deleteButton.Icon = null;
            deleteButton.Location = new Point(641, 86);
            deleteButton.Margin = new Padding(4, 6, 4, 6);
            deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            deleteButton.Name = "deleteButton";
            deleteButton.NoAccentTextColor = Color.Empty;
            deleteButton.Size = new Size(73, 36);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Delete";
            deleteButton.TextAlign = ContentAlignment.MiddleLeft;
            deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            deleteButton.UseAccentColor = false;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            editButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            editButton.Depth = 0;
            editButton.HighEmphasis = true;
            editButton.Icon = null;
            editButton.Location = new Point(556, 86);
            editButton.Margin = new Padding(4, 6, 4, 6);
            editButton.MouseState = MaterialSkin.MouseState.HOVER;
            editButton.Name = "editButton";
            editButton.NoAccentTextColor = Color.Empty;
            editButton.Padding = new Padding(10, 10, 0, 0);
            editButton.Size = new Size(77, 36);
            editButton.TabIndex = 12;
            editButton.Text = "Update";
            editButton.TextAlign = ContentAlignment.MiddleLeft;
            editButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            editButton.UseAccentColor = false;
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addButton.Depth = 0;
            addButton.HighEmphasis = true;
            addButton.Icon = null;
            addButton.Location = new Point(484, 86);
            addButton.Margin = new Padding(4, 6, 4, 6);
            addButton.MouseState = MaterialSkin.MouseState.HOVER;
            addButton.Name = "addButton";
            addButton.NoAccentTextColor = Color.Empty;
            addButton.Size = new Size(64, 36);
            addButton.TabIndex = 11;
            addButton.Text = "Add";
            addButton.TextAlign = ContentAlignment.MiddleLeft;
            addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addButton.UseAccentColor = false;
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel6.Location = new Point(594, 138);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(54, 17);
            materialLabel6.TabIndex = 10;
            materialLabel6.Text = "Position";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel5.Location = new Point(365, 138);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(37, 17);
            materialLabel5.TabIndex = 9;
            materialLabel5.Text = "Email";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel4.Location = new Point(133, 140);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(39, 17);
            materialLabel4.TabIndex = 8;
            materialLabel4.Text = "Name";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel3.Location = new Point(21, 138);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(14, 17);
            materialLabel3.TabIndex = 7;
            materialLabel3.Text = "ID";
            // 
            // employeesTable
            // 
            employeesTable.AllowUserToResizeRows = false;
            employeesTable.AutoGenerateColumns = false;
            employeesTable.BackgroundColor = Color.FromArgb(50, 50, 50);
            employeesTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            employeesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            employeesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeesTable.Columns.AddRange(new DataGridViewColumn[] { employeeIdColumn, employeeNameColumn, employeeEmailColumn, employeePositonColumn });
            employeesTable.DataSource = addedIsActiveBindingSource;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            employeesTable.DefaultCellStyle = dataGridViewCellStyle6;
            employeesTable.EnableHeadersVisualStyles = false;
            employeesTable.Location = new Point(20, 216);
            employeesTable.MultiSelect = false;
            employeesTable.Name = "employeesTable";
            employeesTable.ReadOnly = true;
            employeesTable.RowHeadersVisible = false;
            employeesTable.ScrollBars = ScrollBars.Vertical;
            employeesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeesTable.Size = new Size(768, 236);
            employeesTable.TabIndex = 6;
            // 
            // employeeIdColumn
            // 
            employeeIdColumn.HeaderText = "Employee ID";
            employeeIdColumn.Name = "employeeIdColumn";
            employeeIdColumn.ReadOnly = true;
            employeeIdColumn.Width = 140;
            // 
            // employeeNameColumn
            // 
            employeeNameColumn.HeaderText = "Name";
            employeeNameColumn.Name = "employeeNameColumn";
            employeeNameColumn.ReadOnly = true;
            employeeNameColumn.Width = 210;
            // 
            // employeeEmailColumn
            // 
            employeeEmailColumn.HeaderText = "Email";
            employeeEmailColumn.Name = "employeeEmailColumn";
            employeeEmailColumn.ReadOnly = true;
            employeeEmailColumn.Width = 215;
            // 
            // employeePositonColumn
            // 
            employeePositonColumn.HeaderText = "Position";
            employeePositonColumn.Name = "employeePositonColumn";
            employeePositonColumn.ReadOnly = true;
            employeePositonColumn.Width = 200;
            // 
            // employeePositionCb
            // 
            employeePositionCb.AutoResize = false;
            employeePositionCb.BackColor = Color.FromArgb(255, 255, 255);
            employeePositionCb.Depth = 0;
            employeePositionCb.DrawMode = DrawMode.OwnerDrawVariable;
            employeePositionCb.DropDownHeight = 174;
            employeePositionCb.DropDownStyle = ComboBoxStyle.DropDownList;
            employeePositionCb.DropDownWidth = 121;
            employeePositionCb.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            employeePositionCb.ForeColor = Color.FromArgb(222, 0, 0, 0);
            employeePositionCb.FormattingEnabled = true;
            employeePositionCb.IntegralHeight = false;
            employeePositionCb.ItemHeight = 43;
            employeePositionCb.Items.AddRange(new object[] { "Select Position", "Software Engineer ", "DevOps Engineer", "Tech Lead", "Front-end Developer", "Backend Developer", "Intern" });
            employeePositionCb.Location = new Point(593, 160);
            employeePositionCb.MaxDropDownItems = 4;
            employeePositionCb.MouseState = MaterialSkin.MouseState.OUT;
            employeePositionCb.Name = "employeePositionCb";
            employeePositionCb.Size = new Size(195, 49);
            employeePositionCb.StartIndex = 0;
            employeePositionCb.TabIndex = 5;
            // 
            // employeeIdTxt
            // 
            employeeIdTxt.AnimateReadOnly = false;
            employeeIdTxt.BorderStyle = BorderStyle.None;
            employeeIdTxt.Depth = 0;
            employeeIdTxt.Enabled = false;
            employeeIdTxt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            employeeIdTxt.LeadingIcon = null;
            employeeIdTxt.Location = new Point(21, 160);
            employeeIdTxt.MaxLength = 50;
            employeeIdTxt.MouseState = MaterialSkin.MouseState.OUT;
            employeeIdTxt.Multiline = false;
            employeeIdTxt.Name = "employeeIdTxt";
            employeeIdTxt.Size = new Size(106, 50);
            employeeIdTxt.TabIndex = 4;
            employeeIdTxt.Text = "";
            employeeIdTxt.TrailingIcon = null;
            // 
            // employeeEmailTxt
            // 
            employeeEmailTxt.AnimateReadOnly = false;
            employeeEmailTxt.BorderStyle = BorderStyle.None;
            employeeEmailTxt.Depth = 0;
            employeeEmailTxt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            employeeEmailTxt.LeadingIcon = null;
            employeeEmailTxt.Location = new Point(365, 160);
            employeeEmailTxt.MaxLength = 50;
            employeeEmailTxt.MouseState = MaterialSkin.MouseState.OUT;
            employeeEmailTxt.Multiline = false;
            employeeEmailTxt.Name = "employeeEmailTxt";
            employeeEmailTxt.Size = new Size(223, 50);
            employeeEmailTxt.TabIndex = 3;
            employeeEmailTxt.Text = "";
            employeeEmailTxt.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.BackColor = Color.White;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(21, 96);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(123, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Employee Details";
            // 
            // employeeeNameTxt
            // 
            employeeeNameTxt.AnimateReadOnly = false;
            employeeeNameTxt.BorderStyle = BorderStyle.None;
            employeeeNameTxt.Depth = 0;
            employeeeNameTxt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            employeeeNameTxt.LeadingIcon = null;
            employeeeNameTxt.Location = new Point(133, 160);
            employeeeNameTxt.MaxLength = 50;
            employeeeNameTxt.MouseState = MaterialSkin.MouseState.OUT;
            employeeeNameTxt.Multiline = false;
            employeeeNameTxt.Name = "employeeeNameTxt";
            employeeeNameTxt.Size = new Size(226, 50);
            employeeeNameTxt.TabIndex = 2;
            employeeeNameTxt.Text = "";
            employeeeNameTxt.TrailingIcon = null;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 50);
            panel1.TabIndex = 1;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = Color.White;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.ForeColor = Color.White;
            materialLabel1.Location = new Point(18, 16);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(78, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Employees";
            // 
            // payrollTab
            // 
            payrollTab.BackColor = Color.White;
            payrollTab.Controls.Add(payEmployeeButton);
            payrollTab.Controls.Add(materialLabel12);
            payrollTab.Controls.Add(payrollTable);
            payrollTab.Controls.Add(materialLabel8);
            payrollTab.Controls.Add(materialLabel9);
            payrollTab.Controls.Add(materialLabel10);
            payrollTab.Controls.Add(materialLabel11);
            payrollTab.Controls.Add(payrollSalaryTxt);
            payrollTab.Controls.Add(payrollEmailTxt);
            payrollTab.Controls.Add(payrollIdTxt);
            payrollTab.Controls.Add(payrollNameTxt);
            payrollTab.Controls.Add(panel2);
            payrollTab.ImageKey = "cash.png";
            payrollTab.Location = new Point(4, 24);
            payrollTab.Name = "payrollTab";
            payrollTab.Padding = new Padding(3);
            payrollTab.Size = new Size(853, 458);
            payrollTab.TabIndex = 1;
            payrollTab.Text = "Payroll";
            // 
            // payEmployeeButton
            // 
            payEmployeeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            payEmployeeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            payEmployeeButton.Depth = 0;
            payEmployeeButton.HighEmphasis = true;
            payEmployeeButton.Icon = null;
            payEmployeeButton.Location = new Point(660, 86);
            payEmployeeButton.Margin = new Padding(4, 6, 4, 6);
            payEmployeeButton.MouseState = MaterialSkin.MouseState.HOVER;
            payEmployeeButton.Name = "payEmployeeButton";
            payEmployeeButton.NoAccentTextColor = Color.Empty;
            payEmployeeButton.Size = new Size(128, 36);
            payEmployeeButton.TabIndex = 17;
            payEmployeeButton.Text = "Pay Employee";
            payEmployeeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            payEmployeeButton.UseAccentColor = false;
            payEmployeeButton.UseVisualStyleBackColor = true;
            payEmployeeButton.Click += materialButton1_Click;
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.BackColor = Color.White;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(21, 96);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(123, 19);
            materialLabel12.TabIndex = 16;
            materialLabel12.Text = "Employee Payroll";
            // 
            // payrollTable
            // 
            payrollTable.AllowUserToResizeRows = false;
            payrollTable.AutoGenerateColumns = false;
            payrollTable.BackgroundColor = Color.FromArgb(50, 50, 50);
            payrollTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            payrollTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            payrollTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            payrollTable.Columns.AddRange(new DataGridViewColumn[] { payrollIdColumn, payrollNameColumn, payrollPositionColumn, paryollSalaryColumn });
            payrollTable.DataSource = addedIsActiveBindingSource;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            payrollTable.DefaultCellStyle = dataGridViewCellStyle8;
            payrollTable.EnableHeadersVisualStyles = false;
            payrollTable.Location = new Point(20, 216);
            payrollTable.MultiSelect = false;
            payrollTable.Name = "payrollTable";
            payrollTable.ReadOnly = true;
            payrollTable.RowHeadersVisible = false;
            payrollTable.ScrollBars = ScrollBars.Vertical;
            payrollTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            payrollTable.Size = new Size(768, 236);
            payrollTable.TabIndex = 15;
            // 
            // payrollIdColumn
            // 
            payrollIdColumn.HeaderText = "Employee ID";
            payrollIdColumn.Name = "payrollIdColumn";
            payrollIdColumn.ReadOnly = true;
            payrollIdColumn.Width = 140;
            // 
            // payrollNameColumn
            // 
            payrollNameColumn.HeaderText = "Name";
            payrollNameColumn.Name = "payrollNameColumn";
            payrollNameColumn.ReadOnly = true;
            payrollNameColumn.Width = 210;
            // 
            // payrollPositionColumn
            // 
            payrollPositionColumn.HeaderText = "Position";
            payrollPositionColumn.Name = "payrollPositionColumn";
            payrollPositionColumn.ReadOnly = true;
            payrollPositionColumn.Width = 215;
            // 
            // paryollSalaryColumn
            // 
            paryollSalaryColumn.HeaderText = "Salary";
            paryollSalaryColumn.Name = "paryollSalaryColumn";
            paryollSalaryColumn.ReadOnly = true;
            paryollSalaryColumn.Resizable = DataGridViewTriState.True;
            paryollSalaryColumn.Width = 200;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel8.Location = new Point(566, 139);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(41, 17);
            materialLabel8.TabIndex = 14;
            materialLabel8.Text = "Salary";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel9.Location = new Point(365, 139);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(54, 17);
            materialLabel9.TabIndex = 13;
            materialLabel9.Text = "Position";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel10.Location = new Point(133, 141);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(39, 17);
            materialLabel10.TabIndex = 12;
            materialLabel10.Text = "Name";
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel11.Location = new Point(21, 139);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(14, 17);
            materialLabel11.TabIndex = 11;
            materialLabel11.Text = "ID";
            // 
            // payrollSalaryTxt
            // 
            payrollSalaryTxt.AnimateReadOnly = false;
            payrollSalaryTxt.BorderStyle = BorderStyle.None;
            payrollSalaryTxt.Depth = 0;
            payrollSalaryTxt.Enabled = false;
            payrollSalaryTxt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            payrollSalaryTxt.LeadingIcon = null;
            payrollSalaryTxt.Location = new Point(565, 160);
            payrollSalaryTxt.MaxLength = 50;
            payrollSalaryTxt.MouseState = MaterialSkin.MouseState.OUT;
            payrollSalaryTxt.Multiline = false;
            payrollSalaryTxt.Name = "payrollSalaryTxt";
            payrollSalaryTxt.Size = new Size(223, 50);
            payrollSalaryTxt.TabIndex = 9;
            payrollSalaryTxt.Text = "";
            payrollSalaryTxt.TrailingIcon = null;
            // 
            // payrollEmailTxt
            // 
            payrollEmailTxt.AutoResize = false;
            payrollEmailTxt.BackColor = Color.FromArgb(255, 255, 255);
            payrollEmailTxt.Depth = 0;
            payrollEmailTxt.DrawMode = DrawMode.OwnerDrawVariable;
            payrollEmailTxt.DropDownHeight = 174;
            payrollEmailTxt.DropDownStyle = ComboBoxStyle.DropDownList;
            payrollEmailTxt.DropDownWidth = 121;
            payrollEmailTxt.Enabled = false;
            payrollEmailTxt.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            payrollEmailTxt.ForeColor = Color.FromArgb(222, 0, 0, 0);
            payrollEmailTxt.FormattingEnabled = true;
            payrollEmailTxt.IntegralHeight = false;
            payrollEmailTxt.ItemHeight = 43;
            payrollEmailTxt.Items.AddRange(new object[] { "Select Position", "Software Engineer ", "DevOps Engineer", "Tech Lead", "Front-end Developer", "Backend Developer", "Intern" });
            payrollEmailTxt.Location = new Point(364, 159);
            payrollEmailTxt.MaxDropDownItems = 4;
            payrollEmailTxt.MouseState = MaterialSkin.MouseState.OUT;
            payrollEmailTxt.Name = "payrollEmailTxt";
            payrollEmailTxt.Size = new Size(195, 49);
            payrollEmailTxt.StartIndex = 0;
            payrollEmailTxt.TabIndex = 8;
            // 
            // payrollIdTxt
            // 
            payrollIdTxt.AnimateReadOnly = false;
            payrollIdTxt.BorderStyle = BorderStyle.None;
            payrollIdTxt.Depth = 0;
            payrollIdTxt.Enabled = false;
            payrollIdTxt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            payrollIdTxt.LeadingIcon = null;
            payrollIdTxt.Location = new Point(20, 160);
            payrollIdTxt.MaxLength = 50;
            payrollIdTxt.MouseState = MaterialSkin.MouseState.OUT;
            payrollIdTxt.Multiline = false;
            payrollIdTxt.Name = "payrollIdTxt";
            payrollIdTxt.Size = new Size(106, 50);
            payrollIdTxt.TabIndex = 7;
            payrollIdTxt.Text = "";
            payrollIdTxt.TrailingIcon = null;
            // 
            // payrollNameTxt
            // 
            payrollNameTxt.AnimateReadOnly = false;
            payrollNameTxt.BorderStyle = BorderStyle.None;
            payrollNameTxt.Depth = 0;
            payrollNameTxt.Enabled = false;
            payrollNameTxt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            payrollNameTxt.LeadingIcon = null;
            payrollNameTxt.Location = new Point(132, 160);
            payrollNameTxt.MaxLength = 50;
            payrollNameTxt.MouseState = MaterialSkin.MouseState.OUT;
            payrollNameTxt.Multiline = false;
            payrollNameTxt.Name = "payrollNameTxt";
            payrollNameTxt.Size = new Size(226, 50);
            payrollNameTxt.TabIndex = 6;
            payrollNameTxt.Text = "";
            payrollNameTxt.TrailingIcon = null;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(materialLabel7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 50);
            panel2.TabIndex = 2;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.BackColor = Color.White;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.ForeColor = Color.White;
            materialLabel7.Location = new Point(18, 16);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(50, 19);
            materialLabel7.TabIndex = 0;
            materialLabel7.Text = "Payroll";
            // 
            // historyTab
            // 
            historyTab.BackColor = Color.White;
            historyTab.ImageKey = "history.png";
            historyTab.Location = new Point(4, 24);
            historyTab.Name = "historyTab";
            historyTab.Size = new Size(853, 458);
            historyTab.TabIndex = 2;
            historyTab.Text = "History";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 553);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "Form1";
            Text = "C# WINFORMS";
            Load += Form1_Load;
            materialTabControl1.ResumeLayout(false);
            employeeTab.ResumeLayout(false);
            employeeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)addedIsActiveBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            payrollTab.ResumeLayout(false);
            payrollTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)payrollTable).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage employeeTab;
        private TabPage payrollTab;
        private TabPage historyTab;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox employeeeNameTxt;
        private MaterialSkin.Controls.MaterialTextBox employeeIdTxt;
        private MaterialSkin.Controls.MaterialTextBox employeeEmailTxt;
        private MaterialSkin.Controls.MaterialComboBox employeePositionCb;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton unselectButton;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private MaterialSkin.Controls.MaterialButton editButton;
        private MaterialSkin.Controls.MaterialButton addButton;
        private DataGridView employeesTable;
        private BindingSource addedIsActiveBindingSource;
        private DataGridViewTextBoxColumn employeeIdColumn;
        private DataGridViewTextBoxColumn employeeNameColumn;
        private DataGridViewTextBoxColumn employeeEmailColumn;
        private DataGridViewTextBoxColumn employeePositonColumn;
        private DataGridViewTextBoxColumn targetModelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn upOperationsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn downOperationsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn activeProviderDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox payrollSalaryTxt;
        private MaterialSkin.Controls.MaterialComboBox payrollEmailTxt;
        private MaterialSkin.Controls.MaterialTextBox payrollIdTxt;
        private MaterialSkin.Controls.MaterialTextBox payrollNameTxt;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private DataGridView payrollTable;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialButton payEmployeeButton;
        private DataGridViewTextBoxColumn payrollIdColumn;
        private DataGridViewTextBoxColumn payrollNameColumn;
        private DataGridViewTextBoxColumn payrollPositionColumn;
        private DataGridViewTextBoxColumn paryollSalaryColumn;
    }
}
