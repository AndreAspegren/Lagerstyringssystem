using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax1
{
    abstract class Vehicle
    {
        public string _id { get; set; }
        public int _effect { get; set; }

        protected Vehicle(string id, int effect)
        {
            _id = id;
            _effect = effect;
        }

        public abstract void printInfo();
        public abstract void run();
    }
}
