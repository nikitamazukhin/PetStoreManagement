using DatabaseApp.Data;

namespace DatabaseApp;

public class Program
{
    public static void Main(string[] args)
    {
        DatabaseContext context = new DatabaseContext();
        context.Database.EnsureCreated();
        DatabaseInitializer.Initialize(context);
        Form form = new MainForm();
        form.ShowDialog();
    }
}