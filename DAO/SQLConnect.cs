using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SQLConnect
    {
        private static SQLConnect instance;

        public static SQLConnect Instance
        {
            get { if (instance == null) instance = new SQLConnect(); return SQLConnect.instance; }
            private set { SQLConnect.instance = value; }
        }
        

        //private static String strSQL = @"Data Source=TECA-PC\SQLEXPRESS;Initial Catalog=Emulator_ATM;Integrated Security=True";
        private static String strSQL = @"Data Source=DESKTOP-PSRRS98\SQLEXPRESSS;Initial Catalog=Emulator_ATM;Integrated Security=True";

        public DataTable ExecuteQuery(String query)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(strSQL))
            {
                try
                {
                    con.Open();
                    SqlCommand cm = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cm);
                    adapter.Fill(table);
                }
                catch (Exception ex)
                {
                    
                }
                finally
                {
                    con.Close();
                }          
            }
            return table;
        }
        public int ExecuteNonQuery(String query)
        {
            int kq = 0;
            using (SqlConnection con = new SqlConnection(strSQL))
            {
                try
                {
                    con.Open();
                    SqlCommand cm = new SqlCommand(query, con);
                    kq = cm.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    
                }
                finally
                {
                    con.Close();
                }
            }
            return kq;

        }
    }
}
