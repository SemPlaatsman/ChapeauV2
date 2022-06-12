using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAO;
using ChapeauInterfaces;

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
        public string GetHost(int TableId)
        {
            return receiptDAO.Host(TableId);
        }
        public void StoreReceipt( int TableId, decimal totalPrice, decimal btwTotal, string paymentMethod, DateTime timeOfPayment)
        {
            receiptDAO.InsertReceipt(TableId ,totalPrice, btwTotal, paymentMethod, timeOfPayment);
        }
        public void StoreRemark(int TableId, string remark)
        {
            receiptDAO.InsertRemark(TableId, remark);
        }
    }
}
