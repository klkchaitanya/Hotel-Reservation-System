namespace PresentationLayer
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchHotels = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lnklblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.erpUserId = new System.Windows.Forms.ErrorProvider(this.components);
            this.menustripCustomer = new System.Windows.Forms.MenuStrip();
            this.efghToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEARCHHOTELSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripAdmin = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msitemAddHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.msitemEditHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.msitemDeleteHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.msitemAddAdminAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.msitemChangeProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.erpPhoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.WelcomePanel = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cANCELBOOKINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpUserId)).BeginInit();
            this.menustripCustomer.SuspendLayout();
            this.menustripAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPassword)).BeginInit();
            this.WelcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchHotels);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lnklblForgotPassword);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtUserId);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblPhoneNo);
            this.panel1.Controls.Add(this.lblUserId);
            this.panel1.Location = new System.Drawing.Point(307, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 340);
            this.panel1.TabIndex = 4;
            // 
            // btnSearchHotels
            // 
            this.btnSearchHotels.Location = new System.Drawing.Point(32, 296);
            this.btnSearchHotels.Name = "btnSearchHotels";
            this.btnSearchHotels.Size = new System.Drawing.Size(317, 41);
            this.btnSearchHotels.TabIndex = 22;
            this.btnSearchHotels.Text = "SEARCH FOR HOTELS";
            this.btnSearchHotels.UseVisualStyleBackColor = true;
            this.btnSearchHotels.Click += new System.EventHandler(this.btnSearchHotels_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.lblLogin);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 46);
            this.panel2.TabIndex = 21;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(146, 13);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(85, 24);
            this.lblLogin.TabIndex = 20;
            this.lblLogin.Text = "Login";
            // 
            // lnklblForgotPassword
            // 
            this.lnklblForgotPassword.AutoSize = true;
            this.lnklblForgotPassword.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblForgotPassword.Location = new System.Drawing.Point(193, 257);
            this.lnklblForgotPassword.Name = "lnklblForgotPassword";
            this.lnklblForgotPassword.Size = new System.Drawing.Size(102, 20);
            this.lnklblForgotPassword.TabIndex = 19;
            this.lnklblForgotPassword.TabStop = true;
            this.lnklblForgotPassword.Text = "Forgot Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(196, 194);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(91, 194);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(181, 151);
            this.txtPassword.MaxLength = 25;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(181, 112);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 15;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNumber_Validating);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(181, 76);
            this.txtUserId.MaxLength = 5;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 20);
            this.txtUserId.TabIndex = 14;
            this.txtUserId.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserId_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(76, 148);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 20);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(76, 112);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(90, 20);
            this.lblPhoneNo.TabIndex = 12;
            this.lblPhoneNo.Text = "PhoneNumber";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(76, 76);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(48, 20);
            this.lblUserId.TabIndex = 11;
            this.lblUserId.Text = "User Id";
            // 
            // erpUserId
            // 
            this.erpUserId.BlinkRate = 10;
            this.erpUserId.ContainerControl = this;
            // 
            // menustripCustomer
            // 
            this.menustripCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.efghToolStripMenuItem,
            this.sEARCHHOTELSToolStripMenuItem,
            this.cANCELBOOKINGToolStripMenuItem});
            this.menustripCustomer.Location = new System.Drawing.Point(0, 24);
            this.menustripCustomer.Name = "menustripCustomer";
            this.menustripCustomer.Size = new System.Drawing.Size(1008, 24);
            this.menustripCustomer.TabIndex = 8;
            this.menustripCustomer.Text = "menuStrip2";
            // 
            // efghToolStripMenuItem
            // 
            this.efghToolStripMenuItem.Name = "efghToolStripMenuItem";
            this.efghToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.efghToolStripMenuItem.Text = "HOME";
            // 
            // sEARCHHOTELSToolStripMenuItem
            // 
            this.sEARCHHOTELSToolStripMenuItem.Name = "sEARCHHOTELSToolStripMenuItem";
            this.sEARCHHOTELSToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.sEARCHHOTELSToolStripMenuItem.Text = "SEARCH/BOOK HOTELS";
            this.sEARCHHOTELSToolStripMenuItem.Click += new System.EventHandler(this.sEARCHHOTELSToolStripMenuItem_Click);
            // 
            // menustripAdmin
            // 
            this.menustripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.msitemAddHotel,
            this.msitemEditHotel,
            this.msitemDeleteHotel,
            this.msitemAddAdminAccount,
            this.msitemChangeProfile});
            this.menustripAdmin.Location = new System.Drawing.Point(0, 0);
            this.menustripAdmin.Name = "menustripAdmin";
            this.menustripAdmin.Size = new System.Drawing.Size(1008, 24);
            this.menustripAdmin.TabIndex = 9;
            this.menustripAdmin.Text = "menuStrip3";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.hOMEToolStripMenuItem.Text = "HOME";
            // 
            // msitemAddHotel
            // 
            this.msitemAddHotel.Name = "msitemAddHotel";
            this.msitemAddHotel.Size = new System.Drawing.Size(83, 20);
            this.msitemAddHotel.Text = "ADD HOTEL";
            this.msitemAddHotel.Click += new System.EventHandler(this.msitemAddHotel_Click);
            // 
            // msitemEditHotel
            // 
            this.msitemEditHotel.Name = "msitemEditHotel";
            this.msitemEditHotel.Size = new System.Drawing.Size(83, 20);
            this.msitemEditHotel.Text = "EDIT HOTEL";
            this.msitemEditHotel.Click += new System.EventHandler(this.msitemEditHotel_Click);
            // 
            // msitemDeleteHotel
            // 
            this.msitemDeleteHotel.Name = "msitemDeleteHotel";
            this.msitemDeleteHotel.Size = new System.Drawing.Size(98, 20);
            this.msitemDeleteHotel.Text = "DELETE HOTEL";
            this.msitemDeleteHotel.Click += new System.EventHandler(this.msitemDeleteHotel_Click);
            // 
            // msitemAddAdminAccount
            // 
            this.msitemAddAdminAccount.Name = "msitemAddAdminAccount";
            this.msitemAddAdminAccount.Size = new System.Drawing.Size(145, 20);
            this.msitemAddAdminAccount.Text = "ADD ADMIN ACCOUNT";
            this.msitemAddAdminAccount.Click += new System.EventHandler(this.msitemAddAdminAccount_Click);
            // 
            // msitemChangeProfile
            // 
            this.msitemChangeProfile.Name = "msitemChangeProfile";
            this.msitemChangeProfile.Size = new System.Drawing.Size(114, 20);
            this.msitemChangeProfile.Text = "CHANGE PROFILE";
            // 
            // erpPhoneNumber
            // 
            this.erpPhoneNumber.ContainerControl = this;
            // 
            // erpPassword
            // 
            this.erpPassword.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.WelcomePanel.Controls.Add(this.btnSignOut);
            this.WelcomePanel.Controls.Add(this.lblUserName);
            this.WelcomePanel.Controls.Add(this.label1);
            this.WelcomePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WelcomePanel.Location = new System.Drawing.Point(0, 48);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(1008, 31);
            this.WelcomePanel.TabIndex = 11;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(930, 3);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 23);
            this.btnSignOut.TabIndex = 12;
            this.btnSignOut.Text = "SIGN OUT";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserName.Location = new System.Drawing.Point(95, 8);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(45, 16);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "label2";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cANCELBOOKINGToolStripMenuItem
            // 
            this.cANCELBOOKINGToolStripMenuItem.Name = "cANCELBOOKINGToolStripMenuItem";
            this.cANCELBOOKINGToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.cANCELBOOKINGToolStripMenuItem.Text = "CANCEL BOOKING";
            this.cANCELBOOKINGToolStripMenuItem.Click += new System.EventHandler(this.cANCELBOOKINGToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.WelcomePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menustripCustomer);
            this.Controls.Add(this.menustripAdmin);
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "HotelReservationSystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpUserId)).EndInit();
            this.menustripCustomer.ResumeLayout(false);
            this.menustripCustomer.PerformLayout();
            this.menustripAdmin.ResumeLayout(false);
            this.menustripAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPassword)).EndInit();
            this.WelcomePanel.ResumeLayout(false);
            this.WelcomePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.LinkLabel lnklblForgotPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider erpUserId;
        private System.Windows.Forms.MenuStrip menustripCustomer;
        private System.Windows.Forms.ToolStripMenuItem efghToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menustripAdmin;
        private System.Windows.Forms.ToolStripMenuItem msitemAddHotel;
        private System.Windows.Forms.ErrorProvider erpPhoneNumber;
        private System.Windows.Forms.ErrorProvider erpPassword;
        private System.Windows.Forms.ToolStripMenuItem msitemEditHotel;
        private System.Windows.Forms.ToolStripMenuItem msitemDeleteHotel;
        private System.Windows.Forms.Button btnSearchHotels;
        private System.Windows.Forms.ToolStripMenuItem sEARCHHOTELSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem msitemAddAdminAccount;
        private System.Windows.Forms.Panel WelcomePanel;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.ToolStripMenuItem msitemChangeProfile;
        private System.Windows.Forms.ToolStripMenuItem cANCELBOOKINGToolStripMenuItem;


    }
}

