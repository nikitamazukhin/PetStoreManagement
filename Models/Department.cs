using DatabaseApp.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DatabaseApp.Models;

public class Department
{
    private int _id;
    public int Id { get => _id; set => _id = value; }

    private string _name;
    [Required]
    public string Name { get => _name; set => _name = value; }

    private List<string> _requiredCertifications;
    [Required]
    public List<string> RequiredCertifications { get => _requiredCertifications; set => _requiredCertifications = value; }

    private HashSet<Employee> _employees = [];
    public HashSet<Employee> Employees { get => _employees; set => _employees = value; }

    public Department() { }

    public Department(string name, List<string> requiredCertifications) 
    {
        Name = name;
        RequiredCertifications = requiredCertifications;
    }

    public void AddEmployee(Employee employee) 
    {
        _employees.Add(employee);

        if (employee.Department != this) 
        {
            employee.Department.RemoveEmployee(employee);
            employee.Department = this;
        }
    }

    private void RemoveEmployee(Employee employee) 
    {
        _employees.Remove(employee);
    }

    public static List<Department> ShowDepartmentList() 
    {
        DatabaseContext context = new DatabaseContext();
        return context.Departments.FromSql($"SELECT * FROM Departments").AsNoTracking().ToList();
    }
}
