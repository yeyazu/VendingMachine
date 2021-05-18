using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    abstract class VendingMachine
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ID { get; set; }

        

    }
}
