using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Customer
    {
        private decimal _money = 100M;
        public decimal Money { get { return _money; } set { _money = value; } }

        public List<VendingMachine> customerInventoryList = new List<VendingMachine>();

    }
}
