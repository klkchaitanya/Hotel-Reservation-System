using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class Customer_BookHotel : Form
    {
        public Customer_BookHotel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}
