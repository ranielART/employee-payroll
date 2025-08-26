namespace employee_payroll
{
    partial class EmployeeDataFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            historyTb = new DataGridView();
            payDaysLabel = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            idLabel = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            lastPaidLabel = new MaterialSkin.Controls.MaterialLabel();
            dateHiredLabel = new MaterialSkin.Controls.MaterialLabel();
            emailLabel = new MaterialSkin.Controls.MaterialLabel();
            positionLabel = new MaterialSkin.Controls.MaterialLabel();
            nameLabel = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            historyDateColumn = new DataGridViewTextBoxColumn();
            historyEmployeeName = new DataGridViewTextBoxColumn();
            historyPosition = new DataGridViewTextBoxColumn();
            historyAmount = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)historyTb).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(historyTb);
            panel1.Controls.Add(payDaysLabel);
            panel1.Controls.Add(materialLabel9);
            panel1.Controls.Add(idLabel);
            panel1.Controls.Add(materialLabel8);
            panel1.Controls.Add(lastPaidLabel);
            panel1.Controls.Add(dateHiredLabel);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(positionLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(materialLabel6);
            panel1.Controls.Add(materialLabel5);
            panel1.Controls.Add(materialLabel4);
            panel1.Controls.Add(materialLabel3);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 369);
            panel1.TabIndex = 11;
            // 
            // historyTb
            // 
            historyTb.AllowUserToResizeRows = false;
            historyTb.BackgroundColor = Color.FromArgb(50, 50, 50);
            historyTb.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            historyTb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            historyTb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyTb.Columns.AddRange(new DataGridViewColumn[] { historyDateColumn, historyEmployeeName, historyPosition, historyAmount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            historyTb.DefaultCellStyle = dataGridViewCellStyle2;
            historyTb.EnableHeadersVisualStyles = false;
            historyTb.Location = new Point(420, 70);
            historyTb.MultiSelect = false;
            historyTb.Name = "historyTb";
            historyTb.ReadOnly = true;
            historyTb.RowHeadersVisible = false;
            historyTb.ScrollBars = ScrollBars.Vertical;
            historyTb.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            historyTb.Size = new Size(573, 244);
            historyTb.TabIndex = 26;
            // 
            // payDaysLabel
            // 
            payDaysLabel.AutoSize = true;
            payDaysLabel.BackColor = Color.Transparent;
            payDaysLabel.Depth = 0;
            payDaysLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            payDaysLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            payDaysLabel.ForeColor = SystemColors.ControlLightLight;
            payDaysLabel.Location = new Point(695, 30);
            payDaysLabel.MouseState = MaterialSkin.MouseState.HOVER;
            payDaysLabel.Name = "payDaysLabel";
            payDaysLabel.Size = new Size(85, 24);
            payDaysLabel.TabIndex = 25;
            payDaysLabel.Text = "Last Paid";
            payDaysLabel.TextAlign = ContentAlignment.MiddleLeft;
            payDaysLabel.Click += materialLabel7_Click;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.BackColor = Color.Transparent;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel9.ForeColor = SystemColors.ControlLightLight;
            materialLabel9.Location = new Point(420, 30);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(262, 24);
            materialLabel9.TabIndex = 24;
            materialLabel9.Text = "Days Left Until Next Pay Day:";
            materialLabel9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = Color.Transparent;
            idLabel.Depth = 0;
            idLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            idLabel.ForeColor = SystemColors.ControlLightLight;
            idLabel.Location = new Point(145, 70);
            idLabel.MouseState = MaterialSkin.MouseState.HOVER;
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(14, 19);
            idLabel.TabIndex = 23;
            idLabel.Text = "Id";
            idLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.BackColor = Color.Transparent;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.ForeColor = SystemColors.ControlLightLight;
            materialLabel8.Location = new Point(32, 70);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(16, 19);
            materialLabel8.TabIndex = 22;
            materialLabel8.Text = "ID";
            materialLabel8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lastPaidLabel
            // 
            lastPaidLabel.AutoSize = true;
            lastPaidLabel.BackColor = Color.Transparent;
            lastPaidLabel.Depth = 0;
            lastPaidLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lastPaidLabel.ForeColor = SystemColors.ControlLightLight;
            lastPaidLabel.Location = new Point(145, 295);
            lastPaidLabel.MouseState = MaterialSkin.MouseState.HOVER;
            lastPaidLabel.Name = "lastPaidLabel";
            lastPaidLabel.Size = new Size(68, 19);
            lastPaidLabel.TabIndex = 21;
            lastPaidLabel.Text = "Last Paid";
            lastPaidLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateHiredLabel
            // 
            dateHiredLabel.AutoSize = true;
            dateHiredLabel.BackColor = Color.Transparent;
            dateHiredLabel.Depth = 0;
            dateHiredLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateHiredLabel.ForeColor = SystemColors.ControlLightLight;
            dateHiredLabel.Location = new Point(145, 249);
            dateHiredLabel.MouseState = MaterialSkin.MouseState.HOVER;
            dateHiredLabel.Name = "dateHiredLabel";
            dateHiredLabel.Size = new Size(75, 19);
            dateHiredLabel.TabIndex = 20;
            dateHiredLabel.Text = "Date Hired";
            dateHiredLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Depth = 0;
            emailLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailLabel.ForeColor = SystemColors.ControlLightLight;
            emailLabel.Location = new Point(145, 157);
            emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(41, 19);
            emailLabel.TabIndex = 19;
            emailLabel.Text = "Email";
            emailLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.BackColor = Color.Transparent;
            positionLabel.Depth = 0;
            positionLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            positionLabel.ForeColor = SystemColors.ControlLightLight;
            positionLabel.Location = new Point(145, 203);
            positionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(59, 19);
            positionLabel.TabIndex = 18;
            positionLabel.Text = "Position";
            positionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Depth = 0;
            nameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameLabel.ForeColor = SystemColors.ControlLightLight;
            nameLabel.Location = new Point(145, 113);
            nameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(43, 19);
            nameLabel.TabIndex = 17;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.BackColor = Color.Transparent;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.ForeColor = SystemColors.ControlLightLight;
            materialLabel6.Location = new Point(32, 295);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(68, 19);
            materialLabel6.TabIndex = 16;
            materialLabel6.Text = "Last Paid";
            materialLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.BackColor = Color.Transparent;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.ForeColor = SystemColors.ControlLightLight;
            materialLabel5.Location = new Point(32, 249);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(75, 19);
            materialLabel5.TabIndex = 15;
            materialLabel5.Text = "Date Hired";
            materialLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.BackColor = Color.Transparent;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.ForeColor = SystemColors.ControlLightLight;
            materialLabel4.Location = new Point(32, 157);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(41, 19);
            materialLabel4.TabIndex = 14;
            materialLabel4.Text = "Email";
            materialLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.BackColor = Color.Transparent;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.ForeColor = SystemColors.ControlLightLight;
            materialLabel3.Location = new Point(32, 203);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(59, 19);
            materialLabel3.TabIndex = 13;
            materialLabel3.Text = "Position";
            materialLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.BackColor = Color.Transparent;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.ForeColor = SystemColors.ControlLightLight;
            materialLabel2.Location = new Point(32, 113);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(43, 19);
            materialLabel2.TabIndex = 12;
            materialLabel2.Text = "Name";
            materialLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = Color.White;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(32, 30);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(135, 24);
            materialLabel1.TabIndex = 11;
            materialLabel1.Text = "Employee Data";
            // 
            // historyDateColumn
            // 
            historyDateColumn.HeaderText = "Date";
            historyDateColumn.Name = "historyDateColumn";
            historyDateColumn.ReadOnly = true;
            historyDateColumn.Width = 150;
            // 
            // historyEmployeeName
            // 
            historyEmployeeName.HeaderText = "Employee Name";
            historyEmployeeName.Name = "historyEmployeeName";
            historyEmployeeName.ReadOnly = true;
            historyEmployeeName.Visible = false;
            historyEmployeeName.Width = 240;
            // 
            // historyPosition
            // 
            historyPosition.HeaderText = "Position";
            historyPosition.Name = "historyPosition";
            historyPosition.ReadOnly = true;
            historyPosition.Width = 220;
            // 
            // historyAmount
            // 
            historyAmount.HeaderText = "Amount (PHP)";
            historyAmount.Name = "historyAmount";
            historyAmount.ReadOnly = true;
            historyAmount.Resizable = DataGridViewTriState.True;
            historyAmount.Width = 200;
            // 
            // EmployeeDataFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1032, 436);
            Controls.Add(panel1);
            Name = "EmployeeDataFrom";
            Text = "Employee";
            Load += EmployeeDataFrom_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)historyTb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lastPaidLabel;
        private MaterialSkin.Controls.MaterialLabel dateHiredLabel;
        private MaterialSkin.Controls.MaterialLabel emailLabel;
        private MaterialSkin.Controls.MaterialLabel positionLabel;
        private MaterialSkin.Controls.MaterialLabel nameLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel idLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel payDaysLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private DataGridView historyTb;
        private DataGridViewTextBoxColumn historyDateColumn;
        private DataGridViewTextBoxColumn historyEmployeeName;
        private DataGridViewTextBoxColumn historyPosition;
        private DataGridViewTextBoxColumn historyAmount;
    }
}