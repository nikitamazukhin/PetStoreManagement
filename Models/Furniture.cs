using System.ComponentModel.DataAnnotations;

namespace DatabaseApp.Models;

public class Furniture : Product
{
    private int _heightCm;
    [Required]
    public int HeightCm { get => _heightCm; set => _heightCm = value; }

    private int _widthCm;
    [Required]
    public int WidthCm { get => _widthCm; set => _widthCm = value; }

    public Furniture() : base() { }

    public Furniture(
        string barcode,
        string name,
        float weightKg,
        float priceUsd,
        string? additionalNote,
        int heightCm,
        int widthCm) : base(barcode, name, weightKg, priceUsd, additionalNote)
    {
        HeightCm = heightCm;
        WidthCm = widthCm;
    }
}
