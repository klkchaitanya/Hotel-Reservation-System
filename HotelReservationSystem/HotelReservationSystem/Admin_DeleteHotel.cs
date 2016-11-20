using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PresentationLayer;
using System.Data.SqlClient;

namespace PresentationLayer
{
    public partial class Admin_DeleteHotel : Form
    {
        public Admin_DeleteHotel()
        {
            InitializeComponent();
            txtHotelId.Select();
        }

        private void Admin_DeleteHotel_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            var source = new AutoCompleteStringCollection();

            AdminBusinessAccessClass bac = new AdminBusinessAccessClass();
            DataSet ds = bac.getAllHotelId();
            if (ds != null)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    source.Add(ds.Tables[0].Rows[i][0].ToString());
                    // MessageBox.Show(ds.Tables[0].Rows[i][0].ToString());
                }

            }
            txtHotelId.AutoCompleteCustomSource = source;
            txtHotelId.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnSearchHotel_Click(object sender, EventArgs e)
        {
            AdminBusinessAccessClass bac = new AdminBusinessAccessClass();
            DataSet ds= bac.getHotelDetailByHotelId(txtHotelId.Text);
            if (ds != null)
            {
                    txtHotelName.Text = ds.Tables[0].Rows[0]["Hotel_Name"].ToString();
                    txtCountry.Text = ds.Tables[0].Rows[0]["Country_Name"].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0]["City_Name"].ToString();
                    txtHotelDesc.Text = ds.Tables[0].Rows[0]["Hotel_Description"].ToString();
                    txtNumAcRooms.Text = ds.Tables[0].Rows[0]["No_Of_Ac_Room"].ToString();
                    txtNumNonAcRooms.Text = ds.Tables[0].Rows[0]["No_Of_Non_Ac_Room"].ToString();
                    txtRateChildAc.Text = ds.Tables[0].Rows[0]["Rate_Child_Ac"].ToString();
                    txtRateChildNonAc.Text = ds.Tables[0].Rows[0]["Rate_Child_Non_Ac"].ToString();
                    txtRateAdultAc.Text = ds.Tables[0].Rows[0]["Rate_Adult_Ac"].ToString();
                    txtRateAdultNonAc.Text = ds.Tables[0].Rows[0]["Rate_Adult_Non_Ac"].ToString();
            }   
            else if (ds == null)
            {
                MessageBox.Show("Please Enter Correct Hotel_Id");   
            }
        }

        private void btnDeleteHotel_Click(object sender, EventArgs e)
        {
            if (txtHotelName != null && txtHotelId.Text!=null)
            {
                if (MessageBox.Show("Are You Sure You Want To Delete Hotel : "+txtHotelId.Text+"?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AdminBusinessAccessClass bac = new AdminBusinessAccessClass();
                    int i = bac.deleteHotel(txtHotelId.Text);
                    if (i > 0)
                    {
                        MessageBox.Show("Hotel Details Of Hotel : " + txtHotelId.Text + "Deleted Successfully");
                    }
                    else 
                    {
                        MessageBox.Show("Deletion Unsucessful. Try Later...");
                    }
                }
            }
            else
            {
                MessageBox.Show("First Select Hotel For Deletion");
            }
        }

        private void txtHotelId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
                e.KeyChar = char.ToUpper(e.KeyChar);
        }

    
    }
}
