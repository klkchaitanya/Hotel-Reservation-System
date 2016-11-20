using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace PresentationLayer
{
    public class CommonFunctionalityBLL
    {
        CommonFunctionalityDAL cfd = new CommonFunctionalityDAL();
        //**************************   AUTHENTICATE CUSTOMER   *********************************//
        public int authenticateCustomer(string C_Id, string P_No, string Pass)
        {

            int x = cfd.authenticateCustomer(C_Id, P_No, Pass);
            if (x == 1)
                return 1;
            else
                return 0;
        }
        //**************************************************************************************//


        //**************************  REGISTER CUSTOMER   *************************************//
        public int registerCustomer(string CustomerName, string Password, string DOB, string Email, string PhoneNumber, string Country, string City, string PinCode,string ut)
        {
            string AlphaNumeric = getCustomerId().ToString();
            string CustomerId;
            int rcode=cfd.checkEmailAndPhoneNo(Email,PhoneNumber);
            if(rcode>=1)
            {
                return 0;
            }
            else
            {
                if (CustomerName != "")
                {
                    CustomerId = String.Concat(CustomerName.Substring(0, 1).ToUpper(), AlphaNumeric);
                }
                else
                {
                    CustomerId = "";
                }
                int i = cfd.checkCustomerId(CustomerId);
                if (i == 0)
                {
                    int x = cfd.registerCustomer(CustomerId, CustomerName, Password, DOB, Email, PhoneNumber, Country, City, PinCode,ut);
                    if (x >= 1)
                        return 1;
                    else
                        return 0;
                }
                else
                {
                    return 0;
                }
            }

        }
        //**********************************************************************************************//

        //**************************   AUTHENTICATE CUSTOMER   *********************************//
        public int checkEmailAndPhoneNo(string Email_Id, string Contact_No)
        {

            int x = cfd.checkEmailAndPhoneNo(Email_Id, Contact_No);
            if (x >= 1)
                return 0;
            else
                return 1;
        }
        //**************************************************************************************//



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
    }
}
