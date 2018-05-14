using GiaLapATM.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CardBUS
    {
        public static bool ktDangNhap(int soTheATM, int soPIN)
        {
            return cardDAO.Card.ktDangNhap(soTheATM, soPIN);
        }
    }
}
