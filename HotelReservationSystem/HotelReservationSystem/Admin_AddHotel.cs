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
using System.IO;
namespace PresentationLayer
{
    public partial class Admin_AddHotel : Form
    {
        AdminBusinessAccessClass bac = new AdminBusinessAccessClass();
        string iName = "";
        public Admin_AddHotel()
        {
            InitializeComponent();
            cboxCountry.Items.Add("Select Country");
            DataSet ds = bac.GetData("spGetCountry", null);
            cboxCountry.DisplayMember = "Country_Name";
            cboxCountry.ValueMember = "Country_Id";
            cboxCountry.DataSource = ds.Tables[0];

            cboxCity.Enabled = false;
        }

  

        private void Admin_AddHotel_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
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
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            if (txtHotelName.Text == "" || txtNumAcRooms.Text == "" || txtNumNonAcRooms.Text == "" || txtRateAdultAc.Text == "" || txtRateAdultNonAc.Text == "" || txtRateChildAc.Text == "" || txtRateChildNonAc.Text==""|| cboxCity.Enabled==false|| txtHotelDesc.Text=="")
            {
                MessageBox.Show("Validation Failed");
            }
            else if (!erpHotelName.GetError(txtHotelName).Equals("") || !erpHotelDescription.GetError(txtHotelDesc).Equals("") || !erpNoAcRoom.GetError(txtNumAcRooms).Equals("")|| !erpRateNonAcAdult.GetError(txtRateAdultNonAc).Equals("") || !erpRateAcAdult.GetError(txtRateAdultAc).Equals("") || !erpNoNonAcRoom.GetError(txtNumNonAcRooms).Equals("") ||!erpRateAcChild.GetError(txtRateChildAc).Equals("")||!erpRateNonAcChild.GetError(txtRateChildNonAc).Equals(""))
            {
                MessageBox.Show("Validation Failed");
            }
            else
            {
                int i = bac.addHotel(txtHotelName.Text, cboxCountry.SelectedValue.ToString(), cboxCity.SelectedValue.ToString(), txtHotelDesc.Text, Convert.ToInt32(txtNumAcRooms.Text), Convert.ToInt32(txtNumNonAcRooms.Text), Convert.ToInt32(txtRateAdultAc.Text), Convert.ToInt32(txtRateAdultNonAc.Text), Convert.ToInt32(txtRateChildAc.Text), Convert.ToInt32(txtRateChildNonAc.Text), iName);
                if (i == 1)
                {
                    MessageBox.Show("Hotel Added Successfully");

                }
                else
                    MessageBox.Show("Hotel Not Added Successfully");
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            //string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\";
            string appPath = @"C:\Images\";
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    iName = opFile.SafeFileName;
                    string filepath = opFile.FileName;
                    //if (File.Exists(@"C:\Users\admin\Documents\Visual Studio 2010\Projects\HotelReservationSystem\HotelReservationSystem\HotelReservationSystem\bin\Debug\Images\" + iName))
                    if (File.Exists(@"C:\Images\" + iName))
                    {
                        MessageBox.Show("The file exists.");
                        iName = "";
                    }
                    else
                    {
                        File.Copy(filepath, appPath + iName);
                        pictureBox1.Image = new Bitmap(opFile.OpenFile());
                        MessageBox.Show("Image Saved successfully");
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void txtHotelName_Validating(object sender, CancelEventArgs e)
        {
            int rcode = Validation.checkNull(txtHotelName.Text);
            if (rcode == 0)
            {
                erpHotelName.SetError(txtHotelName, "Please Enter Hotel Name");
            }
            else
            {
                rcode = Validation.hotelName(txtHotelName.Text);
                if (rcode == 0)
                {
                    erpHotelName.SetError(txtHotelName, "Invalid Hotel Name");
                }
                else
                {
                    erpHotelName.Dispose();
                }
            }
        }

        private void txtHotelDesc_Validating(object sender, CancelEventArgs e)
        {
            int rcode = Validation.checkNull(txtHotelDesc.Text);
            if (rcode == 0)
            {
                erpHotelDescription.SetError(txtHotelDesc, "Please Enter Hotel Description");
            }
            else
            {
                erpHotelDescription.Dispose();
            }
        }

        private void txtNumAcRooms_Validating(object sender, CancelEventArgs e)
        {
            int rcode = Validation.checkNull(txtNumAcRooms.Text);
            if (rcode == 0)
            {
                erpNoAcRoom.SetError(txtNumAcRooms, "Please Enter Number Of Rooms");
            }
            else
            {
                int n = Convert.ToInt32(txtNumAcRooms.Text);
                rcode = Validation.noOfRooms(n);
                if(rcode==0)
                {
                    erpNoAcRoom.SetError(txtNumAcRooms,"Please enter rooms in range 1-300");
                }
                else
                {
                    erpNoAcRoom.Dispose();
                }
            }
        }

        private void txtNumNonAcRooms_Validating(object sender, CancelEventArgs e)
        {
            int rcode = Validation.checkNull(txtNumNonAcRooms.Text);
            if (rcode == 0)
            {
                erpNoNonAcRoom.SetError(txtNumNonAcRooms, "Please Enter Number Of Rooms");
            }
            else
            {
                int n = Convert.ToInt32(txtNumNonAcRooms.Text);
                rcode = Validation.noOfRooms(n);
                if (rcode == 0)
                {
                    erpNoNonAcRoom.SetError(txtNumNonAcRooms, "Please enter rooms in range 1-300");
                }
                else
                {
                    erpNoNonAcRoom.Dispose();
                }
            }
        }

        private void txtRateAdultAc_Validating(object sender, CancelEventArgs e)
        {
            int rcode = Validation.checkNull(txtRateAdultAc.Text);
            if (rcode == 0)
            {
                erpRateAcAdult.SetError(txtRateAdultAc, "Please Enter Rate of Ac Room For Adult");
            }
            else
            {
                int n = Convert.ToInt32(txtRateAdultAc.Text);
                rcode = Validation.rateAdultAc(n);
                if (rcode == 0)
                {
                    erpRateAcAdult.SetError(txtRateAdultAc, "Please Enter Rate In Range (2501-4000)");
                }
                else
                {
                    erpRateAcAdult.Dispose();
                }
            }
        }

        private void txtRateAdultNonAc_Validated(object sender, EventArgs e)
        {
            int rcode = Validation.checkNull(txtRateAdultNonAc.Text);
            if (rcode == 0)
            {
                erpRateNonAcAdult.SetError(txtRateAdultNonAc, "Please Enter Rate Of Non Ac Room For Adult");
            }
            else
            {
                int n = Convert.ToInt32(txtRateAdultNonAc.Text);
                rcode = Validation.rateAdultNonAc(n);
                if (rcode == 0)
                {
                    erpRateNonAcAdult.SetError(txtRateAdultNonAc, "Please Enter Rate In Range (2000-2500)");
                }
                else
                {
                    erpRateNonAcAdult.Dispose();
                }
            }
        }

        private void txtRateChildAc_Validating(object sender, CancelEventArgs e)
        {
            int rcode = Validation.checkNull(txtRateChildAc.Text);
            if (rcode == 0)
            {
                erpRateAcChild.SetError(txtRateChildAc, "Please Enter Rate Of Ac Room For Child");
            }
            else
            {
                int n = Convert.ToInt32(txtRateChildAc.Text);
                rcode = Validation.rateChildAc(n);
                if (rcode == 0)
                {
                    erpRateAcChild.SetError(txtRateChildAc, "Please Enter Rate In Range (2000-3000)");
                }
                else
                {
                    erpRateAcChild.Dispose();
                }
            }
        }

        private void txtRateChildNonAc_Validating(object sender, CancelEventArgs e)
        {
            int rcode = Validation.checkNull(txtRateChildNonAc.Text);
            if (rcode == 0)
            {
                erpRateNonAcChild.SetError(txtRateChildNonAc, "Please Enter Rate Of Ac Room For Child");
            }
            else
            {
                int n = Convert.ToInt32(txtRateChildNonAc.Text);
                rcode = Validation.rateChildNonAc(n);
                if (rcode == 0)
                {
                    erpRateNonAcChild.SetError(txtRateChildNonAc, "Please Enter Rate In Range (1000-2000)");
                }
                else
                {
                    erpRateNonAcChild.Dispose();
                }
            }
        }
    }
}
