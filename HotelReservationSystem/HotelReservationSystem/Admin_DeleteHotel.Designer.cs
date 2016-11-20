namespace PresentationLayer
{
    partial class Admin_DeleteHotel
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
            this.btnDeleteHotel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRateChildNonAc = new System.Windows.Forms.TextBox();
            this.lblRateChildNonAc = new System.Windows.Forms.Label();
            this.txtRateChildAc = new System.Windows.Forms.TextBox();
            this.lblRateChildAc = new System.Windows.Forms.Label();
            this.txtRateAdultNonAc = new System.Windows.Forms.TextBox();
            this.lblRateAdultNonAc = new System.Windows.Forms.Label();
            this.txtRateAdultAc = new System.Windows.Forms.TextBox();
            this.lblRateAdultAc = new System.Windows.Forms.Label();
            this.txtNumNonAcRooms = new System.Windows.Forms.TextBox();
            this.txtNumAcRooms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumAcRooms = new System.Windows.Forms.Label();
            this.txtHotelDesc = new System.Windows.Forms.TextBox();
            this.lblHotelDesc = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHotelId = new System.Windows.Forms.TextBox();
            this.btnSearchHotel = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteHotel
            // 
            this.btnDeleteHotel.Location = new System.Drawing.Point(441, 510);
            this.btnDeleteHotel.Name = "btnDeleteHotel";
            this.btnDeleteHotel.Size = new System.Drawing.Size(152, 54);
            this.btnDeleteHotel.TabIndex = 44;
            this.btnDeleteHotel.Text = "DELETE HOTEL";
            this.btnDeleteHotel.UseVisualStyleBackColor = true;
            this.btnDeleteHotel.Click += new System.EventHandler(this.btnDeleteHotel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(593, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 27);
            this.panel2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "NON-AC ROOMS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(231, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 27);
            this.panel1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "AC ROOMS";
            // 
            // txtRateChildNonAc
            // 
            this.txtRateChildNonAc.Location = new System.Drawing.Point(726, 431);
            this.txtRateChildNonAc.Name = "txtRateChildNonAc";
            this.txtRateChildNonAc.ReadOnly = true;
            this.txtRateChildNonAc.Size = new System.Drawing.Size(100, 20);
            this.txtRateChildNonAc.TabIndex = 42;
            // 
            // lblRateChildNonAc
            // 
            this.lblRateChildNonAc.AutoSize = true;
            this.lblRateChildNonAc.Location = new System.Drawing.Point(558, 434);
            this.lblRateChildNonAc.Name = "lblRateChildNonAc";
            this.lblRateChildNonAc.Size = new System.Drawing.Size(161, 13);
            this.lblRateChildNonAc.TabIndex = 41;
            this.lblRateChildNonAc.Text = "RATE PER NIGHT FOR CHILD:";
            // 
            // txtRateChildAc
            // 
            this.txtRateChildAc.Location = new System.Drawing.Point(350, 428);
            this.txtRateChildAc.Name = "txtRateChildAc";
            this.txtRateChildAc.ReadOnly = true;
            this.txtRateChildAc.Size = new System.Drawing.Size(100, 20);
            this.txtRateChildAc.TabIndex = 40;
            // 
            // lblRateChildAc
            // 
            this.lblRateChildAc.AutoSize = true;
            this.lblRateChildAc.Location = new System.Drawing.Point(182, 431);
            this.lblRateChildAc.Name = "lblRateChildAc";
            this.lblRateChildAc.Size = new System.Drawing.Size(161, 13);
            this.lblRateChildAc.TabIndex = 39;
            this.lblRateChildAc.Text = "RATE PER NIGHT FOR CHILD:";
            // 
            // txtRateAdultNonAc
            // 
            this.txtRateAdultNonAc.Location = new System.Drawing.Point(726, 403);
            this.txtRateAdultNonAc.Name = "txtRateAdultNonAc";
            this.txtRateAdultNonAc.ReadOnly = true;
            this.txtRateAdultNonAc.Size = new System.Drawing.Size(100, 20);
            this.txtRateAdultNonAc.TabIndex = 38;
            // 
            // lblRateAdultNonAc
            // 
            this.lblRateAdultNonAc.AutoSize = true;
            this.lblRateAdultNonAc.Location = new System.Drawing.Point(558, 403);
            this.lblRateAdultNonAc.Name = "lblRateAdultNonAc";
            this.lblRateAdultNonAc.Size = new System.Drawing.Size(165, 13);
            this.lblRateAdultNonAc.TabIndex = 37;
            this.lblRateAdultNonAc.Text = "RATE PER NIGHT FOR ADULT:";
            // 
            // txtRateAdultAc
            // 
            this.txtRateAdultAc.Location = new System.Drawing.Point(350, 400);
            this.txtRateAdultAc.Name = "txtRateAdultAc";
            this.txtRateAdultAc.ReadOnly = true;
            this.txtRateAdultAc.Size = new System.Drawing.Size(100, 20);
            this.txtRateAdultAc.TabIndex = 36;
            // 
            // lblRateAdultAc
            // 
            this.lblRateAdultAc.AutoSize = true;
            this.lblRateAdultAc.Location = new System.Drawing.Point(182, 400);
            this.lblRateAdultAc.Name = "lblRateAdultAc";
            this.lblRateAdultAc.Size = new System.Drawing.Size(165, 13);
            this.lblRateAdultAc.TabIndex = 35;
            this.lblRateAdultAc.Text = "RATE PER NIGHT FOR ADULT:";
            // 
            // txtNumNonAcRooms
            // 
            this.txtNumNonAcRooms.Location = new System.Drawing.Point(725, 375);
            this.txtNumNonAcRooms.Name = "txtNumNonAcRooms";
            this.txtNumNonAcRooms.ReadOnly = true;
            this.txtNumNonAcRooms.Size = new System.Drawing.Size(100, 20);
            this.txtNumNonAcRooms.TabIndex = 34;
            // 
            // txtNumAcRooms
            // 
            this.txtNumAcRooms.Location = new System.Drawing.Point(350, 372);
            this.txtNumAcRooms.Name = "txtNumAcRooms";
            this.txtNumAcRooms.ReadOnly = true;
            this.txtNumAcRooms.Size = new System.Drawing.Size(100, 20);
            this.txtNumAcRooms.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "NUMBER OF NON-AC ROOMS:";
            // 
            // lblNumAcRooms
            // 
            this.lblNumAcRooms.AutoSize = true;
            this.lblNumAcRooms.Location = new System.Drawing.Point(210, 375);
            this.lblNumAcRooms.Name = "lblNumAcRooms";
            this.lblNumAcRooms.Size = new System.Drawing.Size(134, 13);
            this.lblNumAcRooms.TabIndex = 31;
            this.lblNumAcRooms.Text = "NUMBER OF AC ROOMS:";
            // 
            // txtHotelDesc
            // 
            this.txtHotelDesc.Location = new System.Drawing.Point(458, 250);
            this.txtHotelDesc.Multiline = true;
            this.txtHotelDesc.Name = "txtHotelDesc";
            this.txtHotelDesc.ReadOnly = true;
            this.txtHotelDesc.Size = new System.Drawing.Size(202, 42);
            this.txtHotelDesc.TabIndex = 30;
            // 
            // lblHotelDesc
            // 
            this.lblHotelDesc.AutoSize = true;
            this.lblHotelDesc.Location = new System.Drawing.Point(329, 252);
            this.lblHotelDesc.Name = "lblHotelDesc";
            this.lblHotelDesc.Size = new System.Drawing.Size(122, 13);
            this.lblHotelDesc.TabIndex = 29;
            this.lblHotelDesc.Text = "HOTEL DESCRIPTION:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(417, 225);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 13);
            this.lblCity.TabIndex = 27;
            this.lblCity.Text = "CITY:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(388, 196);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(63, 13);
            this.lblCountry.TabIndex = 25;
            this.lblCountry.Text = "COUNTRY:";
            // 
            // txtHotelName
            // 
            this.txtHotelName.Location = new System.Drawing.Point(457, 167);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.ReadOnly = true;
            this.txtHotelName.Size = new System.Drawing.Size(100, 20);
            this.txtHotelName.TabIndex = 24;
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Location = new System.Drawing.Point(371, 170);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(80, 13);
            this.lblHotelName.TabIndex = 23;
            this.lblHotelName.Text = "HOTEL NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "HOTEL ID:";
            // 
            // txtHotelId
            // 
            this.txtHotelId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtHotelId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtHotelId.Location = new System.Drawing.Point(457, 88);
            this.txtHotelId.MaxLength = 7;
            this.txtHotelId.Name = "txtHotelId";
            this.txtHotelId.Size = new System.Drawing.Size(100, 20);
            this.txtHotelId.TabIndex = 46;
            this.txtHotelId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHotelId_KeyPress);
            // 
            // btnSearchHotel
            // 
            this.btnSearchHotel.Location = new System.Drawing.Point(576, 86);
            this.btnSearchHotel.Name = "btnSearchHotel";
            this.btnSearchHotel.Size = new System.Drawing.Size(75, 23);
            this.btnSearchHotel.TabIndex = 47;
            this.btnSearchHotel.Text = "SEARCH";
            this.btnSearchHotel.UseVisualStyleBackColor = true;
            this.btnSearchHotel.Click += new System.EventHandler(this.btnSearchHotel_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(457, 196);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(136, 20);
            this.txtCountry.TabIndex = 48;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(458, 222);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(135, 20);
            this.txtCity.TabIndex = 49;
            // 
            // Admin_DeleteHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.ControlBox = false;
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.btnSearchHotel);
            this.Controls.Add(this.txtHotelId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteHotel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRateChildNonAc);
            this.Controls.Add(this.lblRateChildNonAc);
            this.Controls.Add(this.txtRateChildAc);
            this.Controls.Add(this.lblRateChildAc);
            this.Controls.Add(this.txtRateAdultNonAc);
            this.Controls.Add(this.lblRateAdultNonAc);
            this.Controls.Add(this.txtRateAdultAc);
            this.Controls.Add(this.lblRateAdultAc);
            this.Controls.Add(this.txtNumNonAcRooms);
            this.Controls.Add(this.txtNumAcRooms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumAcRooms);
            this.Controls.Add(this.txtHotelDesc);
            this.Controls.Add(this.lblHotelDesc);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtHotelName);
            this.Controls.Add(this.lblHotelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Admin_DeleteHotel";
            this.Text = "Admin_DeleteHotel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_DeleteHotel_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteHotel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRateChildNonAc;
        private System.Windows.Forms.Label lblRateChildNonAc;
        private System.Windows.Forms.TextBox txtRateChildAc;
        private System.Windows.Forms.Label lblRateChildAc;
        private System.Windows.Forms.TextBox txtRateAdultNonAc;
        private System.Windows.Forms.Label lblRateAdultNonAc;
        private System.Windows.Forms.TextBox txtRateAdultAc;
        private System.Windows.Forms.Label lblRateAdultAc;
        private System.Windows.Forms.TextBox txtNumNonAcRooms;
        private System.Windows.Forms.TextBox txtNumAcRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumAcRooms;
        private System.Windows.Forms.TextBox txtHotelDesc;
        private System.Windows.Forms.Label lblHotelDesc;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHotelId;
        private System.Windows.Forms.Button btnSearchHotel;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
    }
}