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
        public AccountDTO getByAccountNo(int SoTheATM)
        {
            DataTable data = SQLConnect.Instance.ExecuteQuery("select * from tbl_Account where AccountNo ='" + SoTheATM + "'");
            AccountDTO model = new AccountDTO();
            if(data.Rows.Count>0)
            {
                model = convertToObject(data).FirstOrDefault();
            }
            return model;
        }
        public bool ChuyenTien(int fromthe, int tothe, int sotien)
        {
            try
            {
                //trừ tiền tài khoản đi
                var from_account = getByAccountNo(fromthe);
                from_account.Balance -= sotien;
                //cộng tiền tài khoản đến
                var to_account = getByAccountNo(tothe);
                to_account.Balance += sotien;
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
