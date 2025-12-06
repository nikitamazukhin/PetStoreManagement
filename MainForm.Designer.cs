namespace DatabaseApp
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            departmentListButton = new Button();
            productListButton = new Button();
            departmentGridViewLabel = new Label();
            departmentGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departmentBindingSource = new BindingSource(components);
            partTimeDataGridView = new DataGridView();
            partTimeEmployeeBindingSource = new BindingSource(components);
            fullTimeDataGridView = new DataGridView();
            fullTimeEmployeeBindingSource = new BindingSource(components);
            partTimeDataGridViewLabel = new Label();
            fullTimeDataGridViewLabel = new Label();
            submitPartTimeEmployee = new Button();
            deletePartTimeEmployee = new Button();
            submitFullTimeEmployee = new Button();
            deleteFullTimeEmployee = new Button();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            monthlySalaryUsdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bonusSalaryUsdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isManagerDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            weeklyHoursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            monthlySalaryUsdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bonusSalaryUsdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            isManagerDataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            WorksNightShift = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)departmentGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departmentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partTimeDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partTimeEmployeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fullTimeDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fullTimeEmployeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // departmentListButton
            // 
            departmentListButton.BackColor = Color.MidnightBlue;
            departmentListButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            departmentListButton.ForeColor = SystemColors.Control;
            departmentListButton.Location = new Point(19, 19);
            departmentListButton.Margin = new Padding(10);
            departmentListButton.Name = "departmentListButton";
            departmentListButton.Size = new Size(142, 36);
            departmentListButton.TabIndex = 1;
            departmentListButton.Text = "Department List";
            departmentListButton.UseVisualStyleBackColor = false;
            departmentListButton.Click += departmentListButton_Click;
            // 
            // productListButton
            // 
            productListButton.BackColor = Color.MidnightBlue;
            productListButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            productListButton.ForeColor = SystemColors.Control;
            productListButton.Location = new Point(181, 19);
            productListButton.Margin = new Padding(10);
            productListButton.Name = "productListButton";
            productListButton.Size = new Size(142, 36);
            productListButton.TabIndex = 2;
            productListButton.Text = "Product List";
            productListButton.UseVisualStyleBackColor = false;
            // 
            // departmentGridViewLabel
            // 
            departmentGridViewLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            departmentGridViewLabel.Location = new Point(29, 75);
            departmentGridViewLabel.Margin = new Padding(5);
            departmentGridViewLabel.Name = "departmentGridViewLabel";
            departmentGridViewLabel.Size = new Size(250, 36);
            departmentGridViewLabel.TabIndex = 4;
            departmentGridViewLabel.Text = "Department List";
            departmentGridViewLabel.TextAlign = ContentAlignment.MiddleCenter;
            departmentGridViewLabel.Visible = false;
            // 
            // departmentGridView
            // 
            departmentGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            departmentGridView.AutoGenerateColumns = false;
            departmentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            departmentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            departmentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            departmentGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            departmentGridView.DataSource = departmentBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            departmentGridView.DefaultCellStyle = dataGridViewCellStyle2;
            departmentGridView.Location = new Point(29, 126);
            departmentGridView.Margin = new Padding(20, 10, 20, 10);
            departmentGridView.Name = "departmentGridView";
            departmentGridView.Size = new Size(250, 716);
            departmentGridView.TabIndex = 5;
            departmentGridView.Visible = false;
            departmentGridView.CellContentClick += departmentGridView_CellContentClick;
            departmentGridView.SelectionChanged += departmentGridView_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentBindingSource
            // 
            departmentBindingSource.DataSource = typeof(Models.Department);
            // 
            // partTimeDataGridView
            // 
            partTimeDataGridView.AutoGenerateColumns = false;
            partTimeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            partTimeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            partTimeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partTimeDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, phoneNumberDataGridViewTextBoxColumn, monthlySalaryUsdDataGridViewTextBoxColumn, bonusSalaryUsdDataGridViewTextBoxColumn, isManagerDataGridViewCheckBoxColumn, weeklyHoursDataGridViewTextBoxColumn });
            partTimeDataGridView.DataSource = partTimeEmployeeBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            partTimeDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            partTimeDataGridView.Location = new Point(381, 126);
            partTimeDataGridView.Margin = new Padding(15, 10, 15, 10);
            partTimeDataGridView.Name = "partTimeDataGridView";
            partTimeDataGridView.Size = new Size(650, 600);
            partTimeDataGridView.TabIndex = 6;
            partTimeDataGridView.Visible = false;
            // 
            // partTimeEmployeeBindingSource
            // 
            partTimeEmployeeBindingSource.DataSource = typeof(Models.PartTimeEmployee);
            // 
            // fullTimeDataGridView
            // 
            fullTimeDataGridView.AutoGenerateColumns = false;
            fullTimeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            fullTimeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fullTimeDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, nameDataGridViewTextBoxColumn2, phoneNumberDataGridViewTextBoxColumn1, monthlySalaryUsdDataGridViewTextBoxColumn1, bonusSalaryUsdDataGridViewTextBoxColumn1, isManagerDataGridViewCheckBoxColumn1, WorksNightShift });
            fullTimeDataGridView.DataSource = fullTimeEmployeeBindingSource;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            fullTimeDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            fullTimeDataGridView.Location = new Point(1110, 126);
            fullTimeDataGridView.Margin = new Padding(15, 10, 15, 10);
            fullTimeDataGridView.Name = "fullTimeDataGridView";
            fullTimeDataGridView.Size = new Size(650, 600);
            fullTimeDataGridView.TabIndex = 7;
            fullTimeDataGridView.Visible = false;
            // 
            // fullTimeEmployeeBindingSource
            // 
            fullTimeEmployeeBindingSource.DataSource = typeof(Models.FullTimeEmployee);
            // 
            // partTimeDataGridViewLabel
            // 
            partTimeDataGridViewLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            partTimeDataGridViewLabel.Location = new Point(381, 75);
            partTimeDataGridViewLabel.Margin = new Padding(5);
            partTimeDataGridViewLabel.Name = "partTimeDataGridViewLabel";
            partTimeDataGridViewLabel.Size = new Size(650, 36);
            partTimeDataGridViewLabel.TabIndex = 8;
            partTimeDataGridViewLabel.Text = "Part-Time Employee List";
            partTimeDataGridViewLabel.TextAlign = ContentAlignment.MiddleCenter;
            partTimeDataGridViewLabel.Visible = false;
            // 
            // fullTimeDataGridViewLabel
            // 
            fullTimeDataGridViewLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            fullTimeDataGridViewLabel.Location = new Point(1110, 75);
            fullTimeDataGridViewLabel.Margin = new Padding(5);
            fullTimeDataGridViewLabel.Name = "fullTimeDataGridViewLabel";
            fullTimeDataGridViewLabel.Size = new Size(650, 36);
            fullTimeDataGridViewLabel.TabIndex = 9;
            fullTimeDataGridViewLabel.Text = "Full-Time Employee List";
            fullTimeDataGridViewLabel.TextAlign = ContentAlignment.MiddleCenter;
            fullTimeDataGridViewLabel.Visible = false;
            // 
            // submitPartTimeEmployee
            // 
            submitPartTimeEmployee.BackColor = Color.MidnightBlue;
            submitPartTimeEmployee.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            submitPartTimeEmployee.ForeColor = SystemColors.Control;
            submitPartTimeEmployee.Location = new Point(605, 746);
            submitPartTimeEmployee.Margin = new Padding(10);
            submitPartTimeEmployee.Name = "submitPartTimeEmployee";
            submitPartTimeEmployee.Size = new Size(200, 36);
            submitPartTimeEmployee.TabIndex = 10;
            submitPartTimeEmployee.Text = "Submit";
            submitPartTimeEmployee.UseVisualStyleBackColor = false;
            submitPartTimeEmployee.Visible = false;
            submitPartTimeEmployee.Click += submitPartTimeEmployee_Click;
            // 
            // deletePartTimeEmployee
            // 
            deletePartTimeEmployee.BackColor = Color.Brown;
            deletePartTimeEmployee.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deletePartTimeEmployee.ForeColor = SystemColors.Control;
            deletePartTimeEmployee.Location = new Point(605, 806);
            deletePartTimeEmployee.Margin = new Padding(10);
            deletePartTimeEmployee.Name = "deletePartTimeEmployee";
            deletePartTimeEmployee.Size = new Size(200, 36);
            deletePartTimeEmployee.TabIndex = 11;
            deletePartTimeEmployee.Text = "Delete";
            deletePartTimeEmployee.UseVisualStyleBackColor = false;
            deletePartTimeEmployee.Visible = false;
            deletePartTimeEmployee.Click += deletePartTimeEmployee_Click;
            // 
            // submitFullTimeEmployee
            // 
            submitFullTimeEmployee.BackColor = Color.MidnightBlue;
            submitFullTimeEmployee.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            submitFullTimeEmployee.ForeColor = SystemColors.Control;
            submitFullTimeEmployee.Location = new Point(1335, 746);
            submitFullTimeEmployee.Margin = new Padding(10);
            submitFullTimeEmployee.Name = "submitFullTimeEmployee";
            submitFullTimeEmployee.Size = new Size(200, 36);
            submitFullTimeEmployee.TabIndex = 12;
            submitFullTimeEmployee.Text = "Submit";
            submitFullTimeEmployee.UseVisualStyleBackColor = false;
            submitFullTimeEmployee.Visible = false;
            submitFullTimeEmployee.Click += submitFullTimeEmployee_Click;
            // 
            // deleteFullTimeEmployee
            // 
            deleteFullTimeEmployee.BackColor = Color.Brown;
            deleteFullTimeEmployee.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteFullTimeEmployee.ForeColor = SystemColors.Control;
            deleteFullTimeEmployee.Location = new Point(1335, 806);
            deleteFullTimeEmployee.Margin = new Padding(10);
            deleteFullTimeEmployee.Name = "deleteFullTimeEmployee";
            deleteFullTimeEmployee.Size = new Size(200, 36);
            deleteFullTimeEmployee.TabIndex = 13;
            deleteFullTimeEmployee.Text = "Delete";
            deleteFullTimeEmployee.UseVisualStyleBackColor = false;
            deleteFullTimeEmployee.Visible = false;
            deleteFullTimeEmployee.Click += deleteFullTimeEmployee_Click;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthlySalaryUsdDataGridViewTextBoxColumn
            // 
            monthlySalaryUsdDataGridViewTextBoxColumn.DataPropertyName = "MonthlySalaryUsd";
            monthlySalaryUsdDataGridViewTextBoxColumn.HeaderText = "MonthlySalaryUsd";
            monthlySalaryUsdDataGridViewTextBoxColumn.Name = "monthlySalaryUsdDataGridViewTextBoxColumn";
            // 
            // bonusSalaryUsdDataGridViewTextBoxColumn
            // 
            bonusSalaryUsdDataGridViewTextBoxColumn.DataPropertyName = "BonusSalaryUsd";
            bonusSalaryUsdDataGridViewTextBoxColumn.HeaderText = "BonusSalaryUsd";
            bonusSalaryUsdDataGridViewTextBoxColumn.Name = "bonusSalaryUsdDataGridViewTextBoxColumn";
            // 
            // isManagerDataGridViewCheckBoxColumn
            // 
            isManagerDataGridViewCheckBoxColumn.DataPropertyName = "IsManager";
            isManagerDataGridViewCheckBoxColumn.HeaderText = "IsManager";
            isManagerDataGridViewCheckBoxColumn.Name = "isManagerDataGridViewCheckBoxColumn";
            // 
            // weeklyHoursDataGridViewTextBoxColumn
            // 
            weeklyHoursDataGridViewTextBoxColumn.DataPropertyName = "WeeklyHours";
            weeklyHoursDataGridViewTextBoxColumn.HeaderText = "WeeklyHours";
            weeklyHoursDataGridViewTextBoxColumn.Name = "weeklyHoursDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // phoneNumberDataGridViewTextBoxColumn1
            // 
            phoneNumberDataGridViewTextBoxColumn1.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn1.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn1.Name = "phoneNumberDataGridViewTextBoxColumn1";
            phoneNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // monthlySalaryUsdDataGridViewTextBoxColumn1
            // 
            monthlySalaryUsdDataGridViewTextBoxColumn1.DataPropertyName = "MonthlySalaryUsd";
            monthlySalaryUsdDataGridViewTextBoxColumn1.HeaderText = "MonthlySalaryUsd";
            monthlySalaryUsdDataGridViewTextBoxColumn1.Name = "monthlySalaryUsdDataGridViewTextBoxColumn1";
            // 
            // bonusSalaryUsdDataGridViewTextBoxColumn1
            // 
            bonusSalaryUsdDataGridViewTextBoxColumn1.DataPropertyName = "BonusSalaryUsd";
            bonusSalaryUsdDataGridViewTextBoxColumn1.HeaderText = "BonusSalaryUsd";
            bonusSalaryUsdDataGridViewTextBoxColumn1.Name = "bonusSalaryUsdDataGridViewTextBoxColumn1";
            // 
            // isManagerDataGridViewCheckBoxColumn1
            // 
            isManagerDataGridViewCheckBoxColumn1.DataPropertyName = "IsManager";
            isManagerDataGridViewCheckBoxColumn1.HeaderText = "IsManager";
            isManagerDataGridViewCheckBoxColumn1.Name = "isManagerDataGridViewCheckBoxColumn1";
            // 
            // WorksNightShift
            // 
            WorksNightShift.DataPropertyName = "WorksNightShift";
            WorksNightShift.HeaderText = "WorksNightShift";
            WorksNightShift.Name = "WorksNightShift";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1784, 861);
            Controls.Add(deleteFullTimeEmployee);
            Controls.Add(submitFullTimeEmployee);
            Controls.Add(deletePartTimeEmployee);
            Controls.Add(submitPartTimeEmployee);
            Controls.Add(fullTimeDataGridViewLabel);
            Controls.Add(partTimeDataGridViewLabel);
            Controls.Add(fullTimeDataGridView);
            Controls.Add(partTimeDataGridView);
            Controls.Add(departmentGridView);
            Controls.Add(departmentGridViewLabel);
            Controls.Add(productListButton);
            Controls.Add(departmentListButton);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.ControlText;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager Control Panel";
            ((System.ComponentModel.ISupportInitialize)departmentGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)departmentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)partTimeDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)partTimeEmployeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fullTimeDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)fullTimeEmployeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button departmentListButton;
        private Button productListButton;
        private Label departmentGridViewLabel;
        private DataGridView departmentGridView;
        private BindingSource departmentBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridView partTimeDataGridView;
        private BindingSource partTimeEmployeeBindingSource;
        private DataGridView fullTimeDataGridView;
        private BindingSource fullTimeEmployeeBindingSource;
        private Label partTimeDataGridViewLabel;
        private Label fullTimeDataGridViewLabel;
        private Button submitPartTimeEmployee;
        private Button deletePartTimeEmployee;
        private Button submitFullTimeEmployee;
        private Button deleteFullTimeEmployee;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn monthlySalaryUsdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bonusSalaryUsdDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isManagerDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn weeklyHoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn monthlySalaryUsdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn bonusSalaryUsdDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn isManagerDataGridViewCheckBoxColumn1;
        private DataGridViewCheckBoxColumn WorksNightShift;
    }
}