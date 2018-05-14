using GiaLapATM.DAO;
using GiaLapATM.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBUS
    {
        public static AccountDTO getByAccountNo(int SoTheATM)
        {
            return AccountDAO.Account.getByAccountNo(SoTheATM);
        }
        public static bool ChuyenTien(int fromthe, int tothe, int sotien)
        {
            return AccountDAO.Account.ChuyenTien(fromthe, tothe, sotien);
        }
    }
}
