using GiaLapATM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaLapATM.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO customer;
        public static CustomerDAO Customer
        {
            get { if (customer == null) customer = new CustomerDAO(); return CustomerDAO.customer; }
            set { CustomerDAO.customer = value; }
        }
        public List<CustomerDTO> convertToObject(DataTable input)
        {
            List<CustomerDTO> output = new List<CustomerDTO>();
            foreach (DataRow dr in input.Rows)
            {
                CustomerDTO obj = new CustomerDTO();
                obj.CustID = Convert.ToInt32(dr["CustID"]);
                obj.Name = Convert.ToString(dr["Name"]);
                obj.Phone = Convert.ToString(dr["Phone"]);
                obj.Email = Convert.ToString(dr["Email"]);
                obj.Addr = Convert.ToString(dr["Addr"]);
                output.Add(obj);
            }
            return output;
        }
    }
}
