using DatabaseApp.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DatabaseApp.Models;

public class FullTimeEmployee : Employee
{
    private bool _worksNightShift;
    [Required]
    public bool WorksNightShift 
    { 
        get => _worksNightShift; 
        set
        {
            _worksNightShift = value;
            CalculateTotalSalary();
        }
    }

    private static float _nightShiftSalaryMultiplier = 1.2f;
    public static float NightShiftSalaryMultiplier 
    { 
        get => _nightShiftSalaryMultiplier; 
        set
        {
            _nightShiftSalaryMultiplier = value;
            DatabaseContext context = new DatabaseContext();
            List<Employee> nightShiftEmployees = context.Employees.FromSql($"SELECT * FROM Employee WHERE WorksNightShift = 1").AsNoTracking().ToList();

            foreach (Employee employee in nightShiftEmployees) 
            {
                employee.CalculateTotalSalary();
                context.Update(employee);
            }

            context.SaveChanges();
        }
    }

    public FullTimeEmployee() : base() { }

    public FullTimeEmployee(
        string name,
        string phoneNumber,
        int monthlySalaryUsd,
        int bonusSalaryUsd,
        bool isManager,
        Department department,
        SaleTerminal? saleTerminal,
        bool worksNightShift) : base(name, phoneNumber, monthlySalaryUsd, bonusSalaryUsd, isManager, department, saleTerminal)
    {
        WorksNightShift = worksNightShift;
        CalculateTotalSalary();
    }

    public FullTimeEmployee(Employee oldEmployee, bool worksNightShift) : base(
        oldEmployee.Name,
        oldEmployee.PhoneNumber,
        oldEmployee.MonthlySalaryUsd,
        oldEmployee.BonusSalaryUsd,
        oldEmployee.IsManager,
        oldEmployee.Department,
        oldEmployee.AssignedSaleTerminal) 
    {
        RemoveEmployee(oldEmployee);
        WorksNightShift = worksNightShift;
        CalculateTotalSalary();
    }

    public override void CalculateTotalSalary()
    {
        float baseTotalSalaryUsd = MonthlySalaryUsd + BonusSalaryUsd;

        if (_worksNightShift) 
        {
            baseTotalSalaryUsd *= NightShiftSalaryMultiplier;
        }

        _totalSalaryUsd = (int)baseTotalSalaryUsd;
    }
}
