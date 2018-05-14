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
    }
}
