using GiaLapATM.DAO;
using GiaLapATM.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LogBUS
    {
        public static bool ChuyenTien(double fromthe, double tothe, double sotien, string details)
        {
            return LogDAO.Log.ChuyenTien(fromthe, tothe, sotien, details);
        }
        public static List<LogDTO> getByDate(DateTime FromDate, DateTime ToDate)
        {
            return LogDAO.Log.getByDate(FromDate, ToDate);
        }
        public static List<LogDTO> get5Rows(int sothe)
        {
            return LogDAO.Log.get5Rows(sothe);
        }
    }
}
