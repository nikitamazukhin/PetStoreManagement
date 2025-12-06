namespace DatabaseApp.Interfaces;

public interface IFood
{
    public int CalorieCount { get; set; }
    public int FatCount { get; set; }
    public bool IsNutricious { get; }

    public void DetermineNutricious();
}
