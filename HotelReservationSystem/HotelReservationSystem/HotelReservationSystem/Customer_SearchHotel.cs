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
    public partial class Customer_SearchHotel : Form
    {


        public Customer_SearchHotel()
        {
            InitializeComponent();

        }

       

        private void cboxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customer_SearchHotel_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            
          //  Home h = new Home();
           Customer_BookHotel book = new Customer_BookHotel();
           book.Width = this.Width;
           book.Height = this.Height;
           book.MdiParent = this.MdiParent;
            book.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
