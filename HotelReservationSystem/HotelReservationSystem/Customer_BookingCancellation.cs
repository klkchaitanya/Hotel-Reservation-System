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
    public partial class Customer_BookingCancellation : Form
    {
        CustomerBusinessLogicLayer cbl = new CustomerBusinessLogicLayer();
        int bookingId;
        TextBox[] tb1, tb2;
        DataSet ds;
        int adult_rows,children_rows;   
        

        public Customer_BookingCancellation()
        {
            InitializeComponent();
        }

        private void Customer_BookingCancellation_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            DataTable dt=cbl.GetBookingDetails(PassingValues.CustomerId).Tables[0];
            if (dt.Rows.Count == 0)
            {
                label1.Text = "NO BOOKINGS WERE MADE WITH THIS USER ID";
                dataGridView1.Hide();
                Button bOk = new Button();
                bOk.Text = "OK";
                this.Controls.Add(bOk);

            }
            else
            {
                label1.Text = "YOUR BOOKING DETAILS";

                DataGridViewButtonColumn dgcLink = new DataGridViewButtonColumn();
                dgcLink.HeaderText = "SELECT";
                dgcLink.Text = "Change";

                dataGridView1.DataSource = dt;
                dataGridView1.Columns.Add(dgcLink);
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgRow;
             var dataGrid = (DataGridView)sender;

             if (dataGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
             {
                 dgRow=dataGrid.Rows[e.RowIndex];
                 label8.Text = dgRow.Cells["ADULTS"].Value.ToString();
                 label9.Text = dgRow.Cells["CHILDREN"].Value.ToString();
                 bookingId = Convert.ToInt16( dgRow.Cells["BOOKING_ID"].Value);
                 int adults=Convert.ToInt16(label8.Text);
                 int Children = Convert.ToInt16(label9.Text);
                 ds = new DataSet();
                  ds=FillColumns(bookingId);
                  GenerateColumns(adults, Children);
                  adult_rows = tableLayoutAdults.RowCount;
                  children_rows = tableLayoutChildren.RowCount;

                 //MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());

                 //for(int i=0;i<((ds.Tables[0].Rows.Count*2)-2);i=i+2)
                 //{
                 //    //tb1[i]=new TextBox();
                 //   // tb2[i] = new TextBox();
                 //   // tableLayoutAdults.
                 //     tb1[i].Text= ds.Tables[0].Rows[i][0].ToString();
                 //    tb1[i+1].Text = ds.Tables[0].Rows[i][1].ToString();
                 //}

             }
        }

        public void GenerateColumns(int adults,int children)
        {
            
            TextBox[] tb1 = new TextBox[adults * 2];
            TextBox[] tb2 = new TextBox[children * 2];
            LinkLabel[] ll1=new LinkLabel[adults*2];
            LinkLabel[] ll2=new LinkLabel[children*2];
            
            int j = 0;
            int k = 0;
            tableLayoutAdults.RowCount = adults + 1;
            tableLayoutChildren.RowCount = children + 1;
            
            for (int i = 0; i < adults; i++)
            {

                tb1[j] = new TextBox();
                tb1[j].Text = ds.Tables[0].Rows[k][0].ToString();
                tb1[j].Enabled = false;
                tableLayoutAdults.Controls.Add(tb1[j], 0, i + 1);
                j++;
                tb1[j] = new TextBox();
                tb1[j].Text = ds.Tables[0].Rows[k][1].ToString() ;
                tb1[j].Enabled = false;
                tableLayoutAdults.Controls.Add(tb1[j], 1, i + 1);
                j--;
                ll1[j] = new LinkLabel();
                ll1[j].Text = "EDIT";
                ll1[j].Click += (sender, e) =>
                {
                    MessageBox.Show("ll"+j+" "+"was clicked");
                };
                tableLayoutAdults.Controls.Add(ll1[j],2,i+1);
                j++;
                ll1[j] = new LinkLabel();
                ll1[j].Text = "DELETE";
                ll1[j].Click += (sender, e) =>
                {
                    MessageBox.Show("ll" + j + " " + "was clicked");
                };
                tableLayoutAdults.Controls.Add(ll1[j], 3, i + 1);
                j++;

                k++;

            }

            j = 0;
            for (int i = 0; i < children; i++)
            {

                tb2[j] = new TextBox();
                tb2[j].Text = ds.Tables[0].Rows[k][0].ToString();
                tb2[j].Enabled = false;
                tableLayoutChildren.Controls.Add(tb2[j],0 , i+1);
                j++;
                tb2[j] = new TextBox();
                tb2[j].Text = ds.Tables[0].Rows[k][1].ToString();
                tb2[j].Enabled = false;
                tableLayoutChildren.Controls.Add(tb2[j], 1 , i+1);
                j--;
                ll2[j] = new LinkLabel();
                ll2[j].Text = "EDIT";
                ll2[j].Click += (sender, e) =>
                {
                    MessageBox.Show("ll" + j + " " + "was clicked");
                };
                tableLayoutChildren.Controls.Add(ll2[j], 2, i + 1);
                j++;
                ll2[j] = new LinkLabel();
                ll2[j].Text = "DELETE";
                ll2[j].Click += (sender, e) =>
                {
                    MessageBox.Show("ll" + j + " " + "was clicked");
                };
                tableLayoutChildren.Controls.Add(ll2[j], 3, i + 1);
                j++;

                k++;
            }
         

        }

        public DataSet FillColumns(int id)
        {
            DataSet ds = cbl.getGuestDetails(id);
            return ds;
        }
        private void tableLayoutAdults_Paint(object sender, PaintEventArgs e)
        {

        }
       
      
        private void bAddAdults_Click(object sender, EventArgs e)
        {
            TextBox tb1=new TextBox();
            TextBox tb2=new TextBox();
            LinkLabel ll1 = new LinkLabel();
            ll1.Text = "EDIT";
            LinkLabel ll2 = new LinkLabel();
            ll2.Text = "DELETE";
            //ll2.Click += (sender, e) =>
            //{
            //    MessageBox.Show("ll"+ " " + "was clicked");
            //};

            
            
            MessageBox.Show(adult_rows.ToString());
            tableLayoutAdults.Controls.Add(tb1, 0,adult_rows);
            tableLayoutAdults.Controls.Add(tb2, 1, adult_rows);
            tableLayoutAdults.Controls.Add(ll1, 2, adult_rows);
            tableLayoutAdults.Controls.Add(ll2, 3, adult_rows);
            adult_rows++;
        }

        private void bAddChildren_Click(object sender, EventArgs e)
        {
            TextBox tb1 = new TextBox();
            TextBox tb2 = new TextBox();
            LinkLabel ll1 = new LinkLabel();
            ll1.Text = "EDIT";
            LinkLabel ll2 = new LinkLabel();
            ll2.Text = "DELETE";
            //ll2.Click += (sender, e) =>
            //{
            //    MessageBox.Show("ll" + j + " " + "was clicked");
            //};


            MessageBox.Show(children_rows.ToString());
            tableLayoutChildren.Controls.Add(tb1, 0, children_rows);
            tableLayoutChildren.Controls.Add(tb2, 1, children_rows);
            tableLayoutChildren.Controls.Add(ll1, 2, children_rows);
            tableLayoutChildren.Controls.Add(ll2, 3, children_rows);
            children_rows++;
        }
    }
}
