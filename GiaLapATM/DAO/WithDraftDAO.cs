using GiaLapATM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaLapATM.DAO
{
    public class WithDraftDAO
    {
        private static WithDraftDAO withDraft;
        public static WithDraftDAO WithDraft
        {
            get { if (withDraft == null) withDraft = new WithDraftDAO(); return WithDraftDAO.withDraft; }
            set { WithDraftDAO.withDraft = value; }
        }
        public List<WithDraftDTO> convertToObject(DataTable input)
        {
            List<WithDraftDTO> output = new List<WithDraftDTO>();
            foreach (DataRow dr in input.Rows)
            {
                WithDraftDTO obj = new WithDraftDTO();
                obj.WDID = Convert.ToInt32(dr["WDID"]);
                obj.value = Convert.ToInt32(dr["value"]);
                output.Add(obj);
            }
            return output;
        }
    }
}
