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
    public partial class Customer_GuestDetails : Form
    {
        static int adults;
        static int children;

        public Customer_GuestDetails()
        {
            InitializeComponent();

        }

        private void Customer_GuestDetails_Load(object sender, EventArgs e)
        {
             adults =Convert.ToInt16( PassingValues.NumberOfAdults);
             children =Convert.ToInt16( PassingValues.NumberOfChildren);

          //  MessageBox.Show(PassingValues.NumberOfAdults);

            TextBox[] tb1 = new TextBox[adults * 2];
            TextBox[] tb2 = new TextBox[children * 2];
            
            int j = 0;

            tableLayoutAdults.RowCount = adults + 1;
            tableLayoutChildren.RowCount = children + 1;
            
            for (int i = 0; i < adults; i++)
            {

                tb1[j] = new TextBox();
                tb1[j].Text = "";
                tableLayoutAdults.Controls.Add(tb1[j], 0, i + 1);
                j++;
                tb1[j] = new TextBox();
                tb1[j].Text = "";
                tableLayoutAdults.Controls.Add(tb1[j], 1, i + 1);
                //tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

                j++;
            }

            j = 0;
            for (int i = 0; i < children; i++)
            {

                tb2[j] = new TextBox();
                tb2[j].Text = "";
                tableLayoutChildren.Controls.Add(tb2[j],0 , i+1);
                j++;
                tb2[j] = new TextBox();
                tb2[j].Text = "";
                tableLayoutChildren.Controls.Add(tb2[j], 1 , i+1);
                //tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

                j++;
            }


        }

        private void bOk_Click(object sender, EventArgs e)
        {
            int flag = 0;
            
            string[] AdultsInfo=new string[adults*2];
            string[] ChildrenInfo=new string[children*2];

           // Array Customer_Name, Customer_Ages;
            foreach (Control c in this.Controls)
                if (c is TableLayoutPanel)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        if (c2 is TextBox)
                        {
                            if (c2.Text == "")
                            {
                               // c2.BackColor = Color.Red;
                                flag = 1;
                            }
                         
                           // MessageBox.Show(c2.Text);
                        }
                    }
                }

            if(flag==1)
                MessageBox.Show("Please provide All the Details");
            else
            {
                int i;
                foreach (Control c in this.Controls)
                if (c is TableLayoutPanel)
                {
                   i=0;
                    if (c.Name == "tableLayoutAdults")
                        foreach (Control c2 in c.Controls)
                        { 
                            if (c2 is TextBox)
                            {
                                AdultsInfo[i]=c2.Text;
                                i++;
                              //  MessageBox.Show(c2.Text);
                            }
                        }

                    else
                    {
                        i = 0;
                        foreach (Control c2 in c.Controls)
                        {
                            if (c2 is TextBox)
                            {
                                // Customer_Names[i]=c2.Text;
                                ChildrenInfo[i] = c2.Text;
                                i++;
                               // MessageBox.Show(c2.Text);
                            }
                        }
                    }
                }

                Customer_Payment pay = new Customer_Payment(AdultsInfo, ChildrenInfo);
                MessageBox.Show(AdultsInfo.Length + " " + ChildrenInfo.Length);
                pay.MdiParent = this.MdiParent;
                pay.Show();

            }

           
        }
    }
}

