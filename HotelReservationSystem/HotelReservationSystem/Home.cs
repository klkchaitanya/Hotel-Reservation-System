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
    public partial class Home : Form
    {
        int x = 0;
        public Home()
        {
            InitializeComponent();
           
        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "" || txtPhoneNumber.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Fill all the required fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUserId.TextLength != 5)
            {
                MessageBox.Show("UserId should contain 5 characters", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPhoneNumber.TextLength != 10)
            {
                MessageBox.Show("Please Enter a valid 10 digit number", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CommonFunctionalityBLL cfb = new CommonFunctionalityBLL();
               
                    int x = cfb.authenticateCustomer(txtUserId.Text, txtPhoneNumber.Text, txtPassword.Text);
                    if (x == 1)
                    {

                       

                        panel1.Hide();
                        panel2.Hide();

                        CustomerBusinessLogicLayer cbl = new CustomerBusinessLogicLayer();
                        string []s=new string[2];
                        string ct;
                        s= cbl.getCustomerNameAndUserTypeByCustomerId(txtUserId.Text);
                        PassingValues.CustomerName = s[0];
                        ct = s[1];
                        if (ct == "A")
                        {
                            //MessageBox.Show("CustomerType:Admin");
                            menustripAdmin.Show();
                            WelcomePanel.Show();
                        }
                        else if(ct == "U")
                        {
                            //MessageBox.Show("CustomerType:User");
                            menustripCustomer.Show();
                            WelcomePanel.Show();
                        }
                        PassingValues.CustomerId = txtUserId.Text;
                        lblUserName.Text = PassingValues.CustomerName;
                    }
                    else
                        MessageBox.Show("Invalid");
                //MessageBox.Show(PassingValues.CustomerName);
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
          //  MessageBox.Show("Home Load");
            menustripAdmin.Hide();
          //  menustripCustomer.Hide();
            WelcomePanel.Hide();
            //panel1.Hide();
            //panel2.Hide();
            panel1.Show();
            panel2.Show();

            txtUserId.Text = "";
            txtPassword.Text = "";
            txtPhoneNumber.Text = "";

        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhoneNumber.Text.Equals(""))
                erpPhoneNumber.SetError(txtPhoneNumber, "Please Enter PhoneNumber");
            else
            {
                erpPhoneNumber.Dispose();
            }
        }




        private void txtUserId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserId.Text))
            {
                erpUserId.SetError(txtUserId, "Enter User Name");
            }
            else
            {
                erpUserId.Dispose();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text.Equals(""))
                erpPassword.SetError(txtPassword, "Please Enter Password");
            else
            {
                erpPassword.Dispose();
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhoneNumber.Text.Equals(""))
                erpPassword.SetError(txtPassword, "Please Enter Password");
            else
            {
                erpPassword.Dispose();
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string s = "0123456789";
            foreach (char c in txtPhoneNumber.Text)
                if (s.Contains(c))
                {
                }
                else
                {
                    erpPhoneNumber.SetError(txtPhoneNumber, "Please Enter Valid PhoneNumber");
                    txtPhoneNumber.Text = txtPhoneNumber.Text.Substring(0, txtPhoneNumber.Text.Length - 1);
                    txtPhoneNumber.Select(txtPhoneNumber.Text.Length, 0);
                }

        }

        private void msitemAddHotel_Click(object sender, EventArgs e)
        {
            Admin_AddHotel addhotel = new Admin_AddHotel();
            addhotel.MdiParent = this;
            addhotel.Width = this.Width;
            addhotel.Height = this.Height;
            panel1.Hide();
            panel2.Hide();
            addhotel.Show();
        }

        private void msitemEditHotel_Click(object sender, EventArgs e)
        {
            Admin_EditHotel edithotel = new Admin_EditHotel();
            edithotel.MdiParent = this;
            panel1.Hide();
            panel2.Hide();
            edithotel.Show();

        }

        private void msitemDeleteHotel_Click(object sender, EventArgs e)
        {
            Admin_DeleteHotel deletehotel = new Admin_DeleteHotel();
            deletehotel.MdiParent = this;
            panel1.Hide();
            panel2.Hide();
            deletehotel.Show();
        }

        private void sEARCHHOTELSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_SearchHotel search = new Customer_SearchHotel();
            search.MdiParent = this;
            //foreach (Control c in this.Controls)
            //    if (c is MenuStrip || c is Panel)
            //        c.Hide();
            search.Show();
        }

        private void btnSearchHotels_Click(object sender, EventArgs e)
        {
            //Customer_BookHotel book = new Customer_BookHotel();
            //book.MdiParent = this;

            Customer_SearchHotel search = new Customer_SearchHotel();
            search.Height = this.Height;
            search.Width = this.Width;
            search.MdiParent = this;
            panel1.Hide();
            panel2.Hide();
            search.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //foreach (PictureBox pb in this.groupBox1.Controls)
            //{
            //    pb.Left = pb.Left - 2;
            //    if (pb.Left < -120)
            //        pb.Left = 980;
               
            //}
        }


        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void msitemAddAdminAccount_Click(object sender, EventArgs e)
        {
            Registration r=new Registration();
            PassingValues.utype = 1;
            r.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

            this.OnLoad(e);
        }

        private void cANCELBOOKINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_BookingCancellation cbc = new Customer_BookingCancellation();
            cbc.MdiParent = this;
            cbc.Show();
        }


    }
}
