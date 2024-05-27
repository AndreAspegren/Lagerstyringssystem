using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax1
{
    internal class Car : Vehicle
    {
        public int _topSpeed { get; set; }
        public string _color { get; set; }
        public string _type { get; set; }

        public Car(string id, int effect, int topSpeed, string color, string type) : base(id, effect)
        {
            _topSpeed = topSpeed;
            _color = color;
            _type = type;
        }

        public override void printInfo()
        {
            Console.WriteLine($@"Registreringsnummer: {_id} 
KW effekt: {_effect}
Toppfart: {_topSpeed}
Farge: {_color}
Type: {_type}
");
        }

        public override void run()
        {
            Console.WriteLine($"Bilen med id {_id} kjører nå!");
        }
    }
}
