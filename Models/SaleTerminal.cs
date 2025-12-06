using System.ComponentModel.DataAnnotations;

namespace DatabaseApp.Models;

public class SaleTerminal
{
    private int _id;
    public int Id { get => _id; set => _id = value; }

    private string _name;
    [Required]
    public string Name { get => _name; set => _name = value; }

    private Employee? _assignedEmployee;
    public Employee? AssignedEmployee
    {
        get => _assignedEmployee;
        set
        {
            Employee? oldAssignedEmployee = _assignedEmployee;

            _assignedEmployee = value;

            if (value == null)
            {
                if (oldAssignedEmployee != null && oldAssignedEmployee.AssignedSaleTerminal == this)
                {
                    oldAssignedEmployee.AssignedSaleTerminal = null;
                }
            }

            else
            {
                if (oldAssignedEmployee != null && oldAssignedEmployee.AssignedSaleTerminal != this)
                {
                    oldAssignedEmployee.AssignedSaleTerminal = null;
                }

                if (value.AssignedSaleTerminal != this)
                {
                    value.AssignedSaleTerminal = this;
                }
            }
        }
    }

    private HashSet<PaymentDetails> _createdPaymentDetails = [];
    public HashSet<PaymentDetails> CreatedPaymentDetails { get => _createdPaymentDetails; set => _createdPaymentDetails = value; }

    public SaleTerminal() { }

    public SaleTerminal(string name, Employee? assignedEmployee) 
    {
        Name = name;
        AssignedEmployee = assignedEmployee;
    }

    public void AddPaymentDetails(PaymentDetails paymentDetails)
    {
        CreatedPaymentDetails.Add(paymentDetails);
    }

    public void RemovePaymentDetails(PaymentDetails paymentDetails)
    {
        CreatedPaymentDetails.Remove(paymentDetails);
    }
}
