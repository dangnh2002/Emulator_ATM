using GiaLapATM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaLapATM.DAO
{
    public class ATMDAO
    {
        private static ATMDAO atm;
        public static ATMDAO ATM
        {
            get { if (atm == null) atm = new ATMDAO(); return ATMDAO.atm; }
            set { ATMDAO.atm = value; }
        }
        public List<ATMDTO> convertToObject(DataTable input)
        {
            List<ATMDTO> output = new List<ATMDTO>();
            foreach (DataRow dr in input.Rows)
            {
                ATMDTO obj = new ATMDTO();
                obj.ATMID = Convert.ToInt32(dr["ATMID"]);
                obj.Branch = Convert.ToString(dr["Branch"]);
                obj.Addr = Convert.ToString(dr["Addr"]);
                output.Add(obj);
            }
            return output;
        }
    }
}
