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
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressLoading.Value = progressLoading.Value + 2;
            if (progressLoading.Value > 90)
            {
                timer1.Enabled = false;
                this.Close();
                MessageBox.Show("Booking Successfull");
                CustomerFeedback cfeed = new CustomerFeedback();
                cfeed.MdiParent = this.MdiParent;
                cfeed.Show();
            }
        }
    }
}
