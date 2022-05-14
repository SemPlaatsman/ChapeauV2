using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAO;

namespace ChapeauLogica
{
    public class BarService
    {
        private BarDAO barDAO;

        public BarService()
        {
            barDAO = new BarDAO();
        }

        public List<BarOrderOverview> GetBarOverviews()
        {
            List<BarOrderOverview> barOverviews = barDAO.GetBarOverviews();
            return barOverviews;
        }
    }
}
