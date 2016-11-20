using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace DataAccessLayer
{
    public class CustomerDataAccessLayer
    {
        
        //***************   SQL CONNECTION STRING   ************************//
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        //string cs = "data source=LAB7-030\\SQLEXPRESS;integrated security=SSPI;database=hms";   
        //******************************************************************//


        //CHECKING BOOKING DATE

        public int checkBookingDate(string BookingDate)
        {
            int x = 0;
            if (cs != null)
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("spCheckBookingDate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Booking_Date", BookingDate);
                cmd.Parameters.Add("@Count", SqlDbType.Int).Direction = ParameterDirection.Output;
                using (con)
                {
                    x = Convert.ToInt16(cmd.ExecuteScalar());

                }
            }
            return x;
        }

        public string[] getCustomerNameAndUserTypeByCustomerId(string Customer_Id)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("spGetCustomerNameAndUserTypeByCustomerId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);
            cmd.Parameters.Add("@Customer_Name", SqlDbType.VarChar,40).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@Customer_Type", SqlDbType.VarChar,3).Direction = ParameterDirection.Output;
            using (con)
            {
                cmd.ExecuteNonQuery();
                string []s=new string[2];
                s[0]= cmd.Parameters["@Customer_Name"].Value.ToString();
                s[1] = cmd.Parameters["@Customer_Type"].Value.ToString();
                return s;
            }
        }

        public int getMaxBookingId()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("spGetMaxBookingId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Count", SqlDbType.Int).Direction = ParameterDirection.Output;
            using (con)
            {
                cmd.ExecuteScalar();
                int x = Convert.ToInt16( cmd.Parameters["@Count"].Value);
                if (x == 0)
                    return 0;
                else
                    return x;
            
            }
        }
        //CUSTOMER BOOKING
        public int customerBooking(string Customer_Id, string Booking_Id, string Booking_date, string HotelId, string RoomType, string ArrivalDate, string DepartureDate, string NumberOfNights, string NumberOfAdults, string NumberOfChildren, string NumberOfRooms, string TotalAmount, string TransactionId, string CustomerName, string PaymentDate)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("spCustomerBooking", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);
            cmd.Parameters.AddWithValue("@Booking_Id", Booking_Id);
            cmd.Parameters.AddWithValue("@Booking_date", Booking_date);
            cmd.Parameters.AddWithValue("@Hotel_Id", "RAD6720");
            cmd.Parameters.AddWithValue("@Arrival_Date", ArrivalDate);
            cmd.Parameters.AddWithValue("@Departure_Date", DepartureDate);
            cmd.Parameters.AddWithValue("@No_Of_Children", NumberOfChildren);
            cmd.Parameters.AddWithValue("@No_Of_Adult", NumberOfAdults);
            cmd.Parameters.AddWithValue("@No_Of_Night", NumberOfNights);
            cmd.Parameters.AddWithValue("@Total_Room", NumberOfRooms);
            cmd.Parameters.AddWithValue("@Room_Type", RoomType);
            cmd.Parameters.AddWithValue("@Transaction_Id", TransactionId);
            cmd.Parameters.AddWithValue("@Customer_Name",CustomerName);
            cmd.Parameters.AddWithValue("Bill_Amount",TotalAmount);
            cmd.Parameters.AddWithValue("Payment_Date", PaymentDate);


            cmd.Parameters.Add("@Status", SqlDbType.Int).Direction = ParameterDirection.Output;

            using (con)
            {
                int x=cmd.ExecuteNonQuery();
                //int x = Convert.ToInt16(cmd.Parameters["@Status"].Value);
                if (x == 2)
                    return 1;
                else
                    return 0;
            }
        }


        public DataSet GetHotels(string sp, string Country_Id, string City_Id)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(sp, con);
            adp.SelectCommand.Parameters.AddWithValue("@Country_Id",Country_Id);
            adp.SelectCommand.Parameters.AddWithValue("@City_Id",City_Id);
            adp.SelectCommand.CommandType=CommandType.StoredProcedure;
            adp.Fill(ds);
            return ds;


        }

         public int CustomerPayAndBook(string CardNumber,string Name,string ExpiryDate,string Cvv)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("spCheckCardDetails",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Card_Number",CardNumber);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Expiry_Date", ExpiryDate);
            cmd.Parameters.AddWithValue("@Cvv",Cvv);
            cmd.Parameters.Add("@Count", SqlDbType.Int).Direction = ParameterDirection.Output;
            using (con)
            {
                cmd.ExecuteScalar();
                int x=Convert.ToInt16(cmd.Parameters["@Count"].Value);
                if (x == 1)
                    return 1;
                else
                    return 0;
            }
        }

         public DataSet GetBookingDetails(string s,string date)
         {
             SqlConnection con = new SqlConnection(cs);
             con.Open();
             DataSet ds = new DataSet();
             SqlDataAdapter adp = new SqlDataAdapter("spGetBookingDetail", con);
             adp.SelectCommand.Parameters.AddWithValue("@Customer_Id",s);
             adp.SelectCommand.Parameters.AddWithValue("@Date",date);

             adp.SelectCommand.CommandType = CommandType.StoredProcedure;
             adp.Fill(ds);
             return ds;

         }

         public int guestDetails(string Booking_Id,string[] adults,string[] children)
         {
             SqlConnection con = new SqlConnection(cs);
             SqlCommand cmd;
             con.Open();
             int adults_length = adults.Length;
             int children_length = children.Length;

             for (int i = 0; i < adults_length; i=i+2)
             {
                 cmd = new SqlCommand("spGuestDetails",con);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@Booking_Id", Booking_Id);
                 cmd.Parameters.AddWithValue("@Guest_Name", adults[i]);
                 cmd.Parameters.AddWithValue("@Guest_Age", adults[i + 1]);
                 cmd.ExecuteNonQuery();

             }
             
             for (int i = 0; i < children_length; i=i+2)
             {
                 cmd = new SqlCommand("spGuestDetails", con);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@Booking_Id", Booking_Id);
                 cmd.Parameters.AddWithValue("@Guest_Name", children[i]);
                 cmd.Parameters.AddWithValue("@Guest_Age", children[i + 1]);
                 cmd.ExecuteNonQuery();
             }

                 return 1;
         }

         public DataSet getGuestDetails(int id)
         {
             SqlConnection con=new SqlConnection(cs);
             DataSet ds=new DataSet();
             con.Open();
             SqlDataAdapter adp=new SqlDataAdapter("spGetGuestDetails",con);
             adp.SelectCommand.Parameters.Add("@Booking_Id",id);
             adp.SelectCommand.CommandType = CommandType.StoredProcedure;
             adp.Fill(ds);
             return ds;
         }


         public DataSet hotelSearch(string From_Date, string To_Date, string Country_Id, string City_Id)
         {
             SqlConnection con = new SqlConnection(cs);
             DataSet ds = new DataSet();
             con.Open();
             SqlDataAdapter adp = new SqlDataAdapter("spHotelSearch", con);
             adp.SelectCommand.Parameters.Add("@From_Date", From_Date);
             adp.SelectCommand.Parameters.Add("@To_Date", To_Date);
             adp.SelectCommand.Parameters.Add("@Country_Id", Country_Id);
             adp.SelectCommand.Parameters.Add("@City_Id", City_Id);
             adp.SelectCommand.CommandType = CommandType.StoredProcedure;
             adp.Fill(ds);
             return ds;
         }



        //RoomAvailability

         public int updateRoomAvailability(string HotelId, string FromDate, string ToDate, string NumberOfAcRooms, string NumberOfNonAcRooms)
        {

            DateTime dtFromDate = Convert.ToDateTime(FromDate);
            DateTime dtToDate = Convert.ToDateTime(ToDate);
            DateTime dtTempFromDate=dtFromDate;

            int flag1=1, flag2=1;

            //while (dtTempFromDate <= dtToDate)
            //{

                SqlConnection con = new SqlConnection(cs);
                con.Open();
               // SqlCommand cmd = new SqlCommand("spCheckRowInRoomAvailability",con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Hotel_Id",HotelId);
                //cmd.Parameters.AddWithValue("@Date", dtTempFromDate);
                //cmd.Parameters.Add("@Count", SqlDbType.Int).Direction = ParameterDirection.Output;
                using (con)
                {
                  //  cmd.ExecuteScalar();
                    //int x = Convert.ToInt16(cmd.Parameters["@Count"].Value);

                    //if (x > 0)
                    ////{
                    //    if(con.State==ConnectionState.Closed)
                    //     con.Open();

                    //    SqlCommand cmd1 = new SqlCommand("spUpdateExistingRowInRoomAvailability", con);
                    //    cmd1.CommandType = CommandType.StoredProcedure;
                    //    cmd1.Parameters.AddWithValue("@Hotel_Id", HotelId);
                    //    cmd1.Parameters.AddWithValue("@Date", dtTempFromDate.ToShortDateString());
                    //    cmd1.Parameters.AddWithValue("@Room_Type", RoomType);
                    //    cmd1.Parameters.AddWithValue("@Number_Of_Rooms", NumberOfRooms);
                    //    using (con)
                    //    {
                    //        int a = cmd1.ExecuteNonQuery();
                    //        if (a > 0)
                    //            flag1 = 1;
                    //        else
                    //            flag1 = 0;
                    //    }

                       
                    ////}
                    //else
                    //{
                    //    if (con.State == ConnectionState.Closed)
                    //        con.Open();

                        SqlCommand cmd1 = new SqlCommand("spInsertNewRowToRoomAvailability", con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@Hotel_Id", HotelId);
                        cmd1.Parameters.AddWithValue("@From_Date", FromDate);
                        cmd1.Parameters.AddWithValue("@To_Date", ToDate);
                        cmd1.Parameters.AddWithValue("@Number_Of_Ac_Rooms", NumberOfAcRooms);
                        cmd1.Parameters.AddWithValue("@Number_Of_Non_Ac_Rooms", NumberOfNonAcRooms);
                      
                        int a = cmd1.ExecuteNonQuery();
                        if (a > 0)
                            flag2 = 1;
                        else
                            flag2 = 0;
                        
                    }
                

               // dtTempFromDate = dtTempFromDate.AddDays(1);
          //  }
            if (flag2 == 1)
                return 1;
            else
                return 0;

           }
      
    
    }

}
