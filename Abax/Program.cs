namespace Abax
{
    class Start
    {
        static void Main(string[] args)
        {
            new App().run();
        }
    }

    class App 
    {
        private List<Cars> cars = new List<Cars>()
        {
            new Cars("NF123456", 147, 200, "grønn", "lett kjøretøy"),
            new Cars("NF654321", 150, 195, "blå", "lett kjøretøy"),
        };

        private List<Planes> plane = new List<Planes>()
        {
            new Planes("LN1234", 1000, 30, 2, 10),
        };

        private List<Boats> boat = new List<Boats>()
        {
            new Boats("ABS123", 100, 30, 500)
        };

        public void run()
        {
            printCars();
            checkCarEquality();
            printPlane();
            printBoat();

            if (Console.ReadLine() == "fly") Console.WriteLine($"Fly med registreringsnummer {plane[0]._reg} flyr!");
            if (Console.ReadLine() == "kjøre") Console.WriteLine($"En bil med registreringsnummer {cars[0]._reg} kjører!");
        }

        private void printCars()
        {
            foreach (var car in cars)
            {
                Console.WriteLine(@$"Registreringsnummer: {car._reg} 
KW effekt: {car._horsePower}
Maks fart: {car._topSpeed}
Farge: {car._color}
Type {car._type}
");
            }
        }
        private void checkCarEquality()
        {
            bool isEqual = false;
            if (cars[0]._reg == cars[1]._reg) isEqual = true;
            if (cars[0]._horsePower == cars[1]._horsePower) isEqual = true;
            if (cars[0]._topSpeed == cars[1]._topSpeed) isEqual = true;
            if (cars[0]._color == cars[1]._color) isEqual = true;
            if (cars[0]._type == cars[1]._type) isEqual = true;
            Console.WriteLine($"Disse to kjøretøyene er {(isEqual ? "like" : "ulike")}");
        }

        private void printPlane()
        {
            Console.WriteLine($@"Registreringsnummer: {plane[0]._reg}
KW effekt: {plane[0]._horsePower}
Vingespenn: {plane[0]._wingspan}
Lasteevne i tonn: {plane[0]._loadLimit}
Egenvekt i tonn: {plane[0]._ownWeight}
");
        }

        private void printBoat()
        {
            Console.WriteLine(@$"Kjennetgn: {boat[0]._id}
KW effekt: {boat[0]._effect}
Topfart: {boat[0]._topSpeed}
Bruttotonasje: {boat[0]._grossTonnage}");
        }

    }
}