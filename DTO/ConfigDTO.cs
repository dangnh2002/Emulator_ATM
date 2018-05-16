using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ConfigDTO
    {
        public int ID { get; set; }
        public DateTime DateModified { get; set; }
        public int MinWithDraw { get; set; }
        public int MaxWithDraw { get; set; }
        public int NumPerPage { get; set; }
    }
}
