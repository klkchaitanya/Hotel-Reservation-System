using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;


namespace BusinessLogicLayer
{
    public class AdminBusinessAccessClass
    {
        AdminDataAccessClass da = new AdminDataAccessClass();


        //**************************   AUTHENTICATE CUSTOMER   *********************************//
        public int authenticateCustomer(string C_Id, string P_No, string Pass)
        {

            int x = da.authenticateCustomer(C_Id, P_No, Pass);
            if (x == 1)
                return 1;
            else
                return 0;
        }


        //**************************  POPULATE COMBO BOX   ************************************//
        public DataSet GetData(string sp, SqlParameter parameter)
        {
            AdminDataAccessClass da = new AdminDataAccessClass();
            DataSet ds = da.GetData(sp, parameter);
            return ds;
        }

        //**************************  REGISTER CUSTOMER   *************************************//
        public int registerCustomer(string CustomerName, string Password, string ConfirmPassword, string DOB, string Email, string PhoneNumber, string Country, string City, string PinCode)
        {
            string AlphaNumeric = getCustomerId().ToString();

            String CustomerId = String.Concat(CustomerName.Substring(0, 1).ToUpper(), AlphaNumeric);
            int i = da.checkCustomerId(CustomerId);
            if (i == 0)
            {
                int x = da.registerCustomer(CustomerId, CustomerName, Password, ConfirmPassword, DOB, Email, PhoneNumber, Country, City, PinCode);
                if (x == 1)
                    return 1;
                else
                    return 0;
            }
            else
            {
                return 0;
            }

        }

        //********************************  ADMIN ADD HOTEL   **********************************//

        public int addHotel(string HotelName, string Country, string City, string HotelDesc, int NoOfAcRoom, int NoOfNonAcRoom, int RateAdultAc, int RateAdultNonAc, int RateChildAc, int RateChildNonAc, string HotelImage)
        {
            string HotelId = HotelName.Substring(0, 3) + getHotelId().ToString();
            int i = da.checkHotelId(HotelId);
            if (i == 0)
            {
                int j = da.addHotel(HotelId, HotelName, Country, City, HotelDesc, NoOfAcRoom, NoOfNonAcRoom, RateAdultAc, RateAdultNonAc, RateChildAc, RateChildNonAc, HotelImage);
                if (j == 1)
                    return j;
                else
                    return 0;
            }
            else
            {
                return 0;
            }
        }

        //********************************************************************************************//



        //********************************  ADMIN UPDATE HOTEL DETAILS  **********************************//

        public int updateHotelDetail(string HotelId, string HotelName, string HotelDesc, int NoOfAcRoom, int NoOfNonAcRoom, int RateAdultAc, int RateAdultNonAc, int RateChildAc, int RateChildNonAc)
        {
            int j = da.updateHotelDetail(HotelId, HotelName, HotelDesc, NoOfAcRoom, NoOfNonAcRoom, RateAdultAc, RateAdultNonAc, RateChildAc, RateChildNonAc, "HotelImage");
            if (j == 1)
                return j;
            else
                return 0;

        }

        //********************************************************************************************//


        //********************************** ADMIN DELETE HOTEL  ********************************************//

        public int deleteHotel(string Hotel_Id)
        {
            int j = da.deleteHotel(Hotel_Id);
            if (j == 1)
                return j;
            else
                return 0;

        }

        //************************************************************************************************//

        //**************************************  GET HOTEL DETAIL BY HOTEL_ID   ****************************************//

        public DataSet getHotelDetailByHotelId(string Hotel_Id)
        {
            //string HotelId = Hotel_Id;
            int i = da.checkHotelId(Hotel_Id);
            if (i == 1)
            {
                DataSet ds = da.getHotelDetailByHotelId(Hotel_Id);
                if (ds != null)
                {
                    return ds;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        //**************************************  GENERATING RANDOM DATA  ********************************//
        private static Random random = new Random();

        public static string getCustomerId()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var chars1 = "0123456789";
            var chars2 = "!@#$&*_?";

            var result = new string(
                Enumerable.Repeat(chars1, 2)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            var result1 = new string(
               Enumerable.Repeat(chars, 1)
                         .Select(s => s[random.Next(s.Length)])
                         .ToArray());
            var result2 = new string(
                Enumerable.Repeat(chars2, 1)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return result2 + result + result1;
        }
        public static string getHotelId()
        {
            var chars = "0123456789";
            var result = new string(
                Enumerable.Repeat(chars, 4)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
        //***********************************************************************************************//


        //**************************************  GETTING ALL HOTEL ID'S   ********************************//

        public DataSet getAllHotelId()
        {
            DataSet ds = da.getAllHotelId();
            return ds;
        }
    }
}
