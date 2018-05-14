using GiaLapATM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaLapATM.DAO
{
    public class cardDAO
    {
        private static cardDAO card;

        public static cardDAO Card
        {
            get { if (card == null) card = new cardDAO(); return cardDAO.card; }
            set { cardDAO.card = value; }
        }
        public bool ktDangNhap(int soTheATM, int soPIN)
        {
            DataTable data = SQLConnect.Instance.ExecuteQuery("select * from tbl_Card join tbl_Account on tbl_Card.AcountID = tbl_Account.AcountID where AccountNo ='" + soTheATM + "' and PIN='" + soPIN + "'");
            var a = convertToObject(data);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }
        public List<cardDTO> convertToObject (DataTable input)
        {
            List<cardDTO> output = new List<cardDTO>();
            foreach (DataRow dr in input.Rows)
            {
                cardDTO obj = new cardDTO();
                obj.CardNo = Convert.ToInt32(dr["CardNo"]);
                obj.AcountID = Convert.ToInt32(dr["AcountID"]);
                obj.PIN = Convert.ToInt32(dr["PIN"]);
                obj.StartDate = Convert.ToDateTime(dr["StartDate"]);
                obj.ExpiredDate = Convert.ToDateTime(dr["ExpiredDate"]);
                obj.Attempt = Convert.ToInt32(dr["Attempt"]);
                obj.Status = Convert.ToInt32(dr["Status"]);
                output.Add(obj);
            }
            return output;
        }
    }
}
