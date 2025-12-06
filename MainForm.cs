using DatabaseApp.Data;
using DatabaseApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DatabaseApp
{
    public partial class MainForm : Form
    {
        DatabaseContext employeeContext;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            DatabaseContext context = new DatabaseContext();
            context.Database.EnsureCreated();
            context.Departments.Load();
            departmentBindingSource.DataSource = context.Departments.Local.ToBindingList();
        }

        private bool ValidateDatabaseModification()
        {
            string message = "This will modify the database. Confirm this operation?";
            string caption = "Database Modification Alert";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            return result == DialogResult.Yes;
        }

        private void departmentListButton_Click(object sender, EventArgs e)
        {
            departmentListButton.BackColor = departmentListButton.BackColor == Color.MidnightBlue
                ? Color.CornflowerBlue
                : Color.MidnightBlue;

            bool wasDepartmentGridViewVisible = departmentGridView.Visible;
            departmentGridView.Visible = !wasDepartmentGridViewVisible;
            departmentGridViewLabel.Visible = !wasDepartmentGridViewVisible;

            fullTimeDataGridView.Visible = !wasDepartmentGridViewVisible;
            fullTimeDataGridViewLabel.Visible = !wasDepartmentGridViewVisible;

            partTimeDataGridView.Visible = !wasDepartmentGridViewVisible;
            partTimeDataGridViewLabel.Visible = !wasDepartmentGridViewVisible;

            submitPartTimeEmployee.Visible = !wasDepartmentGridViewVisible;
            deletePartTimeEmployee.Visible = !wasDepartmentGridViewVisible;

            submitFullTimeEmployee.Visible = !wasDepartmentGridViewVisible;
            deleteFullTimeEmployee.Visible = !wasDepartmentGridViewVisible;
        }

        private void departmentGridView_SelectionChanged(object sender, EventArgs e)
        {
            Department department = (Department)departmentGridView.CurrentRow.DataBoundItem;

            if (department != null)
            {
                employeeContext = new DatabaseContext();

                employeeContext.FullTimeEmployees.Where(emp => emp.Department == department).Load();
                fullTimeEmployeeBindingSource.DataSource = employeeContext.FullTimeEmployees.Local.ToBindingList();

                employeeContext.PartTimeEmployees.Where(emp => emp.Department == department).Load();
                partTimeEmployeeBindingSource.DataSource = employeeContext.PartTimeEmployees.Local.ToBindingList();
            }
        }

        private void submitPartTimeEmployee_Click(object sender, EventArgs e)
        {
            if (employeeContext == null)
            {
                return;
            }

            if (ValidateDatabaseModification())
            {
                employeeContext.SaveChanges();
                partTimeDataGridView.Refresh();
            }
        }

        private void deletePartTimeEmployee_Click(object sender, EventArgs e)
        {
            if (employeeContext == null)
            {
                return;
            }

            if (ValidateDatabaseModification())
            {
                employeeContext.Remove((PartTimeEmployee)partTimeDataGridView.CurrentRow.DataBoundItem);
                employeeContext.SaveChanges();
                partTimeDataGridView.Refresh();
            }
        }

        private void submitFullTimeEmployee_Click(object sender, EventArgs e)
        {
            if (employeeContext == null)
            {
                return;
            }

            if (ValidateDatabaseModification())
            {
                employeeContext.SaveChanges();
                fullTimeDataGridView.Refresh();
            }
        }

        private void deleteFullTimeEmployee_Click(object sender, EventArgs e)
        {
            if (employeeContext == null)
            {
                return;
            }

            if (ValidateDatabaseModification())
            {
                employeeContext.Remove((FullTimeEmployee)fullTimeDataGridView.CurrentRow.DataBoundItem);
                employeeContext.SaveChanges();
                fullTimeDataGridView.Refresh();
            }
        }

        private void departmentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
