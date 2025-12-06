using DatabaseApp.Data;
using DatabaseApp.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DatabaseApp.Models;

public abstract class Product
{
    private int _id;
    public int Id { get => _id; set => _id = value; }

    [Length(12, 12)]
    private string _barcode;
    [Required]
    public string Barcode
    {
        get => _barcode;
        set
        {
            Validate.StringHasLength(value, 12);
            DatabaseContext context = new DatabaseContext();
            List<Product> storedProducts = context.Products.FromSql($"SELECT * FROM Products").AsNoTracking().ToList();

            foreach (Product product in storedProducts)
            {
                if (product != this && product.Barcode.Equals(value))
                {
                    throw new ArgumentException("Barcode + " + value + " already exists.");
                }
            }

            _barcode = value;
        }
    }

    private string _name;
    [Required]
    public string Name { get => _name; set => _name = value; }

    private float _weightKg;
    [Required]
    public float WeightKg { get => _weightKg; set => _weightKg = value; }

    private float _priceUsd;
    [Required]
    public float PriceUsd { get => _priceUsd; set => _priceUsd = value; }

    private string? _additionalNote;
    public string? AdditionalNote { get => _additionalNote; set => _additionalNote = value; }

    private PaymentDetails? _paymentDetails;
    public PaymentDetails? PaymentDetails { get => _paymentDetails; set => _paymentDetails = value; }

    public Product() { }

    public Product(
        string barcode,
        string name,
        float weightKg,
        float priceUsd,
        string? additionalNote) 
    {
        Barcode = barcode;
        Name = name;
        WeightKg = weightKg;
        PriceUsd = priceUsd;
        AdditionalNote = additionalNote;
    }
}
