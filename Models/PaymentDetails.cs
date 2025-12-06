using DatabaseApp.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DatabaseApp.Models;

public enum State 
{
    Pending = 0,
    Successful = 1
}

public class PaymentDetails
{
    private int _id;
    public int Id { get => _id; set => _id = value; }

    private DateTime _dateTimeOfCreation;
    [Required]
    public DateTime DateTimeOfCreation { get => _dateTimeOfCreation; set => _dateTimeOfCreation = value; }

    private DateTime? _dateTimeOfPayment;
    public DateTime? DateTimeOfPayment
    {
        get => _dateTimeOfPayment;
        set
        {
            _dateTimeOfPayment = value;

            if (value != null)
            {
                State = State.Successful;
            }

            else
            {
                State = State.Pending;
            }
        }
    }

    private State _state;
    [Required]
    public State State { get => _state; set => _state = value; }

    private readonly SaleTerminal _createdByTerminal;
    [Required]
    public SaleTerminal CreatedByTerminal { get => _createdByTerminal; }

    private List<Product> _products = [];
    public List<Product> Products { get => _products; set => _products = value; }

    public PaymentDetails() { }

    public PaymentDetails(DateTime dateTimeOfCreation, DateTime? dateTimeOfPayment, SaleTerminal createdByTerminal, List<Product> products) 
    {
        DateTimeOfCreation = dateTimeOfCreation;
        DateTimeOfPayment = dateTimeOfPayment;
        _createdByTerminal = createdByTerminal;
        createdByTerminal.AddPaymentDetails(this);

        foreach (Product product in products) 
        {
            _products.Add(product);
            product.PaymentDetails = this;
        }
    }

    public void Confirm(DateTime dateTimeOfPayment) 
    {
        DatabaseContext context = new DatabaseContext();
        DateTimeOfPayment = dateTimeOfPayment;
        context.Update(this);
        context.SaveChanges();
    }

    public void Cancel() 
    {
        DatabaseContext context = new DatabaseContext();
        _createdByTerminal.RemovePaymentDetails(this);
        context.Update(_createdByTerminal);

        foreach (var product in _products) 
        {
            product.PaymentDetails = null;
            context.Update(product);
        }

        context.Remove(this);
        context.SaveChanges();
    }

    public static void CheckPendingPaymentTime() 
    {
        DatabaseContext context = new DatabaseContext();
        DateTime compareDate = DateTime.Now.AddMinutes(-1);
        List<PaymentDetails> paymentDetails = context.PaymentDetails.FromSql($"SELECT * FROM PaymentDetails WHERE State = 0 AND DateTimeOfCreation <= '{compareDate}'").AsNoTracking().ToList();

        foreach (PaymentDetails payment in paymentDetails) 
        {
            payment.Cancel();
        }
    }
}
