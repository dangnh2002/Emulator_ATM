using GiaLapATM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaLapATM.DAO
{
    public class ConfigDAO
    {
        private static ConfigDAO config;
        public static ConfigDAO Config
        {
            get { if (config == null) config = new ConfigDAO(); return ConfigDAO.config; }
            set { ConfigDAO.config = value; }
        }
        public List<ConfigDTO> convertToObject(DataTable input)
        {
            List<ConfigDTO> output = new List<ConfigDTO>();
            foreach (DataRow dr in input.Rows)
            {
                ConfigDTO obj = new ConfigDTO();
                obj.ID = Convert.ToInt32(dr["ID"]);
                obj.DateModified = Convert.ToDateTime(dr["DateModified"]);
                obj.MinWithDraw = Convert.ToInt32(dr["MinWithDraw"]);
                obj.MaxWithDraw = Convert.ToInt32(dr["MaxWithDraw"]);
                obj.NumPerPage = Convert.ToInt32(dr["NumPerPage"]);
                output.Add(obj);
            }
            return output;
        }
    }
}
