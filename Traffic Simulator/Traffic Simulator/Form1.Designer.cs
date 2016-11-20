namespace Traffic_Simulator
{
    partial class Form1
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
            this.timerSignals = new System.Windows.Forms.Timer(this.components);
            this.timerCars = new System.Windows.Forms.Timer(this.components);
            this.timerAddCars = new System.Windows.Forms.Timer(this.components);
            this.panelRoad = new System.Windows.Forms.Panel();
            this.panelSignalSouth = new System.Windows.Forms.Panel();
            this.panelLawn4 = new System.Windows.Forms.Panel();
            this.labelLawnSouth2 = new System.Windows.Forms.Label();
            this.labelLawnEast2 = new System.Windows.Forms.Label();
            this.panelLawn3 = new System.Windows.Forms.Panel();
            this.labelLawnSouth1 = new System.Windows.Forms.Label();
            this.labelLawnWest2 = new System.Windows.Forms.Label();
            this.panelLawn2 = new System.Windows.Forms.Panel();
            this.labelClock = new System.Windows.Forms.Label();
            this.labelLawnNorth2 = new System.Windows.Forms.Label();
            this.labelLawnEast1 = new System.Windows.Forms.Label();
            this.panelLawn1 = new System.Windows.Forms.Panel();
            this.labelLawnNorth1 = new System.Windows.Forms.Label();
            this.labelLawnWest1 = new System.Windows.Forms.Label();
            this.labelRoadEast = new System.Windows.Forms.Label();
            this.labelWestRoadLines = new System.Windows.Forms.Label();
            this.panelSignalEast = new System.Windows.Forms.Panel();
            this.panelSignalNorth = new System.Windows.Forms.Panel();
            this.panelSignalWest = new System.Windows.Forms.Panel();
            this.panelSignal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panelRoad.SuspendLayout();
            this.panelLawn4.SuspendLayout();
            this.panelLawn3.SuspendLayout();
            this.panelLawn2.SuspendLayout();
            this.panelLawn1.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerSignals
            // 
            this.timerSignals.Enabled = true;
            this.timerSignals.Interval = 20000;
            this.timerSignals.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerCars
            // 
            this.timerCars.Enabled = true;
            this.timerCars.Interval = 500;
            this.timerCars.Tick += new System.EventHandler(this.timerCars_Tick);
            // 
            // timerAddCars
            // 
            this.timerAddCars.Enabled = true;
            this.timerAddCars.Interval = 1000;
            this.timerAddCars.Tick += new System.EventHandler(this.timerAddCars_Tick);
            // 
            // panelRoad
            // 
            this.panelRoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelRoad.Controls.Add(this.panelSignalSouth);
            this.panelRoad.Controls.Add(this.panelLawn4);
            this.panelRoad.Controls.Add(this.panelLawn3);
            this.panelRoad.Controls.Add(this.panelLawn2);
            this.panelRoad.Controls.Add(this.panelLawn1);
            this.panelRoad.Controls.Add(this.labelRoadEast);
            this.panelRoad.Controls.Add(this.labelWestRoadLines);
            this.panelRoad.Controls.Add(this.panelSignalEast);
            this.panelRoad.Controls.Add(this.panelSignalNorth);
            this.panelRoad.Controls.Add(this.panelSignalWest);
            this.panelRoad.Controls.Add(this.panelSignal);
            this.panelRoad.Location = new System.Drawing.Point(0, 0);
            this.panelRoad.Name = "panelRoad";
            this.panelRoad.Size = new System.Drawing.Size(500, 500);
            this.panelRoad.TabIndex = 0;
            // 
            // panelSignalSouth
            // 
            this.panelSignalSouth.BackColor = System.Drawing.Color.Red;
            this.panelSignalSouth.Location = new System.Drawing.Point(244, 254);
            this.panelSignalSouth.Name = "panelSignalSouth";
            this.panelSignalSouth.Size = new System.Drawing.Size(12, 12);
            this.panelSignalSouth.TabIndex = 12;
            // 
            // panelLawn4
            // 
            this.panelLawn4.BackColor = System.Drawing.Color.LawnGreen;
            this.panelLawn4.Controls.Add(this.labelLawnSouth2);
            this.panelLawn4.Controls.Add(this.labelLawnEast2);
            this.panelLawn4.Location = new System.Drawing.Point(300, 300);
            this.panelLawn4.Name = "panelLawn4";
            this.panelLawn4.Size = new System.Drawing.Size(200, 200);
            this.panelLawn4.TabIndex = 11;
            // 
            // labelLawnSouth2
            // 
            this.labelLawnSouth2.AutoSize = true;
            this.labelLawnSouth2.Location = new System.Drawing.Point(3, 97);
            this.labelLawnSouth2.Name = "labelLawnSouth2";
            this.labelLawnSouth2.Size = new System.Drawing.Size(39, 13);
            this.labelLawnSouth2.TabIndex = 2;
            this.labelLawnSouth2.Text = "1 miles";
            // 
            // labelLawnEast2
            // 
            this.labelLawnEast2.AutoSize = true;
            this.labelLawnEast2.Location = new System.Drawing.Point(85, 3);
            this.labelLawnEast2.Name = "labelLawnEast2";
            this.labelLawnEast2.Size = new System.Drawing.Size(39, 13);
            this.labelLawnEast2.TabIndex = 1;
            this.labelLawnEast2.Text = "1 miles";
            // 
            // panelLawn3
            // 
            this.panelLawn3.BackColor = System.Drawing.Color.LawnGreen;
            this.panelLawn3.Controls.Add(this.labelLawnSouth1);
            this.panelLawn3.Controls.Add(this.labelLawnWest2);
            this.panelLawn3.Location = new System.Drawing.Point(0, 300);
            this.panelLawn3.Name = "panelLawn3";
            this.panelLawn3.Size = new System.Drawing.Size(200, 200);
            this.panelLawn3.TabIndex = 10;
            // 
            // labelLawnSouth1
            // 
            this.labelLawnSouth1.AutoSize = true;
            this.labelLawnSouth1.Location = new System.Drawing.Point(153, 97);
            this.labelLawnSouth1.Name = "labelLawnSouth1";
            this.labelLawnSouth1.Size = new System.Drawing.Size(39, 13);
            this.labelLawnSouth1.TabIndex = 2;
            this.labelLawnSouth1.Text = "1 miles";
            // 
            // labelLawnWest2
            // 
            this.labelLawnWest2.AutoSize = true;
            this.labelLawnWest2.Location = new System.Drawing.Point(71, 0);
            this.labelLawnWest2.Name = "labelLawnWest2";
            this.labelLawnWest2.Size = new System.Drawing.Size(39, 13);
            this.labelLawnWest2.TabIndex = 1;
            this.labelLawnWest2.Text = "1 miles";
            // 
            // panelLawn2
            // 
            this.panelLawn2.BackColor = System.Drawing.Color.LawnGreen;
            this.panelLawn2.Controls.Add(this.labelClock);
            this.panelLawn2.Controls.Add(this.labelLawnNorth2);
            this.panelLawn2.Controls.Add(this.labelLawnEast1);
            this.panelLawn2.Location = new System.Drawing.Point(300, 0);
            this.panelLawn2.Name = "panelLawn2";
            this.panelLawn2.Size = new System.Drawing.Size(200, 200);
            this.panelLawn2.TabIndex = 9;
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Location = new System.Drawing.Point(88, 14);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(35, 13);
            this.labelClock.TabIndex = 2;
            this.labelClock.Text = "label2";
            // 
            // labelLawnNorth2
            // 
            this.labelLawnNorth2.AutoSize = true;
            this.labelLawnNorth2.Location = new System.Drawing.Point(1, 82);
            this.labelLawnNorth2.Name = "labelLawnNorth2";
            this.labelLawnNorth2.Size = new System.Drawing.Size(39, 13);
            this.labelLawnNorth2.TabIndex = 1;
            this.labelLawnNorth2.Text = "1 miles";
            // 
            // labelLawnEast1
            // 
            this.labelLawnEast1.AutoSize = true;
            this.labelLawnEast1.Location = new System.Drawing.Point(86, 186);
            this.labelLawnEast1.Name = "labelLawnEast1";
            this.labelLawnEast1.Size = new System.Drawing.Size(39, 13);
            this.labelLawnEast1.TabIndex = 1;
            this.labelLawnEast1.Text = "1 miles";
            // 
            // panelLawn1
            // 
            this.panelLawn1.BackColor = System.Drawing.Color.LawnGreen;
            this.panelLawn1.Controls.Add(this.labelLawnNorth1);
            this.panelLawn1.Controls.Add(this.labelLawnWest1);
            this.panelLawn1.Location = new System.Drawing.Point(1, 2);
            this.panelLawn1.Name = "panelLawn1";
            this.panelLawn1.Size = new System.Drawing.Size(200, 200);
            this.panelLawn1.TabIndex = 8;
            // 
            // labelLawnNorth1
            // 
            this.labelLawnNorth1.AutoSize = true;
            this.labelLawnNorth1.Location = new System.Drawing.Point(153, 80);
            this.labelLawnNorth1.Name = "labelLawnNorth1";
            this.labelLawnNorth1.Size = new System.Drawing.Size(39, 13);
            this.labelLawnNorth1.TabIndex = 2;
            this.labelLawnNorth1.Text = "1 miles";
            // 
            // labelLawnWest1
            // 
            this.labelLawnWest1.AutoSize = true;
            this.labelLawnWest1.Location = new System.Drawing.Point(70, 187);
            this.labelLawnWest1.Name = "labelLawnWest1";
            this.labelLawnWest1.Size = new System.Drawing.Size(39, 13);
            this.labelLawnWest1.TabIndex = 0;
            this.labelLawnWest1.Text = "1 miles";
            // 
            // labelRoadEast
            // 
            this.labelRoadEast.AutoSize = true;
            this.labelRoadEast.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRoadEast.Location = new System.Drawing.Point(313, 244);
            this.labelRoadEast.Name = "labelRoadEast";
            this.labelRoadEast.Size = new System.Drawing.Size(187, 13);
            this.labelRoadEast.TabIndex = 7;
            this.labelRoadEast.Text = "------------------------------------------------------------";
            // 
            // labelWestRoadLines
            // 
            this.labelWestRoadLines.AutoSize = true;
            this.labelWestRoadLines.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWestRoadLines.Location = new System.Drawing.Point(0, 244);
            this.labelWestRoadLines.Name = "labelWestRoadLines";
            this.labelWestRoadLines.Size = new System.Drawing.Size(187, 13);
            this.labelWestRoadLines.TabIndex = 6;
            this.labelWestRoadLines.Text = "------------------------------------------------------------";
            // 
            // panelSignalEast
            // 
            this.panelSignalEast.BackColor = System.Drawing.Color.Green;
            this.panelSignalEast.Location = new System.Drawing.Point(254, 245);
            this.panelSignalEast.Name = "panelSignalEast";
            this.panelSignalEast.Size = new System.Drawing.Size(12, 12);
            this.panelSignalEast.TabIndex = 5;
            // 
            // panelSignalNorth
            // 
            this.panelSignalNorth.BackColor = System.Drawing.Color.Red;
            this.panelSignalNorth.Location = new System.Drawing.Point(244, 235);
            this.panelSignalNorth.Name = "panelSignalNorth";
            this.panelSignalNorth.Size = new System.Drawing.Size(12, 12);
            this.panelSignalNorth.TabIndex = 4;
            // 
            // panelSignalWest
            // 
            this.panelSignalWest.BackColor = System.Drawing.Color.Green;
            this.panelSignalWest.Location = new System.Drawing.Point(236, 244);
            this.panelSignalWest.Name = "panelSignalWest";
            this.panelSignalWest.Size = new System.Drawing.Size(12, 12);
            this.panelSignalWest.TabIndex = 3;
            // 
            // panelSignal
            // 
            this.panelSignal.BackColor = System.Drawing.Color.Yellow;
            this.panelSignal.Location = new System.Drawing.Point(240, 240);
            this.panelSignal.Name = "panelSignal";
            this.panelSignal.Size = new System.Drawing.Size(20, 20);
            this.panelSignal.TabIndex = 0;
            this.panelSignal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSignal_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.LawnGreen;
            this.panelBackground.Controls.Add(this.label1);
            this.panelBackground.Controls.Add(this.panelRoad);
            this.panelBackground.Location = new System.Drawing.Point(-1, -1);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(500, 500);
            this.panelBackground.TabIndex = 0;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 498);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Traffic Simulator";
            this.panelRoad.ResumeLayout(false);
            this.panelRoad.PerformLayout();
            this.panelLawn4.ResumeLayout(false);
            this.panelLawn4.PerformLayout();
            this.panelLawn3.ResumeLayout(false);
            this.panelLawn3.PerformLayout();
            this.panelLawn2.ResumeLayout(false);
            this.panelLawn2.PerformLayout();
            this.panelLawn1.ResumeLayout(false);
            this.panelLawn1.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerSignals;
        private System.Windows.Forms.Timer timerCars;
        private System.Windows.Forms.Timer timerAddCars;
        private System.Windows.Forms.Panel panelRoad;
        private System.Windows.Forms.Panel panelSignalSouth;
        private System.Windows.Forms.Panel panelLawn4;
        private System.Windows.Forms.Label labelLawnSouth2;
        private System.Windows.Forms.Label labelLawnEast2;
        private System.Windows.Forms.Panel panelLawn3;
        private System.Windows.Forms.Label labelLawnSouth1;
        private System.Windows.Forms.Label labelLawnWest2;
        private System.Windows.Forms.Panel panelLawn2;
        private System.Windows.Forms.Label labelLawnNorth2;
        private System.Windows.Forms.Label labelLawnEast1;
        private System.Windows.Forms.Panel panelLawn1;
        private System.Windows.Forms.Label labelLawnNorth1;
        private System.Windows.Forms.Label labelLawnWest1;
        private System.Windows.Forms.Label labelRoadEast;
        private System.Windows.Forms.Label labelWestRoadLines;
        private System.Windows.Forms.Panel panelSignalEast;
        private System.Windows.Forms.Panel panelSignalNorth;
        private System.Windows.Forms.Panel panelSignalWest;
        private System.Windows.Forms.Panel panelSignal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Timer timerClock;
    }
}

