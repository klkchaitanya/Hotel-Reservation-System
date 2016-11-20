namespace PresentationLayer
{
    partial class Admin_EditHotel
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
            this.txtHotelId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotalRoomsVal = new System.Windows.Forms.Label();
            this.lblCityVal = new System.Windows.Forms.Label();
            this.lblCountryVal = new System.Windows.Forms.Label();
            this.lblHotelIdVal = new System.Windows.Forms.Label();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblHotelId = new System.Windows.Forms.Label();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHotelDesc = new System.Windows.Forms.TextBox();
            this.lblHotelDesc = new System.Windows.Forms.Label();
            this.txtNumNonAcRooms = new System.Windows.Forms.TextBox();
            this.txtNumAcRooms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumAcRooms = new System.Windows.Forms.Label();
            this.txtRateChildNonAc = new System.Windows.Forms.TextBox();
            this.lblRateChildNonAc = new System.Windows.Forms.Label();
            this.txtRateChildAc = new System.Windows.Forms.TextBox();
            this.lblRateChildAc = new System.Windows.Forms.Label();
            this.txtRateAdultNonAc = new System.Windows.Forms.TextBox();
            this.lblRateAdultNonAc = new System.Windows.Forms.Label();
            this.txtRateAdultAc = new System.Windows.Forms.TextBox();
            this.lblRateAdultAc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnAc = new System.Windows.Forms.RadioButton();
            this.rbtnNonAc = new System.Windows.Forms.RadioButton();
            this.btnUpdateDetail = new System.Windows.Forms.Button();
            this.erpHotelName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpHotelDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNoAcRoom = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNoNonAcRoom = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpRateAcAdult = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpRateAcChild = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpRateNonAcAdult = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpRateNonAcChild = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.lblHotelName.Location = new System.Drawing.Point(267, 76);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(100, 13);
            this.lblHotelName.TabIndex = 0;
            this.lblHotelName.Text = "ENTER HOTEL ID:";
            // 
            // txtHotelId
            // 
            this.txtHotelId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtHotelId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtHotelId.Location = new System.Drawing.Point(393, 73);
            this.txtHotelId.MaxLength = 7;
            this.txtHotelId.Name = "txtHotelId";
            this.txtHotelId.Size = new System.Drawing.Size(100, 20);
            this.txtHotelId.TabIndex = 1;
            this.txtHotelId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHotelId_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(511, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTotalRoomsVal);
            this.panel1.Controls.Add(this.lblCityVal);
            this.panel1.Controls.Add(this.lblCountryVal);
            this.panel1.Controls.Add(this.lblHotelIdVal);
            this.panel1.Controls.Add(this.lblTotalRooms);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.lblCountry);
            this.panel1.Controls.Add(this.lblHotelId);
            this.panel1.Location = new System.Drawing.Point(25, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 389);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblTotalRoomsVal
            // 
            this.lblTotalRoomsVal.AutoSize = true;
            this.lblTotalRoomsVal.Location = new System.Drawing.Point(149, 325);
            this.lblTotalRoomsVal.Name = "lblTotalRoomsVal";
            this.lblTotalRoomsVal.Size = new System.Drawing.Size(35, 13);
            this.lblTotalRoomsVal.TabIndex = 7;
            this.lblTotalRoomsVal.Text = "label4";
            // 
            // lblCityVal
            // 
            this.lblCityVal.AutoSize = true;
            this.lblCityVal.Location = new System.Drawing.Point(149, 295);
            this.lblCityVal.Name = "lblCityVal";
            this.lblCityVal.Size = new System.Drawing.Size(35, 13);
            this.lblCityVal.TabIndex = 6;
            this.lblCityVal.Text = "label3";
            // 
            // lblCountryVal
            // 
            this.lblCountryVal.AutoSize = true;
            this.lblCountryVal.Location = new System.Drawing.Point(149, 264);
            this.lblCountryVal.Name = "lblCountryVal";
            this.lblCountryVal.Size = new System.Drawing.Size(35, 13);
            this.lblCountryVal.TabIndex = 5;
            this.lblCountryVal.Text = "label2";
            // 
            // lblHotelIdVal
            // 
            this.lblHotelIdVal.AutoSize = true;
            this.lblHotelIdVal.Location = new System.Drawing.Point(149, 235);
            this.lblHotelIdVal.Name = "lblHotelIdVal";
            this.lblHotelIdVal.Size = new System.Drawing.Size(35, 13);
            this.lblHotelIdVal.TabIndex = 4;
            this.lblHotelIdVal.Text = "label1";
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.AutoSize = true;
            this.lblTotalRooms.Location = new System.Drawing.Point(32, 325);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(88, 13);
            this.lblTotalRooms.TabIndex = 3;
            this.lblTotalRooms.Text = "TOTAL ROOMS:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(86, 295);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "CITY:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(57, 264);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(63, 13);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "COUNTRY:";
            // 
            // lblHotelId
            // 
            this.lblHotelId.AutoSize = true;
            this.lblHotelId.Location = new System.Drawing.Point(60, 235);
            this.lblHotelId.Name = "lblHotelId";
            this.lblHotelId.Size = new System.Drawing.Size(60, 13);
            this.lblHotelId.TabIndex = 0;
            this.lblHotelId.Text = "HOTEL ID:";
            // 
            // txtHotelName
            // 
            this.txtHotelName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHotelName.Location = new System.Drawing.Point(446, 195);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(100, 20);
            this.txtHotelName.TabIndex = 5;
            this.txtHotelName.Validating += new System.ComponentModel.CancelEventHandler(this.txtHotelName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "HOTEL NAME:";
            // 
            // txtHotelDesc
            // 
            this.txtHotelDesc.Location = new System.Drawing.Point(447, 230);
            this.txtHotelDesc.MaxLength = 150;
            this.txtHotelDesc.Multiline = true;
            this.txtHotelDesc.Name = "txtHotelDesc";
            this.txtHotelDesc.Size = new System.Drawing.Size(202, 42);
            this.txtHotelDesc.TabIndex = 9;
            this.txtHotelDesc.Validating += new System.ComponentModel.CancelEventHandler(this.txtHotelDesc_Validating);
            // 
            // lblHotelDesc
            // 
            this.lblHotelDesc.AutoSize = true;
            this.lblHotelDesc.Location = new System.Drawing.Point(318, 231);
            this.lblHotelDesc.Name = "lblHotelDesc";
            this.lblHotelDesc.Size = new System.Drawing.Size(122, 13);
            this.lblHotelDesc.TabIndex = 8;
            this.lblHotelDesc.Text = "HOTEL DESCRIPTION:";
            // 
            // txtNumNonAcRooms
            // 
            this.txtNumNonAcRooms.Location = new System.Drawing.Point(759, 316);
            this.txtNumNonAcRooms.MaxLength = 3;
            this.txtNumNonAcRooms.Name = "txtNumNonAcRooms";
            this.txtNumNonAcRooms.Size = new System.Drawing.Size(100, 20);
            this.txtNumNonAcRooms.TabIndex = 15;
            this.txtNumNonAcRooms.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumNonAcRooms_Validating);
            // 
            // txtNumAcRooms
            // 
            this.txtNumAcRooms.Location = new System.Drawing.Point(454, 313);
            this.txtNumAcRooms.MaxLength = 3;
            this.txtNumAcRooms.Name = "txtNumAcRooms";
            this.txtNumAcRooms.Size = new System.Drawing.Size(100, 20);
            this.txtNumAcRooms.TabIndex = 14;
            this.txtNumAcRooms.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumAcRooms_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "NUMBER OF NON-AC ROOMS:";
            // 
            // lblNumAcRooms
            // 
            this.lblNumAcRooms.AutoSize = true;
            this.lblNumAcRooms.Location = new System.Drawing.Point(306, 316);
            this.lblNumAcRooms.Name = "lblNumAcRooms";
            this.lblNumAcRooms.Size = new System.Drawing.Size(134, 13);
            this.lblNumAcRooms.TabIndex = 12;
            this.lblNumAcRooms.Text = "NUMBER OF AC ROOMS:";
            // 
            // txtRateChildNonAc
            // 
            this.txtRateChildNonAc.Location = new System.Drawing.Point(759, 433);
            this.txtRateChildNonAc.MaxLength = 4;
            this.txtRateChildNonAc.Name = "txtRateChildNonAc";
            this.txtRateChildNonAc.Size = new System.Drawing.Size(100, 20);
            this.txtRateChildNonAc.TabIndex = 27;
            this.txtRateChildNonAc.Validating += new System.ComponentModel.CancelEventHandler(this.txtRateChildNonAc_Validating);
            // 
            // lblRateChildNonAc
            // 
            this.lblRateChildNonAc.AutoSize = true;
            this.lblRateChildNonAc.Location = new System.Drawing.Point(592, 436);
            this.lblRateChildNonAc.Name = "lblRateChildNonAc";
            this.lblRateChildNonAc.Size = new System.Drawing.Size(161, 13);
            this.lblRateChildNonAc.TabIndex = 26;
            this.lblRateChildNonAc.Text = "RATE PER NIGHT FOR CHILD:";
            // 
            // txtRateChildAc
            // 
            this.txtRateChildAc.Location = new System.Drawing.Point(459, 433);
            this.txtRateChildAc.MaxLength = 4;
            this.txtRateChildAc.Name = "txtRateChildAc";
            this.txtRateChildAc.Size = new System.Drawing.Size(100, 20);
            this.txtRateChildAc.TabIndex = 25;
            this.txtRateChildAc.Validating += new System.ComponentModel.CancelEventHandler(this.txtRateChildAc_Validating);
            // 
            // lblRateChildAc
            // 
            this.lblRateChildAc.AutoSize = true;
            this.lblRateChildAc.Location = new System.Drawing.Point(292, 436);
            this.lblRateChildAc.Name = "lblRateChildAc";
            this.lblRateChildAc.Size = new System.Drawing.Size(161, 13);
            this.lblRateChildAc.TabIndex = 24;
            this.lblRateChildAc.Text = "RATE PER NIGHT FOR CHILD:";
            // 
            // txtRateAdultNonAc
            // 
            this.txtRateAdultNonAc.Location = new System.Drawing.Point(759, 397);
            this.txtRateAdultNonAc.MaxLength = 4;
            this.txtRateAdultNonAc.Name = "txtRateAdultNonAc";
            this.txtRateAdultNonAc.Size = new System.Drawing.Size(100, 20);
            this.txtRateAdultNonAc.TabIndex = 23;
            this.txtRateAdultNonAc.Validating += new System.ComponentModel.CancelEventHandler(this.txtRateAdultNonAc_Validating);
            // 
            // lblRateAdultNonAc
            // 
            this.lblRateAdultNonAc.AutoSize = true;
            this.lblRateAdultNonAc.Location = new System.Drawing.Point(588, 401);
            this.lblRateAdultNonAc.Name = "lblRateAdultNonAc";
            this.lblRateAdultNonAc.Size = new System.Drawing.Size(165, 13);
            this.lblRateAdultNonAc.TabIndex = 22;
            this.lblRateAdultNonAc.Text = "RATE PER NIGHT FOR ADULT:";
            // 
            // txtRateAdultAc
            // 
            this.txtRateAdultAc.Location = new System.Drawing.Point(459, 394);
            this.txtRateAdultAc.MaxLength = 4;
            this.txtRateAdultAc.Name = "txtRateAdultAc";
            this.txtRateAdultAc.Size = new System.Drawing.Size(100, 20);
            this.txtRateAdultAc.TabIndex = 21;
            this.txtRateAdultAc.Validating += new System.ComponentModel.CancelEventHandler(this.txtRateAdultAc_Validating);
            // 
            // lblRateAdultAc
            // 
            this.lblRateAdultAc.AutoSize = true;
            this.lblRateAdultAc.Location = new System.Drawing.Point(288, 397);
            this.lblRateAdultAc.Name = "lblRateAdultAc";
            this.lblRateAdultAc.Size = new System.Drawing.Size(165, 13);
            this.lblRateAdultAc.TabIndex = 20;
            this.lblRateAdultAc.Text = "RATE PER NIGHT FOR ADULT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "ROOM TYPE:";
            // 
            // rbtnAc
            // 
            this.rbtnAc.AutoSize = true;
            this.rbtnAc.Location = new System.Drawing.Point(454, 350);
            this.rbtnAc.Name = "rbtnAc";
            this.rbtnAc.Size = new System.Drawing.Size(39, 17);
            this.rbtnAc.TabIndex = 29;
            this.rbtnAc.TabStop = true;
            this.rbtnAc.Text = "AC";
            this.rbtnAc.UseVisualStyleBackColor = true;
            this.rbtnAc.CheckedChanged += new System.EventHandler(this.rbtnAc_CheckedChanged);
            // 
            // rbtnNonAc
            // 
            this.rbtnNonAc.AutoSize = true;
            this.rbtnNonAc.Location = new System.Drawing.Point(511, 350);
            this.rbtnNonAc.Name = "rbtnNonAc";
            this.rbtnNonAc.Size = new System.Drawing.Size(66, 17);
            this.rbtnNonAc.TabIndex = 30;
            this.rbtnNonAc.TabStop = true;
            this.rbtnNonAc.Text = "NON-AC";
            this.rbtnNonAc.UseVisualStyleBackColor = true;
            this.rbtnNonAc.CheckedChanged += new System.EventHandler(this.rbtnNonAc_CheckedChanged);
            // 
            // btnUpdateDetail
            // 
            this.btnUpdateDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDetail.Location = new System.Drawing.Point(527, 484);
            this.btnUpdateDetail.Name = "btnUpdateDetail";
            this.btnUpdateDetail.Size = new System.Drawing.Size(134, 65);
            this.btnUpdateDetail.TabIndex = 31;
            this.btnUpdateDetail.Text = "Update Details";
            this.btnUpdateDetail.UseVisualStyleBackColor = true;
            this.btnUpdateDetail.Click += new System.EventHandler(this.btnUpdateDetail_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_EditHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateDetail);
            this.Controls.Add(this.rbtnNonAc);
            this.Controls.Add(this.rbtnAc);
            this.Controls.Add(this.label3);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumAcRooms);
            this.Controls.Add(this.txtHotelDesc);
            this.Controls.Add(this.lblHotelDesc);
            this.Controls.Add(this.txtHotelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtHotelId);
            this.Controls.Add(this.lblHotelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin_EditHotel";
            this.Text = "Admin_EditHotel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_EditHotel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtHotelId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalRoomsVal;
        private System.Windows.Forms.Label lblCityVal;
        private System.Windows.Forms.Label lblCountryVal;
        private System.Windows.Forms.Label lblHotelIdVal;
        private System.Windows.Forms.Label lblTotalRooms;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblHotelId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHotelDesc;
        private System.Windows.Forms.Label lblHotelDesc;
        private System.Windows.Forms.TextBox txtNumNonAcRooms;
        private System.Windows.Forms.TextBox txtNumAcRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumAcRooms;
        private System.Windows.Forms.TextBox txtRateChildNonAc;
        private System.Windows.Forms.Label lblRateChildNonAc;
        private System.Windows.Forms.TextBox txtRateChildAc;
        private System.Windows.Forms.Label lblRateChildAc;
        private System.Windows.Forms.TextBox txtRateAdultNonAc;
        private System.Windows.Forms.Label lblRateAdultNonAc;
        private System.Windows.Forms.TextBox txtRateAdultAc;
        private System.Windows.Forms.Label lblRateAdultAc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnAc;
        private System.Windows.Forms.RadioButton rbtnNonAc;
        private System.Windows.Forms.Button btnUpdateDetail;
        private System.Windows.Forms.ErrorProvider erpHotelName;
        private System.Windows.Forms.ErrorProvider erpHotelDescription;
        private System.Windows.Forms.ErrorProvider erpNoAcRoom;
        private System.Windows.Forms.ErrorProvider erpNoNonAcRoom;
        private System.Windows.Forms.ErrorProvider erpRateAcAdult;
        private System.Windows.Forms.ErrorProvider erpRateAcChild;
        private System.Windows.Forms.ErrorProvider erpRateNonAcAdult;
        private System.Windows.Forms.ErrorProvider erpRateNonAcChild;
        private System.Windows.Forms.Button button1;
    }
}