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
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Reflection;

namespace PresentationLayer
{
    public partial class Registration : Form
    {
        AdminBusinessAccessClass bac = new AdminBusinessAccessClass();
        //int flag = 1;
        public Registration()
        {
            InitializeComponent();
            DDLCountry.Items.Add("Select Country");
            DataSet ds = bac.GetData("spGetCountry", null);
            DDLCountry.DisplayMember = "Country_Name";
            DDLCountry.ValueMember = "Country_Id";
            DDLCountry.DataSource = ds.Tables[0];

            DDLCity.Enabled = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "" || txtEmail.Text == "" || txtConfirmPassword.Text == "" || txtPassword.Text == "" || txtPinCode.Text == "" || txtPhoneNumber.Text == "" || DDLCity.Enabled==false || DDLCountry.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Validation Failed");
            }
            else if(!erpCustomeName.GetError(txtCustomerName).Equals("")||!erpPassword.GetError(txtPassword).Equals("")||!erpConfirmPassword.GetError(txtConfirmPassword).Equals("")
                ||!erpEmail.GetError(txtEmail).Equals("")||!erpPhoneNumber.GetError(txtPhoneNumber).Equals("")||!erpPinCode.GetError(txtPinCode).Equals(""))
            {
                MessageBox.Show("Validation Failed");
            }
            else
            {
                CommonFunctionalityBLL cfb = new CommonFunctionalityBLL();
                string ut = "";
                if (PassingValues.utype == 1)
                {
                    ut = "A";
                }
                else
                {
                    ut = "U";
                }
                int x = cfb.registerCustomer(txtCustomerName.Text, txtPassword.Text, datepickerDOB.Text, txtEmail.Text, txtPhoneNumber.Text, DDLCountry.SelectedValue.ToString(), DDLCity.SelectedValue.ToString(), txtPinCode.Text,ut);
                if (x == 1)
                {
                    MessageBox.Show("Registration Successful");
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Credentials");
                }
                PassingValues.utype = 0;
            }


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
            {
                erpConfirmPassword.SetError(txtConfirmPassword, "Passwords does not match");
            }
            else
            {
                erpConfirmPassword.Dispose();
            }
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            int rcode = Validation.checkNull(txtPhoneNumber.Text);
            if (rcode == 0)
            {
                erpPhoneNumber.SetError(txtPhoneNumber, "Please Enter Phone Number");
            }
            else
            {
                rcode = Validation.phoneNumber(txtPhoneNumber.Text);
                if (rcode == 0)
                {
                    erpPhoneNumber.SetError(txtPhoneNumber, "Invalid Phone Number");
                }
                else
                {
                    erpPhoneNumber.Dispose();
                }
            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            int rcode = Validation.checkNull(txtEmail.Text);
            if (rcode == 0)
            {
                erpEmail.SetError(txtEmail, "Please enter Email");
            }
            else
            {
                rcode = Validation.email(txtEmail.Text);
                if (rcode == 0)
                {
                    erpEmail.SetError(txtEmail, "Invalid EmailId");
                }
                else
                {
                    erpEmail.Dispose();
                }

            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            int rcode = Validation.checkNull(txtPassword.Text);
            if (rcode == 0)
            {
                erpPassword.SetError(txtPassword, "Please Enter Password");
            }
            else
            {
                rcode = Validation.password(txtPassword.Text, txtCustomerName.Text);
                if (rcode == 2)
                {
                    erpPassword.SetError(txtPassword, "Password should not contain Username");
                }
                else if (rcode == 0)
                {
                    erpPassword.SetError(txtPassword, "Password should contain alphanumeric characeters and one symbol out of \"!@$%&*_\"");
                }
                else if (rcode == 1)
                {
                    erpPassword.Dispose();
                }
            }
        }

        private void txtCustomerName_Validating(object sender, CancelEventArgs e)
        {
            int rcode = Validation.checkNull(txtCustomerName.Text);
            if (rcode == 0)
            {
                erpCustomeName.SetError(txtCustomerName, "Customer name should not be null");
            }
            else
            {
                rcode = Validation.customerName(txtCustomerName.Text);
                if (rcode == 1)
                {
                    erpCustomeName.SetError(txtCustomerName, "Customer name should contain only letters");
                }
                else if (rcode == 0)
                {
                    erpCustomeName.Dispose();
                }
            }
        }


        private void txtPinCode_TextChanged(object sender, EventArgs e)
        {
            int rcode = Validation.checkNull(txtPinCode.Text);
            if (rcode == 0)
            {
                erpPinCode.SetError(txtPinCode, "Please Enter Pin Code");
            }
            else
            {
                rcode = Validation.pinCode(txtPinCode.Text);
                if (rcode == 0)
                {
                    erpPinCode.SetError(txtPinCode, "Please Enter Valid PinCode");
                    txtPinCode.Text = txtPinCode.Text.Substring(0, txtPinCode.Text.Length - 1);
                    txtPinCode.Select(txtPinCode.Text.Length, 0);
                }
                else
                {
                    erpPinCode.Dispose();
                }
            }
        }

        private void txtPinCode_Validating(object sender, CancelEventArgs e)
        {
            if (txtPinCode.Text == null)
            {
                erpPinCode.SetError(txtPinCode, "Please Enter Pin Code");
            }
            else
            {
                erpPinCode.Dispose();
            }
        }
    }
}
