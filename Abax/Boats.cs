using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax
{
    internal class Boats
    {
        public string _id { get; set; }
        public int _effect { get; set; }
        public int _topSpeed { get; set; }
        public int _grossTonnage { get; set; }

        public Boats(string id, int effect, int topSpeed, int grossTonnage)
        {
            _id = id;
            _effect = effect;
            _topSpeed = topSpeed;
            _grossTonnage = grossTonnage;
        }
    }
}
