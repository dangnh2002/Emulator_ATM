using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBUS
    {
        public static AccountDTO getByAccountNo(double SoTheATM)
        {
            return AccountDAO.Account.getByAccountNo(SoTheATM);
        }
        public static bool ChuyenTien(double fromthe, double tothe, double sotien)
        {
            return AccountDAO.Account.ChuyenTien(fromthe, tothe, sotien);
        }
    }
}
