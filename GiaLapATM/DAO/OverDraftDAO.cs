using GiaLapATM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaLapATM.DAO
{
    public class OverDraftDAO
    {
        private static OverDraftDAO overDraft;
        public static OverDraftDAO OverDraft
        {
            get { if (overDraft == null) overDraft = new OverDraftDAO(); return OverDraftDAO.overDraft; }
            set { OverDraftDAO.overDraft = value; }
        }
        public List<OverDraftDTO> convertToObject(DataTable input)
        {
            List<OverDraftDTO> output = new List<OverDraftDTO>();
            foreach (DataRow dr in input.Rows)
            {
                OverDraftDTO obj = new OverDraftDTO();
                obj.ODID = Convert.ToInt32(dr["ODID"]);
                obj.value = Convert.ToInt32(dr["value"]);
                output.Add(obj);
            }
            return output;
        }
    }
}
