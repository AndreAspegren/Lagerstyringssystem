using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Child1 : Parent
    {
        public Child1(int id, string name, string description) : base(id, name, description)
        {
        }

        public override void show()
        {
            Console.WriteLine($"{Id} {Name} {Description} {Id}");
        }
    }
}
