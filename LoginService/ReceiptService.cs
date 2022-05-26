using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAO;

namespace ChapeauLogica
{
    public class ReceiptService : ReceiptDAO
    {
        private ReceiptDAO receiptDAO;

        public ReceiptService()
        {
            receiptDAO = new ReceiptDAO();
        }

        public List<Receipt> GetOrderList(int TableId)
        {
            List<Receipt> orders = receiptDAO.Order(TableId);
            return orders;
        }
    }
}
