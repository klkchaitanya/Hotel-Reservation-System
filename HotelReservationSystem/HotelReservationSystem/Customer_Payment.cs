using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PresentationLayer;


namespace PresentationLayer
{
    public partial class Customer_Payment : Form
    {
        CustomerBusinessLogicLayer cbl = new CustomerBusinessLogicLayer();
        string[] adults, children;

        public Customer_Payment()
        {
            InitializeComponent();

            lblCustomer.Text = PassingValues.CustomerName;
            lblHotel.Text = PassingValues.HotelName;
            lblRoomType.Text = PassingValues.RoomType;
            lblAdults.Text = PassingValues.NumberOfAdults;
            lblChildren.Text = PassingValues.NumberOfChildren;
            lblCheckIn.Text = PassingValues.FromDate;
            lblCheckOut.Text = PassingValues.ToDate;
            lblRooms.Text = PassingValues.NumberOfRooms;
            lblAmount.Text = PassingValues.TotalAmount;
            radioButton1.Checked = false;
        }

        public Customer_Payment(string[] adults,string[] children)
        {
            InitializeComponent();

            lblCustomer.Text = PassingValues.CustomerName;
            lblHotel.Text = PassingValues.HotelName;
            lblRoomType.Text = PassingValues.RoomType;
            lblAdults.Text = PassingValues.NumberOfAdults;
            lblChildren.Text = PassingValues.NumberOfChildren;
            lblCheckIn.Text = PassingValues.FromDate;
            lblCheckOut.Text = PassingValues.ToDate;
            lblRooms.Text = PassingValues.NumberOfRooms;
            lblAmount.Text = PassingValues.TotalAmount;
            radioButton1.Checked = false;

            this.adults = adults;
            this.children = children;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Payment_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int x=cbl.CustomerPayAndBook(adults,children,txtCardNumber.Text,txtName.Text,(cboxMonth.SelectedItem.ToString()+"/"+cboxYear.SelectedItem.ToString()),txtCvv.Text);
            if (x == 1)
            {
                LoadingPage lp = new LoadingPage();
                lp.Show();
              //  MessageBox.Show("Booking Successfull");
            }
            else
                MessageBox.Show("Error");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==false)
            {
                foreach (Control c in this.Controls)
                    if (c is TextBox)
                        c.Enabled = false;
            }
            else
            {
                foreach (Control c in this.Controls)
                    if (c is TextBox)
                        c.Enabled = true;
            }

        }

        
    }
}
