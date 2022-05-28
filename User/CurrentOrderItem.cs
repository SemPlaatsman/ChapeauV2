using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class CurrentOrderItem
    {
        public int ItemId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Remark { get; set; }
        public bool IsAlcoholic { get; set; }
        public int Quantity { get; set; }
    }
}
