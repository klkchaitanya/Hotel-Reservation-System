using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataAccessLayer
{
    public class AdminDataAccessClass
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

        //******************************************************************//
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

        //*************   Code For Admin Add Hotel   ************************//

        public int checkHotelId(string Hotel_Id)
        {
            if (cs != null)
            {
                SqlConnection scon = new SqlConnection(cs);
                SqlCommand scmd = new SqlCommand("spCheckHotelId", scon);
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.Parameters.AddWithValue("@Hotel_Id", Hotel_Id);
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
                    //ct = Convert.ToInt16(scmd.ExecuteScalar());
                    return ct;
                }
            }
            else
            {
                return -1;
            }
        }

        public int addHotel(string HotelId, string HotelName, string Country, string City, string HotelDesc, int NoOfAcRoom, int NoOfNonAcRoom, int RateAdultAc, int RateAdultNonAc, int RateChildAc, int RateChildNonAc, string HotelImage)
        {
            if (cs != null)
            {
                SqlConnection scon = new SqlConnection(cs);
                SqlCommand scmd = new SqlCommand("spAddHotel", scon);
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.Parameters.AddWithValue("@Hotel_Id", HotelId);
                scmd.Parameters.AddWithValue("@Hotel_Name", HotelName);
                scmd.Parameters.AddWithValue("@Country", Country);
                scmd.Parameters.AddWithValue("@City", City);
                scmd.Parameters.AddWithValue("@Hotel_Desc", HotelDesc);
                scmd.Parameters.AddWithValue("@No_Of_Ac_Room", NoOfAcRoom);
                scmd.Parameters.AddWithValue("@No_Of_Non_Ac_Room", NoOfNonAcRoom);
                scmd.Parameters.AddWithValue("@Rate_Adult_Ac", RateAdultAc);
                scmd.Parameters.AddWithValue("@Rate_Adult_Non_Ac", RateAdultNonAc);
                scmd.Parameters.AddWithValue("@Rate_Child_Ac", RateChildAc);
                scmd.Parameters.AddWithValue("@Rate_Child_Non_Ac", RateChildNonAc);
                scmd.Parameters.AddWithValue("@Hotel_Image", HotelImage);
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

        //******************************************************************//


        //************************  UPDATE HOTEL DETAILS  ***************************//


        public int updateHotelDetail(string HotelId, string HotelName, string HotelDesc, int NoOfAcRoom, int NoOfNonAcRoom, int RateAdultAc, int RateAdultNonAc, int RateChildAc, int RateChildNonAc, string HotelImage)
        {
            if (cs != null)
            {
                SqlConnection scon = new SqlConnection(cs);
                SqlCommand scmd = new SqlCommand("spUpdateHotelDetail", scon);
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.Parameters.AddWithValue("@Hotel_Id", HotelId);
                scmd.Parameters.AddWithValue("@Hotel_Name", HotelName);
                scmd.Parameters.AddWithValue("@Hotel_Desc", HotelDesc);
                scmd.Parameters.AddWithValue("@No_Of_Ac_Room", NoOfAcRoom);
                scmd.Parameters.AddWithValue("@No_Of_Non_Ac_Room", NoOfNonAcRoom);
                scmd.Parameters.AddWithValue("@Rate_Adult_Ac", RateAdultAc);
                scmd.Parameters.AddWithValue("@Rate_Adult_Non_Ac", RateAdultNonAc);
                scmd.Parameters.AddWithValue("@Rate_Child_Ac", RateChildAc);
                scmd.Parameters.AddWithValue("@Rate_Child_Non_Ac", RateChildNonAc);
                scmd.Parameters.AddWithValue("@Hotel_Image", HotelImage);
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

        //******************************************************************//




        //************************  REGISTER CUSTOMER  ***************************//

        public int checkCustomerId(string Cust_Id)
        {
            if (cs != null)
            {
                SqlConnection scon = new SqlConnection(cs);
                SqlCommand scmd = new SqlCommand("spCheckCustomerId", scon);
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.Parameters.AddWithValue("@Cust_Id", Cust_Id);
                //SqlParameter Count = new SqlParameter();
                //Count.ParameterName = "@Count";
                //Count.Direction = ParameterDirection.Output;
                //Count.SqlDbType = SqlDbType.Int;
                //scmd.Parameters.Add(Count);
                using (scon)
                {
                    scon.Open();
                    int ct;
                    ct = Convert.ToInt16(scmd.ExecuteScalar());
                    return ct;
                }
            }
            else
            {
                return 1;
            }
        }

        public int registerCustomer(string CustomerId, string CustomerName, string Password, string ConfirmPassword, string DOB, string Email, string PhoneNumber, string Country, string City, string PinCode)
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
                scmd.Parameters.AddWithValue("@Pin_Code",Convert.ToInt32( PinCode));

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
        //******************************************************************//

        //**************************   ADMIN DELETE HOTEL   ***************************//

        public int deleteHotel(string Hotel_Id)
        {
            if (cs != null)
            {
                SqlConnection scon = new SqlConnection(cs);
                SqlCommand scmd = new SqlCommand("spDeleteHotelDetail", scon);
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.Parameters.AddWithValue("@Hotel_Id", Hotel_Id);

                SqlParameter Count = new SqlParameter();
                Count.ParameterName = "@Count";
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

        public DataSet getHotelDetailByHotelId(string Hotel_Id)
        {
            SqlConnection scon = new SqlConnection(cs);
            SqlDataAdapter sda = new SqlDataAdapter("spGetHotelDetailByHotelId", scon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter = new SqlParameter("@Hotel_Id", Hotel_Id);
            if (parameter != null)
            {
                sda.SelectCommand.Parameters.Add(parameter);
            }
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;



            //        if (cs != null)
            //        {
            //            SqlConnection scon = new SqlConnection(cs);
            //            SqlCommand scmd = new SqlCommand("spGetHotelDetailByHotelId", scon);
            //            SqlDataReader sdr;
            //            DataSet ds = new DataSet();
            //            scmd.CommandType = CommandType.StoredProcedure;
            //            scmd.Parameters.AddWithValue("@Hotel_Id", Hotel_Id);
            //            using (scon)
            //            {
            //                scon.Open();
            //                ds = scmd.ExecuteReader();
            //                using (sdr = scmd.ExecuteReader())
            //                {
            //                    DataTable dt = new DataTable();
            //                    dt.Columns.Add("Hotel_Name");
            //                    dt.Columns.Add("Country_Id");
            //                    dt.Columns.Add("City_Id");
            //                    dt.Columns.Add("Hotel_Description");
            //                    dt.Columns.Add("No_Of_Ac_Room");
            //                    dt.Columns.Add("No_Of_Non_Ac_Room");
            //                    dt.Columns.Add("Rate_Child_Ac");
            //                    dt.Columns.Add("Rate_Child_Non_Ac");
            //                    dt.Columns.Add("Rate_Adult_Ac");
            //                    dt.Columns.Add("Rate_Adult_Non_Ac");
            //                    while (sdr.Read())
            //                    {
            //                        DataRow dr = dt.NewRow();
            //                        dr["Hotel_Name"] = sdr["Hotel_Name"];
            //                        dr["Country_Id"] = sdr["Country_Id"];
            //                        dr["City_Id"] = sdr["City_Id"];
            //                        dr["Hotel_Description"] = sdr["Hotel_Description"];
            //                        dr["No_Of_Ac_Room"] = sdr["No_Of_Ac_Room"];
            //                        dr["No_Of_Non_Ac_Room"] = sdr["No_Of_Non_Ac_Room"];
            //                        dr["Rate_Child_Ac"] = sdr["Rate_Child_Ac"];
            //                        dr["Rate_Child_Non_Ac"] = sdr["Rate_Child_Non_Ac"];
            //                        dr["Rate_Adult_Ac"] = sdr["Rate_Adult_Ac"];
            //                        dr["Rate_Adult_Non_Ac"] = sdr["Rate_Adult_Non_Ac"];
            //                        dt.Rows.Add(dr);
            //                    }
            //                    return dt;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            return null;
            //        }
        }

        //**********************************  GET ALL HOTEL ID'S   ********************************//
        public DataSet getAllHotelId()
        {
            SqlConnection scon = new SqlConnection(cs);
            SqlDataAdapter sda = new SqlDataAdapter("spGetAllHotelId", scon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}
