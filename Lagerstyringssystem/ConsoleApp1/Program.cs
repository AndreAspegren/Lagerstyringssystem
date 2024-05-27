namespace Lagersystem
{
    class Start
    {
        public static void Main()
        {
            new App().Run();
        }
    }

    class App
    {
        private bool gameOn = true;
        public List<IProduct> products = new List<IProduct>()
        {
            new Clothes("Adidas genser", 420),
            new Clothes("Nike genser", 240),
            new Electronics("Macbook Air", 100000),
            new Electronics("Samsung watch 6", 10000),
            new Foods("Kake", 100),
            new Foods("Pølse", 50),
        };

        public void Run()
        {
            var Commands = new Commands(this);

            while (gameOn)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(@"trykk add for å adde, delete for å delete og list for å se alle.");
                string actionType = Console.ReadLine();

                if (actionType != "list")
                {
                    Console.WriteLine(@"hvilken kategori var det? klær, elektronikk, mat?");
                    string category = Console.ReadLine();

                    Console.WriteLine(@"hva heter produktet?");
                    string item = Console.ReadLine();

                    Console.WriteLine(@"hvor mye koster?");
                    string price = Console.ReadLine();
                    int priceInt = int.Parse(price);

                    Commands.checkInput(actionType, category, item, priceInt);
                }
                else
                {
                    products.ForEach(p =>
                    {
                        Console.WriteLine($"{p.Name} {p.Price}");
                        p.WriteoutInfo();
                        Console.WriteLine("");
                    });
                    Console.WriteLine("Trykk ny for å gjøre dette på nytt og done for å avslutte");
                    var endInput = Console.ReadLine();
                    if (endInput == "done") break;
                    else if (endInput == "ny") continue;
                }
            }
        }
    }
}
