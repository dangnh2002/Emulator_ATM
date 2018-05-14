using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaLapATM.DTO
{
    public class cardDTO
    {
        public int CardNo { get; set; }
        public int AcountID { get; set; }
        public int PIN { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int Attempt { get; set; }
        public int Status { get; set; }
    }
}
