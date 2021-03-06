﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
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
            //hàm convert từ DataTable sang list<object>
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
        public CustomerDTO getByCustID(long ID)
        {
            //lấy thông tin khách hàng theo ID
            DataTable data = SQLConnect.Instance.ExecuteQuery("select * from tbl_Customer where CustID ='" + ID + "'");
            CustomerDTO model = new CustomerDTO();  //object trả ra
            if (data.Rows.Count > 0)
            {
                model = convertToObject(data).FirstOrDefault(); //convert từ DataTable về dang object
            }
            return model;
        }
    }
}
