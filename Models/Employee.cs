using DatabaseApp.Data;
using DatabaseApp.Validation;
using System.ComponentModel.DataAnnotations;

namespace DatabaseApp.Models;

public abstract class Employee
{
    private int _id;
    public int Id { get => _id; set => _id = value; }

    private string _name;
    [Required]
    public string Name { get => _name; set => _name = value; }

    private string _phoneNumber;
    [Required]
    [Length(9, 9)]
    public string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            Validate.StringHasLength(value, 9);
            _phoneNumber = value;
        }
    }

    private int _monthlySalaryUsd;
    [Required]
    public int MonthlySalaryUsd 
    { 
        get => _monthlySalaryUsd; 
        set
        {
            _monthlySalaryUsd = value;
            CalculateTotalSalary();
        }
    }

    private int _bonusSalaryUsd;
    public int BonusSalaryUsd
    {
        get => _bonusSalaryUsd;
        set
        {
            _bonusSalaryUsd = value;
            CalculateTotalSalary();
        }
    }

    private bool _isManager;
    [Required]
    public bool IsManager { get => _isManager; set => _isManager = value; }

    protected int _totalSalaryUsd;
    public int TotalSalaryUsd { get => _totalSalaryUsd; }

    private static List<string> _benefits = ["Healthcare", "Gym membership"];
    public static List<string> Benefits { get => _benefits; set => _benefits = value; }

    private Department _department;
    [Required]
    public Department Department
    {
        get => _department;
        set
        {
            _department = value;
            value.AddEmployee(this);
        }
    }

    private int? _assignedSaleTerminalId;
    public int? AssignedSaleTerminalId { get => _assignedSaleTerminalId; set => _assignedSaleTerminalId = value;  }

    private SaleTerminal? _assignedSaleTerminal;
    public SaleTerminal? AssignedSaleTerminal 
    {
        get => _assignedSaleTerminal; 
        set 
        {
            SaleTerminal? oldAssignedSaleTerminal = _assignedSaleTerminal;

            _assignedSaleTerminal = value;

            if (value == null) 
            {
                if (oldAssignedSaleTerminal != null && oldAssignedSaleTerminal.AssignedEmployee == this)
                {
                    oldAssignedSaleTerminal.AssignedEmployee = null;
                }
                _assignedSaleTerminalId = null;
            }

            else
            {
                if (oldAssignedSaleTerminal != null && oldAssignedSaleTerminal.AssignedEmployee != this)
                {
                    oldAssignedSaleTerminal.AssignedEmployee = null;
                }

                if (value.AssignedEmployee != this)
                {
                    value.AssignedEmployee = this;
                    _assignedSaleTerminalId = value.Id;
                }
            }
        } 
    }

    public Employee() { }

    public Employee(
        string name,
        string phoneNumber,
        int monthlySalaryUsd,
        int bonusSalaryUsd,
        bool isManager,
        Department department,
        SaleTerminal? saleTerminal)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        MonthlySalaryUsd = monthlySalaryUsd;
        BonusSalaryUsd = bonusSalaryUsd;
        IsManager = isManager;
        Department = department;
        AssignedSaleTerminal = saleTerminal;
    }

    public abstract void CalculateTotalSalary();

    public static void RemoveEmployee(Employee employee) 
    {
        DatabaseContext context = new DatabaseContext();
        SaleTerminal? saleTerminal = employee.AssignedSaleTerminal;

        if (saleTerminal != null)
        {
            saleTerminal.AssignedEmployee = null;
            context.Update(saleTerminal);
        }

        Department department = employee.Department;
        department.Employees.Remove(employee);
        context.Update(department);
        context.Remove(employee);
        context.SaveChanges();
    }
}
