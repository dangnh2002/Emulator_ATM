using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CardBUS
    {
        public static bool ktDangNhap(double soTheATM, double soPIN)
        {
            return cardDAO.Card.ktDangNhap(soTheATM, soPIN);
        }
        public static bool DoiPin(double soTheATM, double soPIN)
        {
            return cardDAO.Card.DoiMaPin(soPIN, soPIN);
        }
    }
}