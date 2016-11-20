using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class BusinessAccessClass
    {
        DataAccessClass da=new DataAccessClass();
        public int authenticateCustomer(string C_Id,string P_No,string Pass)
        {
            
            int x=da.authenticateCustomer(C_Id, P_No, Pass);
            if (x == 1)
                return 1;
            else
                return 0;
        }

        public DataSet GetData(string sp, SqlParameter parameter)
        {
            DataAccessClass da = new DataAccessClass();
            DataSet ds = da.GetData(sp, parameter);
            return ds;
        }
        public int registerCustomer(string CustomerName,string Password,string ConfirmPassword,string DOB,string Email,string PhoneNumber,string Country,string City,string PinCode)
        {


            string AlphaNumeric = GetVoucherNumber().ToString();
            String CustomerId = String.Concat(CustomerName.Substring(0, 1).ToUpper(), AlphaNumeric);
           // return CustomerId;
            
            
          int x = da.registerCustomer(CustomerId,CustomerName,Password,ConfirmPassword,DOB,Email,PhoneNumber,Country,City,PinCode);



            if (x == 1)
                return 1;
            else
                return 0;
        }

        private static Random random = new Random();

        public static string GetVoucherNumber()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var chars1 = "0123456789";
            var chars2 = "!@#$&*_?";
           
            var result = new string(
                Enumerable.Repeat(chars1,2)
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
           
            return result2+result+result1;
        }
    
    }
}
