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

