using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Drawing.Imaging;

namespace PresentationLayer
{
    public partial class CustomerFeedback : Form
    {
        public CustomerFeedback()
        {
            InitializeComponent();
            lblCustomer.Text = PassingValues.CustomerName;
            lblHotel.Text = PassingValues.HotelName;
            lblCheckIn.Text = PassingValues.FromDate;
            lblCheckOut.Text = PassingValues.ToDate;
            lblRoomType.Text = PassingValues.RoomType;
            lblRooms.Text = PassingValues.NumberOfRooms;
            lblAdults.Text = PassingValues.NumberOfAdults;
            lblChildren.Text = PassingValues.NumberOfChildren;
            lblAmount.Text = PassingValues.TotalAmount;
        }

        private void CustomerFeedback_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void lblCheckIn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

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

        private void btnPrint_Click(object sender, EventArgs e)
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
