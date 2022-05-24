using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderGerecht
    {
        public int OrderGerechtId;
        public MenuItem MenuItem;
        public int OrderId;
        public OrderStatus Status;
        public DateTime TimeOfOrder;
        public string Remark;
    }
}
