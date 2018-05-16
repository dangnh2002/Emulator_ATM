using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaLapATM.DTO
{
    public class LogDTO
    {
        public int LogID { get; set; }
        public int LogTypeID { get; set; }
        public int CardNo { get; set; }
        public int ATMID { get; set; }
        public DateTime LogDate { get; set; }
        public double Amount { get; set; }
        public string Details { get; set; }
        public double CardToNo { get; set; }
    }
}
