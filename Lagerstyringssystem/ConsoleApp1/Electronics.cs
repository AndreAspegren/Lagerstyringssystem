using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagersystem
{
    public class Electronics : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Electronics(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void WriteoutInfo()
        {
            Console.WriteLine($"Dette er {Name} og det koster {Price}");
        }
    }
}
