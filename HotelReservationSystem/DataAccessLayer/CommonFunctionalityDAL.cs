using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccessLayer
{
    public class CommonFunctionalityDAL
    {
        //***************   SQL CONNECTION STRING   ************************//
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        //string cs = "data source=LAB7-030\\SQLEXPRESS;integrated security=SSPI;database=hms";   
        //******************************************************************//

        //**************  CUSTOMER AUTHENTICATION  ***************************//
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
        //********************************************************************************************//


        //************************  REGISTER CUSTOMER  ***************************//

        public int checkCustomerId(string Cust_Id)
        {
            if (cs != null)
            {
                SqlConnection scon = new SqlConnection(cs);
                SqlCommand scmd = new SqlCommand("spCheckCustomerId", scon);
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.Parameters.AddWithValue("@Cust_Id", Cust_Id);
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
                return 1;
            }
        }

        public int registerCustomer(string CustomerId, string CustomerName, string Password, string DOB, string Email, string PhoneNumber, string Country, string City, string PinCode,string ut)
        {
            if (cs != null)
            {
                SqlConnection scon = new SqlConnection(cs);
                SqlCommand scmd = new SqlCommand("spRegisterCustomer", scon);
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.Parameters.AddWithValue("@Customer_Id", CustomerId);
                scmd.Parameters.AddWithValue("@Customer_Name", CustomerName);
                scmd.Parameters.AddWithValue("@Password", Password);
                scmd.Parameters.AddWithValue("@Date_Of_Birth", DOB);
                scmd.Parameters.AddWithValue("@Email", Email);
                scmd.Parameters.AddWithValue("@Contact_Number", PhoneNumber);
                scmd.Parameters.AddWithValue("@Country_Id", Country);
                scmd.Parameters.AddWithValue("@City_Id", City);
                scmd.Parameters.AddWithValue("@Pin_Code", PinCode);
                scmd.Parameters.AddWithValue("@Customer_Type", ut);
                SqlParameter Count = new SqlParameter();
                Count.ParameterName = "@Status";
                Count.Direction = ParameterDirection.Output;
                Count.SqlDbType = SqlDbType.Int;

                scmd.Parameters.Add(Count);
                using (scon)
                {
                    scon.Open();
                    int ct;
                    scmd.ExecuteNonQuery();
                    ct = Convert.ToInt16(Count.Value);
                    return ct;
                }
            }
            else
            {
                return 0;
            }

        }
        //********************************************************************************************//

        //**************  CUSTOMER AUTHENTICATION  ***************************//
        public int checkEmailAndPhoneNo(string Email_Id, string Contact_No)
        {
            if (cs != null)
            {
                SqlConnection scon = new SqlConnection(cs);
                SqlCommand scmd = new SqlCommand("spcheckEmailAndPhoneNo", scon);
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.Parameters.AddWithValue("@Email_Id", Email_Id);
                scmd.Parameters.AddWithValue("@Contact_Number", Contact_No);
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
                return 1;
            }

        }
        //********************************************************************************************//


    }
}
