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

        //CUSTOMER BOOKING
        public int customerBooking(string Customer_Id, string Booking_Id, string Booking_date, string HotelId, string RoomType, string ArrivalDate, string DepartureDate, string NumberOfNights, string NumberOfAdults, string NumberOfChildren, string NumberOfRooms, string TotalAmount, string TransactionId, string CustomerName, string PaymentDate)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spCustomerBooking", con);
            cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);
            cmd.Parameters.AddWithValue("@Booking_Id", Booking_Id);
            cmd.Parameters.AddWithValue("@Booking_date", Booking_date);
            cmd.Parameters.AddWithValue("@HotelId", HotelId);
            cmd.Parameters.AddWithValue("@ArrivalDate", ArrivalDate);
            cmd.Parameters.AddWithValue("@DepartureDate", DepartureDate);
            cmd.Parameters.AddWithValue("@NumberOfChildren", NumberOfChildren);
            cmd.Parameters.AddWithValue("@NumberOfAdults", NumberOfAdults);
            cmd.Parameters.AddWithValue("@NumberOfNight", NumberOfNights);
            cmd.Parameters.AddWithValue("@NumberOfRooms", NumberOfRooms);
            cmd.Parameters.AddWithValue("@RoomType", RoomType);

            cmd.Parameters.Add("@Status", SqlDbType.Int).Direction = ParameterDirection.Output;

            using (con)
            {
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                    return 1;
                else
                    return 0;
            }
        }

        //RoomAvailability

        //public int updateRoomAvailability(string HotelId, string Date, string NumberOfRooms, int exists)
        //{
        //            //if(exists==0)

        //            //else;
        //}
    }
}
