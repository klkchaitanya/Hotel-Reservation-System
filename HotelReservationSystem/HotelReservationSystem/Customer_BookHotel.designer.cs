namespace PresentationLayer
{
    partial class Customer_BookHotel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboxRoomType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datepickerArrival = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumberOfNights = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHotelId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datepickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberOfAdults = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumberOfChildren = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberOfRooms = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRateAdult = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblRateChild = new System.Windows.Forms.Label();
            this.btnContinueToGuestDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxRoomType
            // 
            this.cboxRoomType.FormattingEnabled = true;
            this.cboxRoomType.Items.AddRange(new object[] {
            "AC",
            "NON-AC"});
            this.cboxRoomType.Location = new System.Drawing.Point(430, 205);
            this.cboxRoomType.Name = "cboxRoomType";
            this.cboxRoomType.Size = new System.Drawing.Size(162, 21);
            this.cboxRoomType.TabIndex = 21;
            this.cboxRoomType.Text = "<Select Type>";
            this.cboxRoomType.SelectedIndexChanged += new System.EventHandler(this.cboxRoomType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "ROOM TYPE:";
            // 
            // txtHotelName
            // 
            this.txtHotelName.Location = new System.Drawing.Point(431, 172);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(162, 20);
            this.txtHotelName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "HOTEL NAME:";
            // 
            // datepickerArrival
            // 
            this.datepickerArrival.Location = new System.Drawing.Point(431, 239);
            this.datepickerArrival.MinDate = new System.DateTime(2014, 10, 18, 0, 0, 0, 0);
            this.datepickerArrival.Name = "datepickerArrival";
            this.datepickerArrival.Size = new System.Drawing.Size(162, 20);
            this.datepickerArrival.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "ARRIVAL DATE:";
            // 
            // txtNumberOfNights
            // 
            this.txtNumberOfNights.Location = new System.Drawing.Point(431, 300);
            this.txtNumberOfNights.Name = "txtNumberOfNights";
            this.txtNumberOfNights.Size = new System.Drawing.Size(162, 20);
            this.txtNumberOfNights.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "NUMBER OF NIGHTS:";
            // 
            // txtHotelId
            // 
            this.txtHotelId.Location = new System.Drawing.Point(431, 139);
            this.txtHotelId.Name = "txtHotelId";
            this.txtHotelId.Size = new System.Drawing.Size(162, 20);
            this.txtHotelId.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "HOTEL ID:";
            // 
            // datepickerDeparture
            // 
            this.datepickerDeparture.Location = new System.Drawing.Point(431, 267);
            this.datepickerDeparture.MinDate = new System.DateTime(2014, 10, 18, 0, 0, 0, 0);
            this.datepickerDeparture.Name = "datepickerDeparture";
            this.datepickerDeparture.Size = new System.Drawing.Size(162, 20);
            this.datepickerDeparture.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "DEPARTURE DATE:";
            // 
            // txtNumberOfAdults
            // 
            this.txtNumberOfAdults.Location = new System.Drawing.Point(430, 330);
            this.txtNumberOfAdults.Name = "txtNumberOfAdults";
            this.txtNumberOfAdults.Size = new System.Drawing.Size(162, 20);
            this.txtNumberOfAdults.TabIndex = 31;
            this.txtNumberOfAdults.Text = "1";
            this.txtNumberOfAdults.TextChanged += new System.EventHandler(this.txtNumberOfAdults_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "NUMBER OF ADULTS:";
            // 
            // txtNumberOfChildren
            // 
            this.txtNumberOfChildren.Location = new System.Drawing.Point(430, 360);
            this.txtNumberOfChildren.Name = "txtNumberOfChildren";
            this.txtNumberOfChildren.Size = new System.Drawing.Size(162, 20);
            this.txtNumberOfChildren.TabIndex = 33;
            this.txtNumberOfChildren.Text = "0";
            this.txtNumberOfChildren.TextChanged += new System.EventHandler(this.txtNumberOfChildren_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "NUMBER OF CHILDREN:";
            // 
            // txtNumberOfRooms
            // 
            this.txtNumberOfRooms.Location = new System.Drawing.Point(431, 392);
            this.txtNumberOfRooms.Name = "txtNumberOfRooms";
            this.txtNumberOfRooms.Size = new System.Drawing.Size(162, 20);
            this.txtNumberOfRooms.TabIndex = 35;
            this.txtNumberOfRooms.Text = "1";
            this.txtNumberOfRooms.TextChanged += new System.EventHandler(this.txtNumberOfRooms_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "NUMBER OF ROOMS:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "CONTINUE TO PAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "TOTAL AMOUNT : Rs.";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(430, 451);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(41, 13);
            this.lblTotalCost.TabIndex = 38;
            this.lblTotalCost.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(598, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Each Rs.";
            // 
            // lblRateAdult
            // 
            this.lblRateAdult.AutoSize = true;
            this.lblRateAdult.Location = new System.Drawing.Point(645, 333);
            this.lblRateAdult.Name = "lblRateAdult";
            this.lblRateAdult.Size = new System.Drawing.Size(41, 13);
            this.lblRateAdult.TabIndex = 40;
            this.lblRateAdult.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(598, 363);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Each Rs.";
            // 
            // lblRateChild
            // 
            this.lblRateChild.AutoSize = true;
            this.lblRateChild.Location = new System.Drawing.Point(645, 363);
            this.lblRateChild.Name = "lblRateChild";
            this.lblRateChild.Size = new System.Drawing.Size(41, 13);
            this.lblRateChild.TabIndex = 42;
            this.lblRateChild.Text = "label15";
            // 
            // btnContinueToGuestDetails
            // 
            this.btnContinueToGuestDetails.Location = new System.Drawing.Point(368, 496);
            this.btnContinueToGuestDetails.Name = "btnContinueToGuestDetails";
            this.btnContinueToGuestDetails.Size = new System.Drawing.Size(75, 23);
            this.btnContinueToGuestDetails.TabIndex = 43;
            this.btnContinueToGuestDetails.Text = "C0NTINUE";
            this.btnContinueToGuestDetails.UseVisualStyleBackColor = true;
            this.btnContinueToGuestDetails.Click += new System.EventHandler(this.btnContinueToGuestDetails_Click);
            // 
            // Customer_BookHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 720);
            this.Controls.Add(this.btnContinueToGuestDetails);
            this.Controls.Add(this.lblRateChild);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblRateAdult);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumberOfRooms);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumberOfChildren);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumberOfAdults);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datepickerDeparture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHotelId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberOfNights);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datepickerArrival);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxRoomType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHotelName);
            this.Controls.Add(this.label3);
            this.Name = "Customer_BookHotel";
            this.Text = "Customer_BookHotel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_BookHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxRoomType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datepickerArrival;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumberOfNights;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHotelId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datepickerDeparture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberOfAdults;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumberOfChildren;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumberOfRooms;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblRateAdult;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblRateChild;
        private System.Windows.Forms.Button btnContinueToGuestDetails;
    }
}