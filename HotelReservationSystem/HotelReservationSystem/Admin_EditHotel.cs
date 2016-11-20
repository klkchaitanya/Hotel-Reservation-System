using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PresentationLayer;
using System.Drawing.Imaging;
using PdfSharp.Pdf;
using PdfSharp.Drawing;


namespace PresentationLayer
{
    public partial class Admin_EditHotel : Form
    {
        public Admin_EditHotel()
        {
            InitializeComponent();
        }

        private void Admin_EditHotel_Load(object sender, EventArgs e)
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtHotelId.Text == "")
            {
                MessageBox.Show("Please Enter HotelId");
            }
            else
            {
                AdminBusinessAccessClass bac = new AdminBusinessAccessClass();
                DataSet ds = bac.getHotelDetailByHotelId(txtHotelId.Text);
                if (ds != null)
                {
                    txtHotelName.Text = ds.Tables[0].Rows[0]["Hotel_Name"].ToString();
                    lblCountryVal.Text = ds.Tables[0].Rows[0]["Country_Name"].ToString();
                    lblCityVal.Text = ds.Tables[0].Rows[0]["City_Name"].ToString();
                    txtHotelDesc.Text = ds.Tables[0].Rows[0]["Hotel_Description"].ToString();
                    txtNumAcRooms.Text = ds.Tables[0].Rows[0]["No_Of_Ac_Room"].ToString();
                    txtNumNonAcRooms.Text = ds.Tables[0].Rows[0]["No_Of_Non_Ac_Room"].ToString();
                    txtRateChildAc.Text = ds.Tables[0].Rows[0]["Rate_Child_Ac"].ToString();
                    txtRateChildNonAc.Text = ds.Tables[0].Rows[0]["Rate_Child_Non_Ac"].ToString();
                    txtRateAdultAc.Text = ds.Tables[0].Rows[0]["Rate_Adult_Ac"].ToString();
                    txtRateAdultNonAc.Text = ds.Tables[0].Rows[0]["Rate_Adult_Non_Ac"].ToString();
                    pictureBox1.ImageLocation ="C:\\ToolStripItemImageScaling\\"+ ds.Tables[0].Rows[0]["Hotel_Image"].ToString();
                    lblTotalRoomsVal.Text = (Convert.ToInt32(txtNumAcRooms.Text) + Convert.ToInt32(txtNumNonAcRooms.Text)).ToString();
                    lblHotelIdVal.Text = txtHotelId.Text;
                    txtRateAdultAc.Enabled = false;
                    txtRateAdultNonAc.Enabled = false;
                    txtRateChildAc.Enabled = false;
                    txtRateChildNonAc.Enabled = false;
                }
                else if (ds == null)
                {
                    MessageBox.Show("Please Enter Correct Hotel_Id");
                }
            }
        }

        private void rbtnAc_CheckedChanged(object sender, EventArgs e)
        {
            txtRateAdultAc.Enabled = true;
            txtRateChildAc.Enabled = true;
            txtRateAdultNonAc.Enabled = false;
            txtRateChildNonAc.Enabled = false;
        }

        private void rbtnNonAc_CheckedChanged(object sender, EventArgs e)
        {
            txtRateAdultNonAc.Enabled = true;
            txtRateChildNonAc.Enabled = true;
            txtRateAdultAc.Enabled = false;
            txtRateChildAc.Enabled = false;
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            if (txtHotelName.Text == "" || txtNumAcRooms.Text == "" || txtNumNonAcRooms.Text == "" || txtRateAdultAc.Text == "" || txtRateAdultNonAc.Text == "" || txtRateChildAc.Text == "" || txtRateChildNonAc.Text=="")
            {
                MessageBox.Show("Validation Failed");
            }
            else if (!erpHotelName.GetError(txtHotelName).Equals("") || !erpHotelDescription.GetError(txtHotelDesc).Equals("") || !erpNoAcRoom.GetError(txtNumAcRooms).Equals("")||!erpRateNonAcAdult.GetError(txtRateAdultNonAc).Equals("") || !erpRateAcAdult.GetError(txtRateAdultAc).Equals("") || !erpNoNonAcRoom.GetError(txtNumNonAcRooms).Equals("") || !erpRateNonAcAdult.GetError(txtRateChildNonAc).Equals("") || !erpRateAcChild.GetError(txtRateChildAc).Equals(""))
            {
                MessageBox.Show("Validation Failed");
            }
            else
            {
                AdminBusinessAccessClass bac = new AdminBusinessAccessClass();
                int i = bac.updateHotelDetail(txtHotelId.Text, txtHotelName.Text, txtHotelDesc.Text, Convert.ToInt32(txtNumAcRooms.Text), Convert.ToInt32(txtNumNonAcRooms.Text), Convert.ToInt32(txtRateAdultAc.Text), Convert.ToInt32(txtRateAdultNonAc.Text), Convert.ToInt32(txtRateChildAc.Text), Convert.ToInt32(txtRateChildNonAc.Text));
                if (i == 1)
                {
                    MessageBox.Show("Hotel Details Updated Successfully");
                }
                else
                    MessageBox.Show("Hotel Details Not Updated Successfully");
            }
        }

        private void txtHotelId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.KeyChar = char.ToUpper(e.KeyChar);
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
                if (rcode == 0)
                {
                    erpNoAcRoom.SetError(txtNumAcRooms, "Please enter rooms in range 1-300");
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

        private void txtRateAdultNonAc_Validating(object sender, CancelEventArgs e)
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
        ScreenCapture capScreen = new ScreenCapture();
        private void captureScreen()
        {
            try
            {
                // Call the CaptureAndSave method from the ScreenCapture class 
                // And create a temporary file in C:\Temp
                capScreen.CaptureAndSave
                (@"C:\Temp\Booking.jpeg", CaptureMode.Window, ImageFormat.Jpeg);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Call your captureScreen() function
            captureScreen();

            // Create new pdf document and page
            PdfDocument doc = new PdfDocument();
            PdfPage oPage = new PdfPage();

            // Add the page to the pdf document and add the captured image to it
            doc.Pages.Add(oPage);
            XGraphics xgr = XGraphics.FromPdfPage(oPage);
            XImage img = XImage.FromFile(@"C:\Temp\Booking.jpeg");
            xgr.DrawImage(img, 0, 0);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ("PDF File|*.pdf");
            DialogResult btnSave = saveFileDialog.ShowDialog();
            saveFileDialog.Title = "BookingDetails";
            //saveFileDialog.FileName = "BookingDetails.pdf";
            if (btnSave.Equals(DialogResult.OK))
            {
                doc.Save(saveFileDialog.FileName);
                doc.Close();
                MessageBox.Show("File Saved Successfully");
            }

            // I used the Dispose() function to be able to 
            // save the same form again, in case some values have changed.
            // When I didn't use the function, a GDI+ error occurred.
            img.Dispose();
        }
        
    }
}
