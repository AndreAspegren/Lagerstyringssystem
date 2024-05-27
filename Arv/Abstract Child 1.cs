using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Abstract_Child_1 : Abstract_Parent
    {
        public override void func()
        {
            Console.WriteLine("Check");
        }

        public Abstract_Child_1(int id, string name, string description) : base(id, name, description)
        {
        }
    }
}
