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
            //hàm convert từ DataTable sang list<object>
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
        public bool ChuyenTien(double fromthe, double tothe, double sotien, string details)
        {
            try
            {
                AccountDTO account = AccountDAO.Account.getByAccountNo(fromthe);    // lấy thông tin account theo số thẻ
                cardDTO Card = cardDAO.Card.getByAccountID(account.AcountID);       // lấy thông tin thẻ theo accoutID
                //tạo object để ghi log
                LogDTO model = new LogDTO();
                model.Amount = sotien;                                          // số tiền giao dịch
                model.CardNo = Card.CardNo;                                     // số thẻ chuyển tiền đi
                model.CardToNo = tothe;                                         // số thẻ nhận tiền
                model.LogDate = DateTime.Now;                                   // thời gian giao dịch (lấy ngày giờ hiện tại)
                model.LogTypeID = 1;                                            // gán kiểu giao dịch là giao dịch tại cây atm
                Random rnd = new Random();                                      // khởi tạo hàm random
                model.ATMID = rnd.Next(1, 11);                                  // random ID máy atm
                model.Details = fromthe + " to " + tothe + ": " + details;      // nội dung giao dịch
                // tạo cậu sql command để insert object ghi log bên trên vào DB
                var query = "insert into tbl_Log (LogTypeID,CardNo,ATMID,LogDate,Amount,Details,CardToNo) values("
                            + model.LogTypeID + "," + model.CardNo + "," + model.ATMID + ",'" + model.LogDate + "'," + model.Amount + ",'" + model.Details + "'," + model.CardToNo + ")";
                //thực hiện cậu query insert vào Database
                SQLConnect.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<LogDTO> get5Rows(int sothe)
        {
            //lấy ra 5 giao dịch gần nhất
            AccountDTO account = AccountDAO.Account.getByAccountNo(sothe);  // lấy thông tin account theo số thẻ
            cardDTO card = cardDAO.Card.getByAccountID(account.AcountID);   // lấy thông tin thẻ theo accoutID
            //câu sql lấy ra toàn bộ giao dịch theo số thẻ được sắp xếp ngược theo LogDate
            var query = "select * from tbl_Log where Cardno = " + card.CardNo + " order by LogDate desc";
            //thực hiện câu lênh query bên trên
            DataTable data = SQLConnect.Instance.ExecuteQuery(query);
            //tạo list<object> để trả ra
            List<LogDTO> model = new List<LogDTO>();
            //check nếu có bản ghi trả ra thì convert từ DataTable về list<object>
            if (data.Rows.Count > 0)
            {
                model = convertToObject(data).Take(5).OrderBy(x=>x.LogDate).ToList();// lấy ra 5 bản ghi và sắp xếp lại theo LogDate
            }
            return model;
        }
        public List<LogDTO> getByDate(DateTime FromDate, DateTime ToDate)
        {
            //lấy ra những giao dịch khi nhập từ ngày, đến ngày
            DataTable data = SQLConnect.Instance.ExecuteQuery("select * from tbl_Log where LogDate between " + FromDate + " and " + ToDate);
            List<LogDTO> model = new List<LogDTO>();
            //check nếu có bản ghi trả ra thì convert từ DataTable về list<object>
            if (data.Rows.Count > 0)
            {
                model = convertToObject(data);
            }
            return model;
        }
    }
}
