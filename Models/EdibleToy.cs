using DatabaseApp.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace DatabaseApp.Models;

public class EdibleToy : Toy, IFood
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

    private string _softness;
    [Required]
    public string Softness { get => _softness; set => _softness = value; }

    public EdibleToy(
    string barcode,
    string name,
    float weightKg,
    float priceUsd,
    string? additionalNote,
    int engagementRating,
    int calorieCount,
    int fatCount,
    string softness) : base(barcode, name, weightKg, priceUsd, additionalNote, engagementRating)
    {
        CalorieCount = calorieCount;
        FatCount = fatCount;
        Softness = softness;
        DetermineNutricious();
    }

    public void DetermineNutricious()
    {
        float fatToCalorieRatio = _calorieCount == 0 ? _fatCount : _fatCount / _calorieCount;

        switch (_softness)
        {
            case "Soft":
                _isNutricious = fatToCalorieRatio <= 0.1;
                break;
            case "Medium":
                _isNutricious = fatToCalorieRatio <= 0.3;
                break;
            case "Hard":
                _isNutricious = fatToCalorieRatio <= 0.5;
                break;
            default:
                _isNutricious = fatToCalorieRatio <= 0.2;
                break;
        }
    }
}
