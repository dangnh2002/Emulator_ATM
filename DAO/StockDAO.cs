using GiaLapATM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaLapATM.DAO
{
    public class StockDAO
    {
        private static StockDAO stock;
        public static StockDAO Stock
        {
            get { if (stock == null) stock = new StockDAO(); return StockDAO.stock; }
            set { StockDAO.stock = value; }
        }
        public List<StockDTO> convertToObject(DataTable input)
        {
            List<StockDTO> output = new List<StockDTO>();
            foreach (DataRow dr in input.Rows)
            {
                StockDTO obj = new StockDTO();
                obj.StockID = Convert.ToInt32(dr["StockID"]);
                obj.MoneyID = Convert.ToInt32(dr["MoneyID"]);
                obj.ATMID = Convert.ToInt32(dr["ATMID"]);
                obj.Quantily = Convert.ToInt32(dr["Quantily"]);
                output.Add(obj);
            }
            return output;
        }
    }
}
