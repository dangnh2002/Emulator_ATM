using GiaLapATM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaLapATM.DAO
{
    public class LogTypeDAO
    {
        private static LogTypeDAO logtype;
        public static LogTypeDAO LogType
        {
            get { if (logtype == null) logtype = new LogTypeDAO(); return LogTypeDAO.logtype; }
            set { LogTypeDAO.logtype = value; }
        }
        public List<LogTypeDTO> convertToObject(DataTable input)
        {
            List<LogTypeDTO> output = new List<LogTypeDTO>();
            foreach (DataRow dr in input.Rows)
            {
                LogTypeDTO obj = new LogTypeDTO();
                obj.LogTypeID = Convert.ToInt32(dr["LogTypeID"]);
                obj.Description = Convert.ToString(dr["Description"]);
                output.Add(obj);
            }
            return output;
        }
    }
}
