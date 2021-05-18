using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Candy : VendingMachine
    {
        public static readonly Candy ChocolateBar = new Candy { Name = "Chocolate-Bar", Price = 16M, ID = 1 };
        public static readonly Candy Chips = new Candy { Name = "Bag of Chips", Price = 21M, ID = 2 };

        public static List<Candy> Menu = new List<Candy>
        {
            ChocolateBar,
            Chips,

        };
    }
}
