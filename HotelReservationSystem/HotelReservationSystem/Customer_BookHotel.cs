using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Customer_BookHotel : Form
    {
        //string HotelId, HotelName, RoomType, ArrivalDate, DepartureDate;
        int AdultCost = 0, ChildCost = 0;//TotalCost=0;
        public Customer_BookHotel()
        {
            InitializeComponent();

            
           
           txtHotelId.Text = PassingValues.HotelId;
            txtHotelName.Text = PassingValues.HotelName;
            if( PassingValues.RoomType.Equals("AC"))
                cboxRoomType.SelectedIndex=0;
            else
                cboxRoomType.SelectedIndex=1;
            datepickerArrival.Value = Convert.ToDateTime( PassingValues.FromDate);
            datepickerDeparture.Value =Convert.ToDateTime( PassingValues.ToDate);
            lblRateAdult.Text = PassingValues.RateAdult;
            lblRateChild.Text = PassingValues.RateChild;
            lblTotalCost.Text = PassingValues.RateAdult;

            foreach (Control c in this.Controls)
            {
                if (c.Name.Equals("txtHotelId") || c.Name.Equals("txtHotelName") || c.Name.Equals("cboxRoomType") || c.Name.Equals("datepickerArrival") || c.Name.Equals("datepickerDeparture")||c.Name.Equals("txtNumberOfNights"))
                    c.Enabled = false;
            }

            txtNumberOfNights.Text =Convert.ToString( (datepickerDeparture.Value - datepickerArrival.Value).TotalDays);

        }

        public Customer_BookHotel(string s)
        {
            InitializeComponent();

            if (s.Equals("from cancellation"))
            {


                txtHotelId.Text = PassingValues.HotelId;
                txtHotelName.Text = PassingValues.HotelName;
                if (PassingValues.RoomType.Equals("AC"))
                    cboxRoomType.SelectedIndex = 0;
                else
                    cboxRoomType.SelectedIndex = 1;
                datepickerArrival.Value = Convert.ToDateTime(PassingValues.FromDate);
                datepickerDeparture.Value = Convert.ToDateTime(PassingValues.ToDate);
                lblRateAdult.Text = PassingValues.RateAdult;
                lblRateChild.Text = PassingValues.RateChild;
                lblTotalCost.Text = (Convert.ToInt16(PassingValues.RateAdult) * (Convert.ToInt16(txtNumberOfAdults.Text))).ToString();

            foreach (Control c in this.Controls)
            {
                if (c.Name.Equals("txtHotelId") || c.Name.Equals("txtHotelName") || c.Name.Equals("cboxRoomType") || c.Name.Equals("datepickerArrival") || c.Name.Equals("datepickerDeparture")||c.Name.Equals("txtNumberOfNights"))
                    c.Enabled = false;
            }

            txtNumberOfNights.Text =Convert.ToString( (datepickerDeparture.Value - datepickerArrival.Value).TotalDays);
            txtNumberOfAdults.Text = PassingValues.NumberOfAdults;
            txtNumberOfChildren.Text = PassingValues.NumberOfChildren;
            txtNumberOfRooms.Text = PassingValues.NumberOfRooms;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PassingValues.NumberOfNights = txtNumberOfNights.Text;
            PassingValues.NumberOfAdults = txtNumberOfAdults.Text;
            PassingValues.NumberOfChildren = txtNumberOfChildren.Text;
            PassingValues.NumberOfRooms = txtNumberOfRooms.Text;
            PassingValues.TotalAmount = lblTotalCost.Text;
            
            
            
            Customer_Payment payment = new Customer_Payment();
            payment.Height = this.Height;
            payment.Width = this.Width;
            payment.MdiParent = this.MdiParent;
            this.Hide();
            payment.Show();
        }

        private void Customer_BookHotel_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        
        }

        private void cboxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumberOfAdults_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberOfAdults.Text != "" && txtNumberOfChildren.Text != "" && txtNumberOfRooms.Text != "")
            {
                foreach(char c in txtNumberOfAdults.Text.ToCharArray())
                 if(!"0123456789".Contains(c))
                 {
                   txtNumberOfAdults.Text=txtNumberOfAdults.Text.Substring(0,txtNumberOfAdults.TextLength-1);
                   txtNumberOfAdults.Select(0,txtNumberOfAdults.TextLength);
                 }

                
                AdultCost = Convert.ToInt16(txtNumberOfAdults.Text) * Convert.ToInt16(PassingValues.RateAdult);
                ChildCost = Convert.ToInt16(txtNumberOfChildren.Text) * Convert.ToInt16(PassingValues.RateChild);
                lblTotalCost.Text = Convert.ToString((AdultCost + ChildCost) * Convert.ToInt16(txtNumberOfRooms.Text));
            }
        }

        private void txtNumberOfChildren_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberOfAdults.Text != "" && txtNumberOfChildren.Text != "" && txtNumberOfRooms.Text != "")
            {
                foreach (char c in txtNumberOfChildren.Text.ToCharArray())
                    if (!"0123456789".Contains(c))
                    {
                        txtNumberOfChildren.Text = txtNumberOfChildren.Text.Substring(0, txtNumberOfChildren.TextLength - 1);
                        txtNumberOfChildren.Select(0, txtNumberOfChildren.TextLength);
                    }

                AdultCost = Convert.ToInt16(txtNumberOfAdults.Text) * Convert.ToInt16(PassingValues.RateAdult);
                ChildCost = Convert.ToInt16(txtNumberOfChildren.Text) * Convert.ToInt16(PassingValues.RateChild);
                lblTotalCost.Text = Convert.ToString((AdultCost + ChildCost) * Convert.ToInt16(txtNumberOfRooms.Text));
            }
        }

        private void txtNumberOfRooms_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberOfAdults.Text != "" && txtNumberOfChildren.Text != "" && txtNumberOfRooms.Text != "")
            {
                foreach (char c in txtNumberOfRooms.Text.ToCharArray())
                    if (!"0123456789".Contains(c))
                    {
                        txtNumberOfRooms.Text = txtNumberOfRooms.Text.Substring(0, txtNumberOfRooms.TextLength - 1);
                        txtNumberOfRooms.Select(0, txtNumberOfRooms.TextLength);
                    }
                AdultCost = Convert.ToInt16(txtNumberOfAdults.Text) * Convert.ToInt16(PassingValues.RateAdult);
                ChildCost = Convert.ToInt16(txtNumberOfChildren.Text) * Convert.ToInt16(PassingValues.RateChild);
                lblTotalCost.Text = Convert.ToString((AdultCost + ChildCost) * Convert.ToInt16(txtNumberOfRooms.Text));
            }

        }

        private void btnContinueToGuestDetails_Click(object sender, EventArgs e)
        {
            PassingValues.NumberOfNights = txtNumberOfNights.Text;
            PassingValues.NumberOfAdults = txtNumberOfAdults.Text;
            PassingValues.NumberOfChildren = txtNumberOfChildren.Text;
            PassingValues.NumberOfRooms = txtNumberOfRooms.Text;
            PassingValues.TotalAmount = lblTotalCost.Text;

            Customer_GuestDetails cg = new Customer_GuestDetails();
            cg.MdiParent = this.MdiParent;
            cg.Show();
        }

        
    }
}
