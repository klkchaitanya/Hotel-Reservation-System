using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PresentationLayer;

namespace PresentationLayer
{
    public partial class Customer_SearchHotel : Form
    {

        AdminBusinessAccessClass bac = new AdminBusinessAccessClass();
        CustomerBusinessLogicLayer cbl = new CustomerBusinessLogicLayer();
        DataSet dsHotelSearch;
        DataGridViewCheckBoxColumn dgCheckBox;
        string Hotel_Id,Rate_Adult_Ac,Rate_Child_Ac,Rate_Adult_Non_Ac,Rate_Child_Non_Ac;

        public Customer_SearchHotel()
        {
            InitializeComponent();

            dgCheckBox = new DataGridViewCheckBoxColumn();
            dgCheckBox.HeaderText = "Select Hotel";
            dataGridView1.Columns.Add(dgCheckBox);

            cboxCountry.Items.Add("Select Country");
            DataSet ds = bac.GetData("spGetCountry", null);
            cboxCountry.DisplayMember = "Country_Name";
            cboxCountry.ValueMember = "Country_Id";
            cboxCountry.DataSource = ds.Tables[0];

            cboxCity.Enabled = false;
            datepickerFromDate.Enabled = false;
            datepickerToDate.Enabled = false;
            cboxRoomType.SelectedIndex = 0;

        }

       

        private void cboxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sp = "spGetHotelDetailsByCountryAndCity";
            dsHotelSearch = cbl.GetHotels(sp,cboxCountry.SelectedValue.ToString(),cboxCity.SelectedValue.ToString());
            dataGridView1.DataSource = dsHotelSearch.Tables[0];
            //if (cboxRoomType.SelectedIndex == 0)
            //{
            //    DataView dv = new DataView(dsHotelSearch.Tables[0], "Available_Ac_Rooms>0 and Date>='" + datepickerFromDate.Value.ToShortDateString() + "' AND Date<='" + datepickerToDate.Value.ToShortDateString() + "'", "", DataViewRowState.CurrentRows);
            //    dataGridView1.DataSource = dv;
            //    txtHotelName.Text = "";
            //}

            //else
            //{
            //    DataView dv = new DataView(dsHotelSearch.Tables[0], "Available_Non_Ac_Rooms>0 and Date>='" + datepickerFromDate.Value.ToShortDateString() + "' AND Date<='" + datepickerToDate.Value.ToShortDateString() + "'", "", DataViewRowState.CurrentRows);
            //    dataGridView1.DataSource = dv;
            //    txtHotelName.Text = "";
            //}

            datepickerFromDate.Enabled = true;
          

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {

                int rowIndex = e.RowIndex;
                var dataGrid = (DataGridView)sender;

                if (dataGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
                {

                    

                    foreach(DataGridViewRow dr in dataGridView1.Rows)
                    {
                        if (rowIndex != dr.Index)
                            dataGridView1.Rows[dr.Index].Cells[e.ColumnIndex].Value = false;
                    }

                    //dataGridView1.Columns[e.ColumnIndex].ReadOnly = false;
                    dataGridView1.Rows[rowIndex].Cells[e.ColumnIndex].Value = true;

                     DataGridViewRow dgr  = dataGridView1.Rows[e.RowIndex];
                     Hotel_Id = dgr.Cells["Hotel_Id"].Value.ToString();
                    txtHotelName.Text = dgr.Cells["Hotel_Name"].Value.ToString();
                    DataGridViewRow dgr2 = dataGridView1.Rows[e.RowIndex];
                    Rate_Adult_Ac = dgr2.Cells["Rate_Adult_Ac"].Value.ToString();   
                    Rate_Child_Ac = dgr2.Cells["Rate_Child_Ac"].Value.ToString();
                    Rate_Adult_Non_Ac = dgr2.Cells["Rate_Adult_Non_Ac"].Value.ToString();
                    Rate_Child_Non_Ac = dgr2.Cells["Rate_Child_Non_Ac"].Value.ToString();
                                  

                }



                
              //txtHotelName.Text = dgr.Cells["Hotel_Name"].Value.ToString();
              //DataGridViewRow dgr2 = this.dataGridView1.Rows[e.RowIndex];
             
             //  MessageBox.Show(Rate_Child_Non_Ac + " " + Rate_Adult_Non_Ac);
            }
        }

        private void Customer_SearchHotel_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            datepickerFromDate.MinDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            datepickerToDate.MinDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtHotelName.Text == "")
            {
                MessageBox.Show("Please Select a Hotel","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else
            {

                this.Hide();

                //  Home h = new Home();
                //  Customer_BookHotel book = new Customer_BookHotel(Hotel_Id,txtHotelName.Text,cboxRoomType.SelectedValue.ToString(),datepickerFromDate.Value.ToShortDateString(),datepickerToDate.Value.ToShortDateString());

                PassingValues.HotelId = Hotel_Id;
                PassingValues.HotelName = txtHotelName.Text.Trim();
                PassingValues.RoomType = cboxRoomType.SelectedItem.ToString();
                PassingValues.FromDate = datepickerFromDate.Text.ToString();
                PassingValues.ToDate = datepickerToDate.Text.ToString();

                if (cboxRoomType.SelectedItem.ToString().Equals("AC"))
                {
                    PassingValues.RateAdult = Rate_Adult_Ac;
                    PassingValues.RateChild = Rate_Child_Ac;
                }
                else
                {
                    PassingValues.RateAdult = Rate_Adult_Non_Ac;
                    PassingValues.RateChild = Rate_Child_Non_Ac;
                }

                // MessageBox.Show(Hotel_Id);
                Customer_BookHotel book = new Customer_BookHotel();

                book.Width = this.Width;
                book.Height = this.Height;
                book.MdiParent = this.MdiParent;
                book.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cboxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxCity.Enabled = true;
            string sp = "spGetCityByCountryId";
            SqlParameter parameter = new SqlParameter("@Country_Id", cboxCountry.SelectedValue);
            DataSet ds = bac.GetData(sp, parameter);
            cboxCity.DataSource = ds.Tables[0];
            cboxCity.DisplayMember = "City_Name";
            cboxCity.ValueMember = "City_Id";
            txtHotelName.Text = "";

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            datepickerToDate.Enabled = true;
            string From_Date, To_Date;
            From_Date = datepickerFromDate.Text;
            To_Date = datepickerToDate.Text;

            string sp = "spHotelSearch";
            dsHotelSearch = cbl.hotelSearch(From_Date, To_Date,cboxCountry.SelectedValue.ToString(),cboxCity.SelectedValue.ToString()); 
            dataGridView1.DataSource = dsHotelSearch.Tables[0];
            
        }

        private void datepickerToDate_ValueChanged(object sender, EventArgs e)
        {
            //if (cboxRoomType.SelectedIndex == 0)
            //{
            //    DataView dv = new DataView(dsHotelSearch.Tables[0], "Available_Ac_Rooms>0 and Date>='" + datepickerFromDate.Value.ToShortDateString() + "' AND Date<='" + datepickerToDate.Value.ToShortDateString() + "'", "", DataViewRowState.CurrentRows);
            //    dataGridView1.DataSource = dv;
            //}
            //else
            //{
            //    DataView dv = new DataView(dsHotelSearch.Tables[0], "Available_Non_Ac_Rooms>0 and Date>='" + datepickerFromDate.Value.ToShortDateString() + "' AND Date<='" + datepickerToDate.Value.ToShortDateString() + "'", "", DataViewRowState.CurrentRows);
            //    dataGridView1.DataSource = dv;
            //}
            //txtHotelName.Text = "";
        }

        private void txtHotelName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dsHotelSearch.Tables[0], "Hotel_Name like '"+txtHotelName.Text+"%'", "", DataViewRowState.CurrentRows);
            dataGridView1.DataSource = dv;
        }

        private void cboxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboxRoomType.SelectedIndex == 0)
            //{
            //    DataView dv = new DataView(dsHotelSearch.Tables[0], "Available_Ac_Rooms>0 and Date>='" + datepickerFromDate.Value.ToShortDateString() + "' AND Date<='" + datepickerToDate.Value.ToShortDateString() + "'", "", DataViewRowState.CurrentRows);
            //    dataGridView1.DataSource = dv;
            //}
            //else
            //{
            //    DataView dv = new DataView(dsHotelSearch.Tables[0], "Available_Non_Ac_Rooms>0 and Date>='" + datepickerFromDate.Value.ToShortDateString() + "' AND Date<='" + datepickerToDate.Value.ToShortDateString() + "'", "", DataViewRowState.CurrentRows);
            //    dataGridView1.DataSource = dv;
            //}
            //txtHotelName.Text = "";

        }
    }
}
