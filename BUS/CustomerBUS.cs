using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerBUS
    {
        public static CustomerDTO getByCustID(long ID)
        {
            return CustomerDAO.Customer.getByCustID(ID);
        }
    }
}
