using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal abstract class Abstract_Parent : Parent
    {
        public abstract void func();

        public void write()
        {
            Console.WriteLine("Hey");
        }

        public Abstract_Parent(int id, string name, string description) : base(id, name, description)
        {
        }
    }
}
