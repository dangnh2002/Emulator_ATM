using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaLapATM.DTO
{
    public class AccountDTO
    {
        public int AcountID { get; set; }
        public double Balance { get; set; }
        public string AccountNo { get; set; }
        public int CustID { get; set; }
        public int ODID { get; set; }
        public int WDID { get; set; }
    }
}
