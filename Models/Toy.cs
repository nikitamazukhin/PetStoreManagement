using System.ComponentModel.DataAnnotations;

namespace DatabaseApp.Models;

public class Toy : Product
{
    private int _engagementRating;
    [Required]
    public int EngagementRating { get => _engagementRating; set => _engagementRating = value; }

    public Toy() : base() { }

    public Toy(
        string barcode,
        string name,
        float weightKg,
        float priceUsd,
        string? additionalNote,
        int engagementRating) : base(barcode, name, weightKg, priceUsd, additionalNote) 
    {
        EngagementRating = engagementRating;
    }
}
