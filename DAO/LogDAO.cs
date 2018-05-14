using GiaLapATM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaLapATM.DAO
{
    public class LogDAO
    {
        private static LogDAO log;
        public static LogDAO Log
        {
            get { if (log == null) log = new LogDAO(); return LogDAO.log; }
            set { LogDAO.log = value; }
        }
        public List<LogDTO> convertToObject(DataTable input)
        {
            List<LogDTO> output = new List<LogDTO>();
            foreach (DataRow dr in input.Rows)
            {
                LogDTO obj = new LogDTO();
                obj.LogID = Convert.ToInt32(dr["LogID"]);
                obj.LogTypeID = Convert.ToInt32(dr["LogTypeID"]);
                obj.CardNo = Convert.ToInt32(dr["CardNo"]);
                obj.ATMID = Convert.ToInt32(dr["ATMID"]);
                obj.LogDate = Convert.ToDateTime(dr["LogDate"]);
                obj.Amount = Convert.ToInt32(dr["Amount"]);
                obj.Details = Convert.ToString(dr["Details"]);
                obj.CardToNo = Convert.ToInt32(dr["CardToNo"]);
                output.Add(obj);
            }
            return output;
        }
        public bool ChuyenTien(int fromthe, int tothe, int sotien, string details)
        {
            try
            {
                LogDTO model = new LogDTO();
                model.Amount = sotien;
                model.CardNo = fromthe;
                model.CardToNo = tothe;
                model.LogDate = DateTime.Now;
                model.LogTypeID = 1;
                Random rnd = new Random();
                model.ATMID = rnd.Next(1,10);
                model.Details = details;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<LogDTO> getByDate(DateTime FromDate,DateTime ToDate)
        {
            DataTable data = SQLConnect.Instance.ExecuteQuery("select * from tbl_Log where LogDate between " + FromDate + " and " + ToDate);
            List<LogDTO> model = new List<LogDTO>();
            if (data.Rows.Count > 0)
            {
                model = convertToObject(data);
            }
            return model;
        }
    }
}
