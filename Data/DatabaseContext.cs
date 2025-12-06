using DatabaseApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseApp.Data;


public class DatabaseContext : DbContext
{
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<FullTimeEmployee> FullTimeEmployees => Set<FullTimeEmployee>();
    public DbSet<PartTimeEmployee> PartTimeEmployees => Set<PartTimeEmployee>();
    public DbSet<SaleTerminal> SaleTerminals => Set<SaleTerminal>();
    public DbSet<PaymentDetails> PaymentDetails => Set<PaymentDetails>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Furniture> Furniture => Set<Furniture>();
    public DbSet<Toy> Toys => Set<Toy>();
    public DbSet<Medicine> Medicine => Set<Medicine>();
    public DbSet<Food> Food => Set<Food>();
    public DbSet<EdibleToy> EdibleToys => Set<EdibleToy>();

    private readonly string _dbPath;

    public DatabaseContext() 
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        _dbPath = Path.Join(path, "store.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={_dbPath}");
}
