using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax1
{
    internal class Plane : Vehicle
    {
        public int _wingSpan { get; set; }
        public int _loadLimit { get; set; }
        public int _ownWeight { get; set; }

        public Plane(string id, int effect, int topSpeed, int grossTonnage, int ownWeight) : base(id, effect)
        {
            _wingSpan = topSpeed;
            _loadLimit = grossTonnage;
            _ownWeight = ownWeight;
        }

        public override void printInfo()
        {
            Console.WriteLine($@"Kjennetegn: {_id} 
KW effekt: {_effect}
Vingespenn: {_wingSpan}
Lasteevne i tonn: {_loadLimit}
Egenvekt i tonn: {_ownWeight}
");
        }

        public override void run()
        {
            Console.WriteLine($"Flyet med id {_id} flyr nå!");
        }
    }
}
