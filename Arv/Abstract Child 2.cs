using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Abstract_Child_2 : Abstract_Parent
    {
        public Abstract_Child_2(int id, string name, string description) : base(id, name, description)
        {
        }

        public override void func()
        {
            Console.WriteLine("Woah");
        }
    }
}
