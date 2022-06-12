using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Receipt
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public bool IsAlcoholic { get; set; }
        public int Quantity { get; set; }
    }
}
