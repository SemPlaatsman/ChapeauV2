using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAO;

namespace ChapeauLogica
{
    public class KitchenService
    {
        private KitchenDAO kitchenDAO;

        public KitchenService()
        {
            kitchenDAO = new KitchenDAO();
        }

        public List<KitchenOrderOverview> GetKitchenOverviews()
        {
            List<KitchenOrderOverview> kitchenOverviews = kitchenDAO.GetKitchenOverviews();
            return kitchenOverviews;
        }
    }
}
