using System.ComponentModel.DataAnnotations;

namespace DatabaseApp.Models;

public class PartTimeEmployee : Employee
{
    private int _weeklyHours;
    [Required]
    public int WeeklyHours { get => _weeklyHours; set => _weeklyHours = value; }

    public PartTimeEmployee() : base() { }

    public PartTimeEmployee(
        string name,
        string phoneNumber,
        int monthlySalaryUsd,
        int bonusSalaryUsd,
        bool isManager,
        Department department,
        SaleTerminal? saleTerminal, 
        int weeklyHours) : base(name, phoneNumber, monthlySalaryUsd, bonusSalaryUsd, isManager, department, saleTerminal)
    {
        WeeklyHours = weeklyHours;
        CalculateTotalSalary();
    }

    public PartTimeEmployee(Employee oldEmployee, int weeklyHours) : base(
    oldEmployee.Name,
    oldEmployee.PhoneNumber,
    oldEmployee.MonthlySalaryUsd,
    oldEmployee.BonusSalaryUsd,
    oldEmployee.IsManager,
    oldEmployee.Department,
    oldEmployee.AssignedSaleTerminal)
    {
        RemoveEmployee(oldEmployee);
        WeeklyHours = weeklyHours;
        CalculateTotalSalary();
    }

    public override void CalculateTotalSalary()
    {
        _totalSalaryUsd = MonthlySalaryUsd + BonusSalaryUsd;
    }
}
