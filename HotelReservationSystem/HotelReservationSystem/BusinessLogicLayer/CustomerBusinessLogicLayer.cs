//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using DataAccessLayer;

//namespace BusinessLogicLayer
//{
//    class CustomerBusinessLogicLayer
//    {
//        CustomerDataAccessLayer cda = new CustomerDataAccessLayer();
//        //**************************  REGISTER CUSTOMER   *************************************//
//        public int registerCustomer(string CustomerName, string Password, string ConfirmPassword, string DOB, string Email, string PhoneNumber, string Country, string City, string PinCode)
//        {
//            string AlphaNumeric = getCustomerId().ToString();
//            String CustomerId = String.Concat(CustomerName.Substring(0, 1).ToUpper(), AlphaNumeric);
//            int i =  cda.checkCustomerId(CustomerId);
//            if (i == 0)
//            {
//                int x = cda.registerCustomer(CustomerId, CustomerName, Password, ConfirmPassword, DOB, Email, PhoneNumber, Country, City, PinCode);
//                if (x == 1)
//                    return 1;
//                else
//                    return 0;
//            }
//            else
//            {
//                return 0;
//            }

//        }


//        //************************************CUSTOMER BOOKING*********************************************//
//        public int customerBooking(string Customer_Id, string Booking_Id, string today_date, string HotelId, string RoomType, string ArrivalDate, string DepartureDate, string NumberOfNights, string NumberOfAdults, string NumberOfChildren, string NumberOfRooms, string TotalAmount)
//        {
//            //find customer_id,booking_id,transaction_id,payment date

//            int no_of_days = Convert.ToInt16((Convert.ToDateTime(DepartureDate) - Convert.ToDateTime(ArrivalDate)).TotalDays);

//            //int Ac_Rooms = "SELECT No_Of_Ac_Room from HotelDetail where Hotel_Id=@Hotel_Id";
//            //int Non_Ac_Rooms = "SELECT No_Of_Non_Ac_Room from HotelDetail where Hotel_Id=@Hotel_Id";

//            for (int i = 0; i <= no_of_days; i++)
//            {
//                string Date = Convert.ToDateTime(ArrivalDate).AddDays(i).ToString();
//                int x = cda.checkBookingDate(Date);
//                if (x == 1)
//                { //update Room_Availability table
//                    int y = cda.updateRoomAvailability(HotelId, Date, NumberOfRooms, x);
//                }
//                else
//                {
//                    x = 0;
//                    //insert a new row into Room_Availability table
//                    int y = cda.updateRoomAvailability(HotelId, Date, NumberOfRooms, x);
//                }

//            }


//            //int x = 0;// da.customerBooking(CUSTOMER_ID, BOOKING_ID, DateTime.Now.ToShortDateString(), HotelId, RoomType, ArrivalDate, DepartureDate, NumberOfNights, NumberOfAdults, NumberOfChildren, NumberOfRooms, TotalAmount, TransactionId, CustomerName, PaymentDate);
//            //if (x == 1)
//            return 1;
//            //else return 0;

//        }

//        //**************************************  GENERATING RANDOM DATA  ********************************//
//        private static Random random = new Random();

//        public static string getCustomerId()
//        {
//            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//            var chars1 = "0123456789";
//            var chars2 = "!@#$&*_?";

//            var result = new string(
//                Enumerable.Repeat(chars1, 2)
//                          .Select(s => s[random.Next(s.Length)])
//                          .ToArray());
//            var result1 = new string(
//               Enumerable.Repeat(chars, 1)
//                         .Select(s => s[random.Next(s.Length)])
//                         .ToArray());
//            var result2 = new string(
//                Enumerable.Repeat(chars2, 1)
//                          .Select(s => s[random.Next(s.Length)])
//                          .ToArray());

//            return result2 + result + result1;
//        }

//    }
//}
