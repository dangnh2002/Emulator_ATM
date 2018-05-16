using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MoneyDAO
    {
        private static MoneyDAO money;
        public static MoneyDAO Money
        {
            get { if (money == null) money = new MoneyDAO(); return MoneyDAO.money; }
            set { MoneyDAO.money = value; }
        }
        public List<MoneyDTO> convertToObject(DataTable input)
        {
            //hàm convert từ DataTable sang list<object>
            List<MoneyDTO> output = new List<MoneyDTO>();
            foreach (DataRow dr in input.Rows)
            {
                MoneyDTO obj = new MoneyDTO();
                obj.MoneyID = Convert.ToInt32(dr["MoneyID"]);
                obj.MoneyValue = Convert.ToInt32(dr["MoneyValue"]);
                output.Add(obj);
            }
            return output;
        }
    }
}
