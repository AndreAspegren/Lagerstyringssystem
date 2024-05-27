using Abax1;

class Start
{
    public static void Main(string[] args)
    {
        new App().Run();
    }
}

class App
{
    public void Run()
    {
        List<Vehicle> vehicles = new List<Vehicle>()
        {
            new Car("NF123456", 147, 200, "grønn", "lett kjøretøy"),
            new Car("NF654321", 150, 195, "blå", "lett kjøretøy"),
            new Plane("LN1234", 1000, 30, 2, 10),
            new Boat("ABC123", 100, 30, 500)
        };
        var isEqual = false;
        if (vehicles[0]._id == vehicles[1]._id) isEqual = true;

        foreach (var vehicle in vehicles)
        {
            vehicle.printInfo();
        }

        Console.WriteLine($"Bil nummer en og bil nummer 2 er {(isEqual ? "like" : "ulike")}!");

        Console.WriteLine("skriv fly for å fly!");
        if (Console.ReadLine() == "fly") vehicles[2].run();
        Console.WriteLine("skriv kjør for å kjøre!");
        if (Console.ReadLine() == "kjør") vehicles[0].run();


    }
}