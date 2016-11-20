using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace HotelReservationSystem
{
    public partial class Home : Form
    {
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
                BusinessAccessClass bc = new BusinessAccessClass();
                //  MessageBox.Show("Valida");

                int x = bc.authenticateCustomer(txtUserId.Text, txtPhoneNumber.Text, txtPassword.Text);
                if (x == 1)
                    MessageBox.Show("Valid");
                else
                    MessageBox.Show("Invalid");
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            menustripCustomer.Hide();
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
            string s="0123456789";
           foreach(char c in txtPhoneNumber.Text)
            if (s.Contains(c))
            {
            }
            else
            {
                erpPhoneNumber.SetError(txtPhoneNumber,"Please Enter Valid PhoneNumber");
                txtPhoneNumber.Text = txtPhoneNumber.Text.Substring(0,txtPhoneNumber.Text.Length-1);
                txtPhoneNumber.Select(txtPhoneNumber.Text.Length, 0);
            }

        }

        private void msitemAddHotel_Click(object sender, EventArgs e)
        {
            Admin_AddHotel addhotel = new Admin_AddHotel();
            addhotel.MdiParent = this;
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

       
      


    }
}
