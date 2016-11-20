namespace PresentationLayer
{
    partial class Admin_AddHotel
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
            this.components = new System.ComponentModel.Container();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cboxCountry = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cboxCity = new System.Windows.Forms.ComboBox();
            this.lblHotelDesc = new System.Windows.Forms.Label();
            this.txtHotelDesc = new System.Windows.Forms.TextBox();
            this.lblNumAcRooms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumAcRooms = new System.Windows.Forms.TextBox();
            this.txtNumNonAcRooms = new System.Windows.Forms.TextBox();
            this.lblRateAdultAc = new System.Windows.Forms.Label();
            this.txtRateAdultAc = new System.Windows.Forms.TextBox();
            this.txtRateAdultNonAc = new System.Windows.Forms.TextBox();
            this.lblRateAdultNonAc = new System.Windows.Forms.Label();
            this.txtRateChildAc = new System.Windows.Forms.TextBox();
            this.lblRateChildAc = new System.Windows.Forms.Label();
            this.txtRateChildNonAc = new System.Windows.Forms.TextBox();
            this.lblRateChildNonAc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddHotel = new System.Windows.Forms.Button();
            this.lblHotelImage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.erpHotelName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpHotelDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNoAcRoom = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNoNonAcRoom = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpRateAcAdult = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpRateAcChild = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpRateNonAcAdult = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpRateNonAcChild = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHotelName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHotelDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNoAcRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNoNonAcRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRateAcAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRateAcChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRateNonAcAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRateNonAcChild)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Location = new System.Drawing.Point(394, 170);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(80, 13);
            this.lblHotelName.TabIndex = 0;
            this.lblHotelName.Text = "HOTEL NAME:";
            // 
            // txtHotelName
            // 
            this.txtHotelName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHotelName.Location = new System.Drawing.Point(480, 167);
            this.txtHotelName.MaxLength = 20;
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(100, 20);
            this.txtHotelName.TabIndex = 1;
            this.txtHotelName.Validating += new System.ComponentModel.CancelEventHandler(this.txtHotelName_Validating);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(411, 196);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(63, 13);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "COUNTRY:";
            // 
            // cboxCountry
            // 
            this.cboxCountry.FormattingEnabled = true;
            this.cboxCountry.Location = new System.Drawing.Point(480, 193);
            this.cboxCountry.Name = "cboxCountry";
            this.cboxCountry.Size = new System.Drawing.Size(121, 21);
            this.cboxCountry.TabIndex = 3;
            this.cboxCountry.SelectedIndexChanged += new System.EventHandler(this.cboxCountry_SelectedIndexChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(440, 225);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "CITY:";
            // 
            // cboxCity
            // 
            this.cboxCity.FormattingEnabled = true;
            this.cboxCity.Location = new System.Drawing.Point(480, 222);
            this.cboxCity.Name = "cboxCity";
            this.cboxCity.Size = new System.Drawing.Size(121, 21);
            this.cboxCity.TabIndex = 5;
            // 
            // lblHotelDesc
            // 
            this.lblHotelDesc.AutoSize = true;
            this.lblHotelDesc.Location = new System.Drawing.Point(352, 252);
            this.lblHotelDesc.Name = "lblHotelDesc";
            this.lblHotelDesc.Size = new System.Drawing.Size(122, 13);
            this.lblHotelDesc.TabIndex = 6;
            this.lblHotelDesc.Text = "HOTEL DESCRIPTION:";
            // 
            // txtHotelDesc
            // 
            this.txtHotelDesc.Location = new System.Drawing.Point(481, 250);
            this.txtHotelDesc.MaxLength = 150;
            this.txtHotelDesc.Multiline = true;
            this.txtHotelDesc.Name = "txtHotelDesc";
            this.txtHotelDesc.Size = new System.Drawing.Size(202, 42);
            this.txtHotelDesc.TabIndex = 7;
            this.txtHotelDesc.Validating += new System.ComponentModel.CancelEventHandler(this.txtHotelDesc_Validating);
            // 
            // lblNumAcRooms
            // 
            this.lblNumAcRooms.AutoSize = true;
            this.lblNumAcRooms.Location = new System.Drawing.Point(233, 375);
            this.lblNumAcRooms.Name = "lblNumAcRooms";
            this.lblNumAcRooms.Size = new System.Drawing.Size(134, 13);
            this.lblNumAcRooms.TabIndex = 8;
            this.lblNumAcRooms.Text = "NUMBER OF AC ROOMS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "NUMBER OF NON-AC ROOMS:";
            // 
            // txtNumAcRooms
            // 
            this.txtNumAcRooms.Location = new System.Drawing.Point(373, 372);
            this.txtNumAcRooms.MaxLength = 3;
            this.txtNumAcRooms.Name = "txtNumAcRooms";
            this.txtNumAcRooms.Size = new System.Drawing.Size(100, 20);
            this.txtNumAcRooms.TabIndex = 10;
            this.txtNumAcRooms.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumAcRooms_Validating);
            // 
            // txtNumNonAcRooms
            // 
            this.txtNumNonAcRooms.Location = new System.Drawing.Point(748, 375);
            this.txtNumNonAcRooms.MaxLength = 3;
            this.txtNumNonAcRooms.Name = "txtNumNonAcRooms";
            this.txtNumNonAcRooms.Size = new System.Drawing.Size(100, 20);
            this.txtNumNonAcRooms.TabIndex = 11;
            this.txtNumNonAcRooms.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumNonAcRooms_Validating);
            // 
            // lblRateAdultAc
            // 
            this.lblRateAdultAc.AutoSize = true;
            this.lblRateAdultAc.Location = new System.Drawing.Point(205, 400);
            this.lblRateAdultAc.Name = "lblRateAdultAc";
            this.lblRateAdultAc.Size = new System.Drawing.Size(165, 13);
            this.lblRateAdultAc.TabIndex = 12;
            this.lblRateAdultAc.Text = "RATE PER NIGHT FOR ADULT:";
            // 
            // txtRateAdultAc
            // 
            this.txtRateAdultAc.Location = new System.Drawing.Point(373, 400);
            this.txtRateAdultAc.MaxLength = 4;
            this.txtRateAdultAc.Name = "txtRateAdultAc";
            this.txtRateAdultAc.Size = new System.Drawing.Size(100, 20);
            this.txtRateAdultAc.TabIndex = 13;
            this.txtRateAdultAc.Validating += new System.ComponentModel.CancelEventHandler(this.txtRateAdultAc_Validating);
            // 
            // txtRateAdultNonAc
            // 
            this.txtRateAdultNonAc.Location = new System.Drawing.Point(749, 403);
            this.txtRateAdultNonAc.MaxLength = 4;
            this.txtRateAdultNonAc.Name = "txtRateAdultNonAc";
            this.txtRateAdultNonAc.Size = new System.Drawing.Size(100, 20);
            this.txtRateAdultNonAc.TabIndex = 15;
            this.txtRateAdultNonAc.Validated += new System.EventHandler(this.txtRateAdultNonAc_Validated);
            // 
            // lblRateAdultNonAc
            // 
            this.lblRateAdultNonAc.AutoSize = true;
            this.lblRateAdultNonAc.Location = new System.Drawing.Point(581, 403);
            this.lblRateAdultNonAc.Name = "lblRateAdultNonAc";
            this.lblRateAdultNonAc.Size = new System.Drawing.Size(165, 13);
            this.lblRateAdultNonAc.TabIndex = 14;
            this.lblRateAdultNonAc.Text = "RATE PER NIGHT FOR ADULT:";
            // 
            // txtRateChildAc
            // 
            this.txtRateChildAc.Location = new System.Drawing.Point(373, 428);
            this.txtRateChildAc.MaxLength = 4;
            this.txtRateChildAc.Name = "txtRateChildAc";
            this.txtRateChildAc.Size = new System.Drawing.Size(100, 20);
            this.txtRateChildAc.TabIndex = 17;
            this.txtRateChildAc.Validating += new System.ComponentModel.CancelEventHandler(this.txtRateChildAc_Validating);
            // 
            // lblRateChildAc
            // 
            this.lblRateChildAc.AutoSize = true;
            this.lblRateChildAc.Location = new System.Drawing.Point(205, 431);
            this.lblRateChildAc.Name = "lblRateChildAc";
            this.lblRateChildAc.Size = new System.Drawing.Size(161, 13);
            this.lblRateChildAc.TabIndex = 16;
            this.lblRateChildAc.Text = "RATE PER NIGHT FOR CHILD:";
            // 
            // txtRateChildNonAc
            // 
            this.txtRateChildNonAc.Location = new System.Drawing.Point(749, 431);
            this.txtRateChildNonAc.MaxLength = 4;
            this.txtRateChildNonAc.Name = "txtRateChildNonAc";
            this.txtRateChildNonAc.Size = new System.Drawing.Size(100, 20);
            this.txtRateChildNonAc.TabIndex = 19;
            this.txtRateChildNonAc.Validating += new System.ComponentModel.CancelEventHandler(this.txtRateChildNonAc_Validating);
            // 
            // lblRateChildNonAc
            // 
            this.lblRateChildNonAc.AutoSize = true;
            this.lblRateChildNonAc.Location = new System.Drawing.Point(581, 434);
            this.lblRateChildNonAc.Name = "lblRateChildNonAc";
            this.lblRateChildNonAc.Size = new System.Drawing.Size(161, 13);
            this.lblRateChildNonAc.TabIndex = 18;
            this.lblRateChildNonAc.Text = "RATE PER NIGHT FOR CHILD:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(254, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 27);
            this.panel1.TabIndex = 20;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(616, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 27);
            this.panel2.TabIndex = 0;
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
            // btnAddHotel
            // 
            this.btnAddHotel.Location = new System.Drawing.Point(464, 510);
            this.btnAddHotel.Name = "btnAddHotel";
            this.btnAddHotel.Size = new System.Drawing.Size(152, 54);
            this.btnAddHotel.TabIndex = 21;
            this.btnAddHotel.Text = "ADD HOTEL";
            this.btnAddHotel.UseVisualStyleBackColor = true;
            this.btnAddHotel.Click += new System.EventHandler(this.btnAddHotel_Click);
            // 
            // lblHotelImage
            // 
            this.lblHotelImage.AutoSize = true;
            this.lblHotelImage.Location = new System.Drawing.Point(693, 167);
            this.lblHotelImage.Name = "lblHotelImage";
            this.lblHotelImage.Size = new System.Drawing.Size(80, 13);
            this.lblHotelImage.TabIndex = 22;
            this.lblHotelImage.Text = "HOTEL IMAGE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(779, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(808, 285);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(75, 23);
            this.btnSelectImage.TabIndex = 24;
            this.btnSelectImage.Text = "SelectImage";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // erpHotelName
            // 
            this.erpHotelName.ContainerControl = this;
            // 
            // erpHotelDescription
            // 
            this.erpHotelDescription.ContainerControl = this;
            // 
            // erpNoAcRoom
            // 
            this.erpNoAcRoom.ContainerControl = this;
            // 
            // erpNoNonAcRoom
            // 
            this.erpNoNonAcRoom.ContainerControl = this;
            // 
            // erpRateAcAdult
            // 
            this.erpRateAcAdult.ContainerControl = this;
            // 
            // erpRateAcChild
            // 
            this.erpRateAcChild.ContainerControl = this;
            // 
            // erpRateNonAcAdult
            // 
            this.erpRateNonAcAdult.ContainerControl = this;
            // 
            // erpRateNonAcChild
            // 
            this.erpRateNonAcChild.ContainerControl = this;
            // 
            // Admin_AddHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1018, 740);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHotelImage);
            this.Controls.Add(this.btnAddHotel);
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
            this.Controls.Add(this.cboxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cboxCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtHotelName);
            this.Controls.Add(this.lblHotelName);
            this.Name = "Admin_AddHotel";
            this.Text = "New Hotel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_AddHotel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHotelName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHotelDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNoAcRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNoNonAcRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRateAcAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRateAcChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRateNonAcAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRateNonAcChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cboxCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cboxCity;
        private System.Windows.Forms.Label lblHotelDesc;
        private System.Windows.Forms.TextBox txtHotelDesc;
        private System.Windows.Forms.Label lblNumAcRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumAcRooms;
        private System.Windows.Forms.TextBox txtNumNonAcRooms;
        private System.Windows.Forms.Label lblRateAdultAc;
        private System.Windows.Forms.TextBox txtRateAdultAc;
        private System.Windows.Forms.TextBox txtRateAdultNonAc;
        private System.Windows.Forms.Label lblRateAdultNonAc;
        private System.Windows.Forms.TextBox txtRateChildAc;
        private System.Windows.Forms.Label lblRateChildAc;
        private System.Windows.Forms.TextBox txtRateChildNonAc;
        private System.Windows.Forms.Label lblRateChildNonAc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddHotel;
        private System.Windows.Forms.Label lblHotelImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.ErrorProvider erpHotelName;
        private System.Windows.Forms.ErrorProvider erpHotelDescription;
        private System.Windows.Forms.ErrorProvider erpNoAcRoom;
        private System.Windows.Forms.ErrorProvider erpNoNonAcRoom;
        private System.Windows.Forms.ErrorProvider erpRateAcAdult;
        private System.Windows.Forms.ErrorProvider erpRateAcChild;
        private System.Windows.Forms.ErrorProvider erpRateNonAcAdult;
        private System.Windows.Forms.ErrorProvider erpRateNonAcChild;
    }
}