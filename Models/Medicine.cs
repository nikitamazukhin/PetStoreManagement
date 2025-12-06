using System.ComponentModel.DataAnnotations;

namespace DatabaseApp.Models;

public class Medicine : Product
{
    private int _dosageMg;
    [Required]
    public int DosageMg { get => _dosageMg; set => _dosageMg = value; }

    private bool _needsPrescription;
    [Required]
    public bool NeedsPrescription { get => _needsPrescription; set => _needsPrescription = value; }

    public Medicine() : base() { }

    public Medicine(
        string barcode,
        string name,
        float weightKg,
        float priceUsd,
        string? additionalNote,
        int dosageMg,
        bool needsPrescription) : base(barcode, name, weightKg, priceUsd, additionalNote)
    {
        DosageMg = dosageMg;
        NeedsPrescription = needsPrescription;
    }
}
