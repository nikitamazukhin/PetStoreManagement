using DatabaseApp.Models;

namespace DatabaseApp.Data;

public static class DatabaseInitializer
{
    public static void Initialize(DatabaseContext context) 
    {
        if (
            context.Departments.Any() &&
            context.Employees.Any() &&
            context.PaymentDetails.Any() &&
            context.Products.Any() &&
            context.SaleTerminals.Any())
        {
            return;
        }

        Department department1 = new Department("Sales", []);
        Department department2 = new Department("Storage", ["Forklift Certification", "Driver's License"]);

        List<Department> departments = [department1, department2];

        Employee employee1 = new FullTimeEmployee("John Black", "732678123", 1000, 0, false, department1, null, false);
        Employee employee2 = new PartTimeEmployee("Garry White", "887898433", 1100, 100, false, department1, null, 8);
        Employee employee3 = new FullTimeEmployee("Bill Brown", "790781123", 1500, 0, true, department1, null, true);
        Employee employee4 = new PartTimeEmployee("Arthur Green", "637884133", 900, 0, false, department1, null, 6);
        Employee employee5 = new FullTimeEmployee("Barbara Grey", "730976123", 1000, 0, false, department2, null, false);
        Employee employee6 = new PartTimeEmployee("Stan Ice", "987898313", 1100, 100, false, department2, null, 8);
        Employee employee7 = new FullTimeEmployee("David Red", "739608123", 1300, 150, true, department2, null, true);
        Employee employee8 = new FullTimeEmployee("Denver Forbes", "166516145", 1300, 0, true, department2, null, false);
        Employee employee9 = new PartTimeEmployee("Carole Gibbs", "647543946", 800, 100, false, department1, null, 7);
        Employee employee10 = new PartTimeEmployee("Rolf Schaefer", "130637812", 600, 0, false, department1, null, 8);
        Employee employee11 = new PartTimeEmployee("Adeline Bishop", "522730040", 760, 0, false, department1, null, 7);
        Employee employee12 = new PartTimeEmployee("Cleo Cummings", "018959211", 1200, 0, false, department2, null, 8);
        Employee employee13 = new PartTimeEmployee("Opal Esparza", "536657479", 1600, 0, false, department2, null, 8);
        Employee employee14 = new PartTimeEmployee("Henrietta Lambert", "996382252", 1200, 0, false, department2, null, 8);
        Employee employee15 = new FullTimeEmployee("Luz Dalton", "147345484", 1500, 0, false, department1, null, true);
        Employee employee16 = new FullTimeEmployee("Shirley Walton", "982378977", 1250, 0, false, department1, null, false);
        Employee employee17 = new FullTimeEmployee("Rosalind Wright", "675203924", 1150, 0, true, department1, null, true);

        List<Employee> employees =
        [
            employee1,
            employee2,
            employee3,
            employee4,
            employee5,
            employee6,
            employee7,
            employee8,
            employee9,
            employee10,
            employee11,
            employee12,
            employee13,
            employee14,
            employee15,
            employee16,
            employee17
        ];

        SaleTerminal saleTerminal1 = new SaleTerminal("Yamaha XGZ1", employee1);
        SaleTerminal saleTerminal2 = new SaleTerminal("Samsung BLP17", employee2);
        SaleTerminal saleTerminal3 = new SaleTerminal("IBM SPSO-32", employee3);

        List<SaleTerminal> saleTerminals = [saleTerminal1, saleTerminal2, saleTerminal3];

        Product product1 = new Furniture("180510123810", "Cat Jungle Pole", 2.5f, 60, null, 160, 60);
        Product product2 = new Furniture("900514423310", "Dog House", 6f, 100, null, 70, 90);
        Product product3 = new Toy("486118963120", "Squeaky Dog Plushie", 0.4f, 30, "Uses AA batteries.", 6);
        Product product4 = new Toy("812398123212", "Sparkly Cat Teaser", 0.2f, 15, null, 10);
        Product product5 = new Medicine("645321068497", "Cat Dewormer", 0.1f, 30, "May cause an allergic reaction.", 10, false);
        Product product6 = new Medicine("345196613464", "Liverazone", 0.13f, 50, null, 15, true);
        Product product7 = new Food("345196613464", "Dog Food", 2f, 50, null, 3000, 1000);
        Product product8 = new Food("415546681464", "Bird Seeds", 1f, 30, null, 1400, 600);
        Product product9 = new EdibleToy("945720082658", "Edible Dog Bone", 0.3f, 35, null, 6, 1400, 600, "Hard");
        Product product10 = new EdibleToy("290403239124", "Bird Chalk", 0.1f, 10, null, 3, 0, 0, "Medium");

        List<Product> products = [product1, product2, product3, product4, product5, product6, product7, product8, product9, product10];

        PaymentDetails paymentDetails1 = new PaymentDetails(DateTime.Now.AddSeconds(-30), null, saleTerminal1, [product1, product3]);
        PaymentDetails paymentDetails2 = new PaymentDetails(DateTime.Now.AddSeconds(-13), DateTime.Now, saleTerminal2, [product7, product10]);

        List<PaymentDetails> paymentDetails = [paymentDetails1, paymentDetails2];

        context.Departments.AddRange(departments);
        context.Employees.AddRange(employees);
        context.SaleTerminals.AddRange(saleTerminals);
        context.Products.AddRange(products);
        context.PaymentDetails.AddRange(paymentDetails);
        context.SaveChanges();
    }
}
