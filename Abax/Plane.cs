using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax
{
    internal class Planes
    {
        public string _reg { get; private set; }
        public int _horsePower { get; private set; }
        public int _wingspan { get; private set; }
        public int _loadLimit { get; private set; }
        public int _ownWeight { get; private set; }
        public Planes(string reg, int horsePower, int wingSpan, int loadLimit, int ownWeight) 
        {
            _reg = reg;
            _horsePower = horsePower;
            _wingspan = wingSpan;
            _loadLimit = loadLimit;
            _ownWeight = ownWeight;
        }
    }
}
