using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Beverage : VendingMachine
    {
        public static readonly Beverage CocaCola = new Beverage { Name = "Coca-Cola", Price = 10M, ID = 1 };
        public static readonly Beverage PepsiMax = new Beverage { Name = "Pepsi Max", Price = 14M, ID = 2 };
        public static readonly Beverage Fanta = new Beverage { Name = "Fanta", Price = 10M, ID = 3 };
        public static readonly Beverage Sprite = new Beverage { Name = "Sprite", Price = 10M, ID = 4 };

        public static List<Beverage> Menu = new List<Beverage>
        {
            CocaCola,
            PepsiMax,
            Fanta,
            Sprite,
        };
    }
}
