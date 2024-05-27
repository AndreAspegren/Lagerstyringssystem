using Arv;

class Start
{
    static void Main(string[] args)
    {
        new App().Run();
    }
}

class App
{
    public void Run()
    {
        var family = new[]
        {
            new Parent(24, "Per", "En blid gutt"),
            new Child1(10, "Pål", "En sur gutt"),
            new Child2(5, "Espen", "En litt tilbakestående gutt")
        };
        foreach (var member in family)
        {
            Console.WriteLine($"{member.Id} {member.Name} {member.Description}");
            member.show();
            Console.WriteLine("");
        }
    }
}
