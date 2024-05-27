using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax
{
    class Cars
    {
        public string _reg { get; private set; }
        public int _horsePower { get; private set; } 
        public int _topSpeed { get; private set; }
        public string _color { get; private set; }
        public string _type { get; private set; }

        public Cars(string reg, int horsePower, int topSpeed, string color, string type)
        {
            _reg = reg;
            _horsePower = horsePower;
            _topSpeed = topSpeed;
            _color = color;
            _type = type;
        }
    }
}
