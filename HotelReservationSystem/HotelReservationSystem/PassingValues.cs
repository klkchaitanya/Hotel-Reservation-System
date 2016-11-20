using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationSystem
{
    class PassingValues
    {
        public static string s1, s2, s3, s4, s5,s6,s7,s8,s9,s10,s11,s12;

        public static string HotelId
        {
            get { return s1; }
            set { s1 = value; }
        }
        public static string HotelName
        {
            get { return s2; }
            set { s2 = value; }
        }
        public static string RoomType
        {
            get { return s3; }
            set { s3 = value; }
        }
        public static string FromDate
        {
            get { return s4; }
            set { s4 = value; }
        }
        public static string ToDate
        {
            get { return s5; }
            set { s5 = value; }
        }

        public static string RateAdult
        {
            get { return s6; }
            set { s6 = value; }
        }

        public static string RateChild
        {
            get { return s7; }
            set { s7 = value; }
        }

        public static string NumberOfNights
        {
            get { return s8; }
            set { s8 = value; }
        }

        public static string NumberOfAdults
        {
            get { return s9; }
            set { s9 = value; }
        }

        public static string NumberOfChildren
        {
            get { return s10; }
            set { s10 = value; }
        }
       
        public static string NumberOfRooms
        {
            get { return s11; }
            set { s11 = value; }
        }

        public static string TotalAmount
        {
            get { return s12; }
            set { s12 = value; }
        }
    }
}
