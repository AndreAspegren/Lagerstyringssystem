using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax1
{
    class Boat : Vehicle
{
    public int _topSpeed { get; set; }
    public int _grossTonnage { get; set; }

    public Boat(string id, int effect, int topSpeed, int grossTonnage) : base(id, effect)
    {
        _topSpeed = topSpeed;
        _grossTonnage = grossTonnage;
    }

    public override void printInfo()
    {
        Console.WriteLine($@"Kjennetegn: {_id} 
KW effekt: {_effect}
Toppfart: {_topSpeed}
Bruttotonnasje i tonn: {_grossTonnage}
");
        }

    public override void run()
    {
        Console.WriteLine("The boat is running.");
    }
}

}
