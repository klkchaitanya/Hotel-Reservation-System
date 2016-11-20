using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace HotelReservationSystem
{
    public partial class Registration : Form
    {

        BusinessAccessClass bac = new BusinessAccessClass();
        public Registration()
        {
            InitializeComponent();
            DDLCountry.Items.Add("Select Country");
            DataSet ds = bac.GetData("spGetCountry", null);
            DDLCountry.DisplayMember = "Country_Name";
            DDLCountry.ValueMember = "Country_Id";
            DDLCountry.DataSource = ds.Tables[0];
            
            

            DDLCity.Enabled = true;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            BusinessAccessClass bc = new BusinessAccessClass();            
             int x=bc.registerCustomer(txtCustomerName.Text,txtPassword.Text,txtConfirmPassword.Text,datepickerDOB.Text,txtEmail.Text,txtPhoneNumber.Text,DDLCountry.Text,DDLCity.Text,txtPinCode.Text);
             if (x == 1)
                 MessageBox.Show("Registration Failed");
             else
                 MessageBox.Show("Registration Success");
        }

        private void DDLCountry_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DDLCity.Enabled = true;
            string sp = "spGetCityByCountryId";
            SqlParameter parameter = new SqlParameter("@Country_Id", DDLCountry.SelectedValue);
            DataSet ds = bac.GetData(sp, parameter);
            DDLCity.DataSource = ds.Tables[0];
            DDLCity.DisplayMember = "City_Name";
            DDLCity.ValueMember = "City_Id";
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            datepickerDOB.MaxDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!txtConfirmPassword.Text.Equals(txtPassword.Text))
                
                erpConfirmPassword.SetError(txtConfirmPassword,"Passwords does not match");
        }

      
       
        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            string phone_format = "[7-8]{1}[0-9]{9}";
            if (txtPhoneNumber.Text == "")
            {
                erpPhoneNumber.SetError(txtPhoneNumber, "Please Enter Phone Number");
            }
            else if (!Regex.IsMatch(txtPhoneNumber.Text, phone_format))
            {
                erpPhoneNumber.SetError(txtPhoneNumber, "Invalid Phone Number");
            }
            else
            {
                erpPhoneNumber.Dispose();
              
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email_format = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
            if (txtEmail.Text == "")
            {
                erpEmail.SetError(txtEmail, "Please Enter Email");
            }
            else if (!Regex.IsMatch(txtEmail.Text, email_format))
            {
                erpEmail.SetError(txtEmail, "Invalid Email format");
            }
            else
            {
                erpEmail.Dispose();

            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text == "")
            {
                erpPassword.SetError(txtPassword,"Please Enter Password");
            }
            else if (txtPassword.Text.Contains(txtCustomerName.Text))
            {
                erpPassword.SetError(txtPassword, "Password should not contain Username");
            }
            else
            {
                erpPassword.Dispose();
            }
        }

        private void txtCustomerName_Validating(object sender, CancelEventArgs e)
        {
            int flag = 0;
            String s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char c in txtCustomerName.Text.ToUpper().ToCharArray())
            {
                if (!s.Contains(c))
                    flag = 1;
            }

            if (flag == 1)
                erpCustomeName.SetError(txtCustomerName,"Customer name shd contain only letters");
        }

        private void datepickerDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPinCode_TextChanged(object sender, EventArgs e)
        {
            string s = "0123456789";
            foreach (char c in txtPinCode.Text)
                if (s.Contains(c))
                {
                    erpPinCode.Dispose();
                }
                else
                {
                    erpPinCode.SetError(txtPinCode, "Please Enter Valid PinCode");
                    txtPinCode.Text = txtPinCode.Text.Substring(0, txtPinCode.Text.Length - 1);
                    txtPinCode.Select(txtPinCode.Text.Length, 0);
                }
        }

       

    }
}
