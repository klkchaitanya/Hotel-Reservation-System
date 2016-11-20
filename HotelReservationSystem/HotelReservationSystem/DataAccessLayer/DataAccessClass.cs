using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataAccessLayer
{
    public class DataAccessClass
    {
        //string cs = ConfigurationManager.ConnectionStrings[DBCS].ConnectionString;
        //string cs = "data source=LAB7-030\\SQLEXPRESS;integrated security=SSPI;database=hms";   
        string cs="abc";
        public int authenticateCustomer(string C_Id, string P_No, string Pass)
        {
             if (cs != null)
            {
                SqlConnection scon = new SqlConnection(cs);
                SqlCommand scmd = new SqlCommand("spLogin", scon);
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.Parameters.AddWithValue("@Customer_Id", C_Id);
                scmd.Parameters.AddWithValue("@Contact_Number", P_No);
                scmd.Parameters.AddWithValue("@Password", Pass);
                SqlParameter Count = new SqlParameter();
                Count.ParameterName = "@Count";
                Count.Direction = ParameterDirection.Output;
                Count.SqlDbType = SqlDbType.Int;
                scmd.Parameters.Add(Count);
                using (scon)
                {
                    scon.Open();
                    int ct;
                    scmd.ExecuteScalar();
                    ct = Convert.ToInt16(Count.Value);
                    return ct;
                }
            }
            else 
            {
                return 0;
            }

        }

        public DataSet GetData(string sp, SqlParameter parameter)
        {
            //string cs = "data source=INDRANIL;integrated security=SSPI;database=hms";
            SqlConnection scon = new SqlConnection(cs);
            SqlDataAdapter sda = new SqlDataAdapter(sp, scon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;

            if (parameter != null)
            {
                sda.SelectCommand.Parameters.Add(parameter);
            }
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;

        }

        public int registerCustomer(string CustomerId,string CustomerName, string Password, string ConfirmPassword, string DOB, string Email, string PhoneNumber, string Country, string City, string PinCode)
        {
            if (cs != null)
            {
                SqlConnection scon = new SqlConnection(cs);
                SqlCommand scmd = new SqlCommand("spCheckCustomerId", scon);
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.Parameters.AddWithValue("@Cust_Id","abcd" /*CustomerId*/);
               
                SqlParameter Count = new SqlParameter();
                Count.ParameterName = "@Count";
                Count.Direction = ParameterDirection.Output;
                Count.SqlDbType = SqlDbType.Int;

                scmd.Parameters.Add(Count);
                using (scon)
                {
                    scon.Open();
                    int ct;
                    scmd.ExecuteScalar();
                    ct = Convert.ToInt16(Count.Value);
                    return ct;
                }
            }
            else
            {
                return 0;
            }
            
        }

    }
}
