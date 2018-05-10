using GiaLapATM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaLapATM.DAO
{
    public class AccountDAO
    {
        private static AccountDAO account;
        public static AccountDAO Account
        {
            get { if (account == null) account = new AccountDAO(); return AccountDAO.account; }
            set { AccountDAO.account = value; }
        }
        public List<AccountDTO> convertToObject(DataTable input)
        {
            List<AccountDTO> output = new List<AccountDTO>();
            foreach (DataRow dr in input.Rows)
            {
                AccountDTO obj = new AccountDTO();
                obj.AcountID = Convert.ToInt32(dr["AcountID"]);
                obj.Balance = Convert.ToInt32(dr["Balance"]);
                obj.AccountNo = Convert.ToString(dr["AccountNo"]);
                obj.CustID = Convert.ToInt32(dr["CustID"]);
                obj.ODID = Convert.ToInt32(dr["ODID"]);
                obj.WDID = Convert.ToInt32(dr["WDID"]);
                output.Add(obj);
            }
            return output;
        }
    }
}
