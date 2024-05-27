using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagersystem
{
    public interface IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public void WriteoutInfo();
    }
}
