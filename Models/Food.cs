using DatabaseApp.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace DatabaseApp.Models;

public class Food : Product, IFood
{
    private int _calorieCount;
    [Required]
    public int CalorieCount { get => _calorieCount; set => _calorieCount = value; }

    private int _fatCount;
    [Required]
    public int FatCount { get => _fatCount; set => _fatCount = value; }

    private bool _isNutricious;
    [Required]
    public bool IsNutricious { get => _isNutricious; }

    public Food() : base() { }

    public Food(
    string barcode,
    string name,
    float weightKg,
    float priceUsd,
    string? additionalNote,
    int calorieCount,
    int fatCount) : base(barcode, name, weightKg, priceUsd, additionalNote)
    {
        CalorieCount = calorieCount;
        FatCount = fatCount;
        DetermineNutricious();
    }

    public void DetermineNutricious()
    {
        float fatToCalorieRatio = _calorieCount == 0 ? _fatCount : _fatCount / _calorieCount;
        _isNutricious = fatToCalorieRatio <= 0.2;
    }
}
