using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace PresentationLayer
{
    public class AdminBusinessAccessClass
    {
        AdminDataAccessClass da = new AdminDataAccessClass();

        
        //**************************  POPULATE COMBO BOX   ************************************//
        public DataSet GetData(string sp, SqlParameter parameter)
        {
            AdminDataAccessClass da = new AdminDataAccessClass();
            DataSet ds = da.GetData(sp, parameter);
            return ds;
        }

        
        //********************************  ADMIN ADD HOTEL   **********************************//

        public int addHotel(string HotelName, string Country, string City, string HotelDesc, int NoOfAcRoom, int NoOfNonAcRoom, int RateAdultAc, int RateAdultNonAc, int RateChildAc, int RateChildNonAc,string HotelImage)
        {
            string HotelId = HotelName.Substring(0, 3).ToUpper() + getHotelId().ToString();
            int i = da.checkHotelId(HotelId);
            if (i == 0)
            {
                int j = da.addHotel(HotelId, HotelName, Country, City, HotelDesc, NoOfAcRoom, NoOfNonAcRoom, RateAdultAc, RateAdultNonAc, RateChildAc, RateChildNonAc,HotelImage);
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
                int j = da.updateHotelDetail(HotelId,HotelName, HotelDesc, NoOfAcRoom, NoOfNonAcRoom, RateAdultAc, RateAdultNonAc, RateChildAc, RateChildNonAc, "HotelImage");
                if (j == 1)
                    return j;
                else
                    return 0;
            
        }

        //********************************************************************************************//


        //********************************** ADMIN DELETE HOTEL  ********************************************//

        public int deleteHotel(string Hotel_Id)
        {
            int j=da.deleteHotel(Hotel_Id);
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

        //**************************************  GETTING ALL HOTEL ID'S   ********************************//

        public DataSet getAllHotelId()
        {
            DataSet ds= da.getAllHotelId();
            return ds;
        }



        //**************************************  GENERATING RANDOM DATA  ********************************//
        private static Random random = new Random();
        
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
    }
}
