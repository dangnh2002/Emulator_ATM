using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
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
            //hàm convert từ DataTable sang list<object>
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
        public AccountDTO getByAccountNo(double SoTheATM)
        {
            DataTable data = SQLConnect.Instance.ExecuteQuery("select * from tbl_Account where AccountNo ='" + SoTheATM + "'");//lấy ra account theo số thẻ ATM
            AccountDTO model = new AccountDTO();    // list<object> trả ra
            //check xem có bản ghi nào trả ra không nếu có thì convert về dạng object
            if (data.Rows.Count > 0)
            {
                model = convertToObject(data).FirstOrDefault();
            }
            return model;
        }
        public bool ChuyenTien(double fromthe, double tothe, double sotien)
        {
            try
            {
                //trừ tiền tài khoản đi
                var from_account = getByAccountNo(fromthe); //lấy thông tin account chuyển tiền đi
                from_account.Balance -= sotien;//trừ số tiền trong tài khoản
                var query_from_account = "update tbl_Account set Balance = " + from_account.Balance + " where AcountID = " + from_account.AcountID;// câu lệnh update vào DB
                SQLConnect.Instance.ExecuteNonQuery(query_from_account);//update vào DB
                //cộng tiền tài khoản đến
                var to_account = getByAccountNo(tothe); //lấy thông tin account nhận tiền
                to_account.Balance += sotien;   //cộng thêm tiền vào tài khoản
                var query_to_account = "update tbl_Account set Balance = " + to_account.Balance + " where AcountID = " + to_account.AcountID;// câu lệnh update vào DB
                SQLConnect.Instance.ExecuteNonQuery(query_to_account);//update vào DB

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
