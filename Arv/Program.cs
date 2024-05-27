using Arv;

class Start : App
{
    static void Main(string[] args)
    {
        new App().Run();
    }
}

internal class App 
{
    private List<Parent> family = new List<Parent>
    {
        new Parent(24, "Per", "En blid gutt"),
        new Child1(10, "Pål", "En sur gutt"),
        new Child2(5, "Espen", "En litt tilbakestående gutt"),
    };

    private List<Abstract_Parent> family2 = new List<Abstract_Parent>()
    {
        new Abstract_Child_1(1, "Morten", "Litt forvirret"),
        new Abstract_Child_2(3423, "Hanne", "Spiller dataspill")
    };
    protected internal void Run()
    {
        var input = Convert.ToInt32(Console.ReadLine());
        foreach (var member in family)
        {
            Console.WriteLine($"{member.Name} {member.Description} {member.Id}");
            member.show();
            Console.WriteLine("");
        }

        foreach (var member in family2)
        {
            Console.WriteLine($"{member.Description} {member.Id} {member.Name}");
            member.func(); 
            Console.WriteLine("");
        }

        Console.WriteLine($"{input}");
    }
}
