using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Traffic_Simulator
{
    public partial class Form1 : Form
    {
        int timerAddCarsCount = 0;
        

        //Shifted Rectangular Mix zone length check variables
        static int eastMixzone = 328;
        static int northMixzone = 134;
        static int westMixzone = 172;
        static int southMixzone = 366;

        //To track the cars entering/leaving the Mixzone 
        ArrayList entered= new ArrayList();
        ArrayList exited = new ArrayList();


       // int[] speedResidential=BoxMuller.BoxMuller(60,20);
       // int[] speedHighway = BoxMuller.BoxMuller(40, 10);
       // int[] speedResidential = {20,25,30,35,40,45,50,55,60};
       // int[] speedHighway = { 40, 45, 50, 55, 60, 65, 70, 75, 80 };

        int[] speedHighway = {49, 52, 57 ,61, 65, 70, 76, 81, 83, 85};
        int[] speedResidential = { 43, 51, 47, 52, 45, 41, 35, 52, 37, 31 };

        //To check traffic signals for different lanes
        static int ewSignalCheckPoint = 310;
        static int enSignalCheckPoint = 310;
        static int esSignalCheckPoint = 310;
        static int nwSignalCheckPoint = 190;
        static int nsSignalCheckPoint = 190;
        static int neSignalCheckPoint = 190;
        static int weSignalCheckPoint = 190;
        static int wnSignalCheckPoint = 190;
        static int wsSignalCheckPoint = 190;

        //Car names according to their travel paths
        string[] ENCars = { "en1", "en2", "en3" };
        string[] EWCars = { "ew1", "ew2", "ew3" };
        string[] ESCars = { "es1", "es2", "es3" };
        string[] NWCars = { "nw1", "nw2", "nw3" };
        string[] NSCars = { "ns1", "ns2", "ns3" };
        string[] NECars = { "ne1", "ne2", "ne3" };
        string[] WSCars = { "ws1", "ws2", "ws3" };
        string[] WECars = { "we1", "we2", "we3" };
        string[] WNCars = { "wn1", "wn2", "wn3" };
        string[] SECars = { "se1", "se2", "se3" };
        string[] SNCars = { "sn1", "sn2", "sn3" };
        string[] SWCars = { "sw1", "sw2", "sw3" };

        ArrayList speedResidentialPoints = new ArrayList();
        ArrayList speedHighwayPoints=new ArrayList();

        //variables used for some speed calculations
        double speedEastCar1Units = 0;
        double speedEastCar2Units = 0;
        int roundedEastCar1Units = 0;
        int roundedEastCar2Units = 0;
        
        Random r = new Random();

        //speed of the cars in the lanes
        int EWPoints, ENPoints, ESPoints;
        int NEPoints, NSPoints, NWPoints;
        int WEPoints, WSPoints, WNPoints;

        public Form1()
        {
            InitializeComponent();

            foreach (int k in speedResidential)
            {
                int speedEastCar1 = (int)speedResidential.GetValue(r.Next(0, 8));
               // int speedEastCar2 = (int)speedResidential.GetValue(r.Next(0, 8));

                double speedEastCar1PerHalfSec = (speedEastCar1 * 0.5) / 3600;
               // double speedEastCar2PerHalfSec = (speedEastCar2 * 0.5) / 3600;

                //roundedEastCar1Units = (int)Math.Round(speedEastCar1Units);
                //roundedEastCar2Units = (int)Math.Round(speedEastCar2Units);

                speedEastCar1Units = speedEastCar1PerHalfSec * 10;
               // speedEastCar2Units = speedEastCar2PerHalfSec * 10;

                roundedEastCar1Units = (int)(Math.Round(speedEastCar1Units,2)*100);

                //writeToFile(roundedEastCar1Units.ToString());
                speedResidentialPoints.Add(roundedEastCar1Units);
            }

            foreach (int k in speedHighway)
            {
               // int speedEastCar1 = (int)speedResidential.GetValue(r.Next(0, 8));
                int speedEastCar2 = (int)speedResidential.GetValue(r.Next(0, 8));

               // double speedEastCar1PerHalfSec = (speedEastCar1 * 0.5) / 3600;
                double speedEastCar2PerHalfSec = (speedEastCar2 * 0.5) / 3600;

                //roundedEastCar1Units = (int)Math.Round(speedEastCar1Units);
                //roundedEastCar2Units = (int)Math.Round(speedEastCar2Units);

               // speedEastCar1Units = speedEastCar1PerHalfSec * 10;
                speedEastCar2Units = speedEastCar2PerHalfSec * 10;

                roundedEastCar2Units = (int)(Math.Round(speedEastCar2Units, 2) * 100);
                speedHighwayPoints.Add(roundedEastCar2Units);
            }

            EWPoints = (int)speedResidentialPoints[0];
            ENPoints = (int)speedResidentialPoints[1];
            ESPoints = (int)speedResidentialPoints[2];
            NEPoints = (int)speedHighwayPoints[0];
            NWPoints = (int)speedHighwayPoints[1];
            NSPoints = (int)speedHighwayPoints[2];
            WEPoints = (int)speedResidentialPoints[0];
            WNPoints = (int)speedResidentialPoints[1];
            WSPoints = (int)speedResidentialPoints[2];
           
        }

        private void panelSignal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


           // writeToFile(panelSignal.BackColor.Name.ToString());
           // Console.WriteLine(panelSignal.BackColor.ToString());
            if (panelSignalEast.BackColor.Name.Equals("Red") && panelSignalWest.BackColor.Name.Equals("Red"))
           {
              // writeToFile(panelSignal.BackColor.Name.ToString());

               panelSignalEast.BackColor= Color.Green;
               panelSignalWest.BackColor = Color.Green;
               panelSignalNorth.BackColor = Color.Red;
               panelSignalSouth.BackColor = Color.Red;
           }
            else if (panelSignalEast.BackColor.Name.Equals("Green") && panelSignalWest.BackColor.Name.Equals("Green"))
            {
                panelSignalEast.BackColor = Color.Red;
                panelSignalWest.BackColor = Color.Red;
                panelSignalNorth.BackColor = Color.Green;
                panelSignalSouth.BackColor = Color.Green;
            }

           
               
           
        }

        private void timerCars_Tick(object sender, EventArgs e)
        {            
            
           //random cars
            foreach (Control c1 in this.Controls)
            {  foreach(Control c2 in c1.Controls)
                foreach(Control c3 in c2.Controls)
                if (c3 is Panel)
                {
                    
                    //East to North Cars         
                    if (ENCars.Contains(c3.Name))
                    {
                        updateEastNorthCar(c3);
                    }

                    //East to West Cars
                    if(EWCars.Contains(c3.Name))
                    {
                        updateEastWestCar(c3);  
                    }

                    //East to South Cars
                    if(ESCars.Contains(c3.Name))
                    {
                        updateEastSouthCar(c3);
                    }

                    //North to South Cars
                    if (NSCars.Contains(c3.Name))
                    {
                        updateNorthSouthCar(c3);   
                    }

                    //North to West Cars
                    if (NWCars.Contains(c3.Name))
                    {
                        updateNorthWestCar(c3);
                    }


                    //North to East Cars
                    if (NECars.Contains(c3.Name))
                    {
                        updateNorthEastCar(c3);
                    }

                    //West to North Cars         
                    if (WNCars.Contains(c3.Name))
                    {
                        updateWestNorthCar(c3);
                    }

                    //West to East Cars
                    if (WECars.Contains(c3.Name))
                    {
                        updateWestEastCar(c3);
                    }

                    //West to South Cars
                    if (WSCars.Contains(c3.Name))
                    {

                        updateWestSouthCar(c3);
                    }

                    }               

                }                
            }
       
       

        private void EastToNorthTurn(Control pnl)
        {
          // writeToFile("Car1 called this"); 
           int height=pnl.Size.Height;
           pnl.Height = pnl.Size.Width;
           pnl.Width = height;
        }

        private void EastToSouthTurn(Control pnl)
        {
            // writeToFile("Car1 called this"); 
            int height = pnl.Size.Height;
            pnl.Height = pnl.Size.Width;
            pnl.Width = height;
        }

        private void NorthToWestTurn(Control pnl)
        {
            // writeToFile("Car1 called this"); 
            int height = pnl.Size.Height;
            pnl.Height = pnl.Size.Width;
            pnl.Width = height;
        }
       private void NorthToEastTurn(Control pnl)
        {
            // writeToFile("Car1 called this"); 
            int height = pnl.Size.Height;
            pnl.Height = pnl.Size.Width;
            pnl.Width = height;
        }
       private void WestToNorthTurn(Control pnl)
       {
           // writeToFile("Car1 called this"); 
           int height = pnl.Size.Height;
           pnl.Height = pnl.Size.Width;
           pnl.Width = height;
       }
       private void WestToSouthTurn(Control pnl)
       {
           // writeToFile("Car1 called this"); 
           int height = pnl.Size.Height;
           pnl.Height = pnl.Size.Width;
           pnl.Width = height;
       }


        private void timerAddCars_Tick(object sender, EventArgs e)
        {
            timerAddCarsCount++;

            if (timerAddCarsCount == 2)
            {
                String pName;
                Panel p;

                pName = WECars.GetValue(0).ToString();
                p = new Panel { Name = pName, Width = 15, Height = 10, BackColor = Color.Chocolate, Location = new Point(0, 269) };
                panelRoad.Controls.Add(p);

                pName = WNCars.GetValue(0).ToString();
                p = new Panel { Name = pName, Width = 15, Height = 10, BackColor = Color.Black, Location = new Point(0, 256) };
                panelRoad.Controls.Add(p);
            }

            
            if (timerAddCarsCount==4)
            {
                String pName;
                Panel p;

                pName= EWCars.GetValue(0).ToString();
                p = new Panel { Name = pName, Width = 15, Height = 10, BackColor = Color.Yellow, Location = new Point(500, 219) };
                panelRoad.Controls.Add(p);

                pName = NSCars.GetValue(0).ToString();
                p = new Panel { Name = pName, Width = 10, Height = 15, BackColor = Color.PaleGreen, Location = new Point(219, 0) };
                panelRoad.Controls.Add(p);

                pName = ENCars.GetValue(1).ToString();
                p = new Panel { Name = pName, Width = 15, Height = 10, BackColor = Color.Teal, Location = new Point(500, 205) };
                panelRoad.Controls.Add(p);

               
               
            }
            
            if (timerAddCarsCount == 10)
            {
                String pName; 
                Panel p;
                
                pName= ESCars.GetValue(0).ToString();
                p = new Panel { Name = pName, Width = 15, Height = 10, BackColor = Color.Pink, Location = new Point(500, 232) };
                panelRoad.Controls.Add(p);

                pName = NECars.GetValue(0).ToString();
                p = new Panel { Name = pName, Width = 10, Height = 15, BackColor = Color.LightBlue, Location = new Point(232, 0) };
                panelRoad.Controls.Add(p);

                pName = EWCars.GetValue(1).ToString();
                p = new Panel { Name = pName, Width = 15, Height = 10, BackColor = Color.Maroon, Location = new Point(500, 219) };
                panelRoad.Controls.Add(p);

                pName = WSCars.GetValue(0).ToString();
                p = new Panel { Name = pName, Width = 15, Height = 10, BackColor = Color.DarkKhaki, Location = new Point(0, 282) };
                panelRoad.Controls.Add(p);

            }

            if (timerAddCarsCount == 12)
            {
                String pName;
                Panel p;
                pName= ENCars.GetValue(0).ToString();
                p = new Panel { Name = pName, Width = 15, Height = 10, BackColor = Color.Purple, Location = new Point(500, 205) };
                panelRoad.Controls.Add(p);

                pName = NWCars.GetValue(0).ToString();
                p = new Panel { Name = pName, Width = 10, Height = 15, BackColor = Color.Orange, Location = new Point(205, 0) };
                panelRoad.Controls.Add(p);

                pName = NECars.GetValue(1).ToString();
                p = new Panel { Name = pName, Width = 10, Height = 15, BackColor = Color.Brown, Location = new Point(232, 0) };
                panelRoad.Controls.Add(p);

                pName = WECars.GetValue(0).ToString();
                p = new Panel { Name = pName, Width = 15, Height = 10, BackColor = Color.Cyan, Location = new Point(0, 269) };
                panelRoad.Controls.Add(p);
            }

            if (timerAddCarsCount == 14)
            {
                String pName;
                Panel p;
                pName = NSCars.GetValue(0).ToString();
                p = new Panel { Name = pName, Width = 10, Height = 15, BackColor = Color.CornflowerBlue, Location = new Point(219, 0) };
                panelRoad.Controls.Add(p);
            }

            if (timerAddCarsCount == 16)
            {
                String pName;
                Panel p;
                pName = EWCars.GetValue(0).ToString();
                p = new Panel { Name = pName, Width = 15, Height = 10, BackColor = Color.Tomato, Location = new Point(500, 219) };
                panelRoad.Controls.Add(p);

                pName = NWCars.GetValue(1).ToString();
                p = new Panel { Name = pName, Width = 10, Height = 15, BackColor = Color.Crimson, Location = new Point(205, 0) };
                panelRoad.Controls.Add(p);
            }

            if (timerAddCarsCount == 17)
                timerAddCarsCount = 0;
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        //write to a file
        public void writeToFile(String s)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("D:\\testData7.txt", true);
            file.WriteLine(s);
            file.Close();
        }


        //update car travel paths -- 9 methods
        public void updateEastNorthCar(Control c3)
        {
            label1.Text = c3.Left.ToString();
            if (c3.Left > enSignalCheckPoint || (c3.Left <= 299 && c3.Left > 280))
                c3.Left = c3.Left - ENPoints;
            else if (c3.Left <= 280 && c3.Top <= 205)
            {
                //To change dimensions of car
                if (c3.Top == 205)
                    EastToNorthTurn(c3);

                c3.Top = c3.Top - ENPoints;
            }
            else
            {
                if (c3.Left <= enSignalCheckPoint && c3.Left >= 300)
                {
                    if (panelSignalEast.BackColor.Name.Equals("Red") && panelSignalWest.BackColor.Name.Equals("Red"))
                    {
                        c3.Left = c3.Left;
                        label1.Text = c3.Left.ToString();
                        enSignalCheckPoint = enSignalCheckPoint + 4;

                    }
                    else
                    {
                        c3.Left = c3.Left - ENPoints;
                        enSignalCheckPoint = 310;
                        // writeToFile("Green");
                    }
                }

            }

            if (c3.Left <= eastMixzone)
                if (!entered.Contains(c3.Name))
                {
                    entered.Add(c3.Name);
                    writeToFile(c3.Name.ToString() + " enters at " + labelClock.Text + " through " + "East" + (((decimal)ENPoints/500)*3600) );
                }
            if (c3.Top <= northMixzone)
                if (!exited.Contains(c3.Name))
                {
                    exited.Add(c3.Name);
                    writeToFile(c3.Name.ToString() + " exits at " + labelClock.Text + " through " + "North" + (((decimal)ENPoints / 500) * 3600));
                }
        }

        public void updateEastWestCar(Control c3)
        {
            
                        if (c3.Left > ewSignalCheckPoint || c3.Left < 300)
                            c3.Left = c3.Left - EWPoints;
                            //c3.Left = c3.Left - rECUnits;
                        else
                        {
                            if (c3.Left <= ewSignalCheckPoint && c3.Left >= 300)
                            {
                                if (panelSignalEast.BackColor.Name.Equals("Red") && panelSignalWest.BackColor.Name.Equals("Red"))
                                {
                                    c3.Left = c3.Left;
                                    ewSignalCheckPoint = ewSignalCheckPoint + 4;
                                }
                                else
                                {
                                    c3.Left = c3.Left - EWPoints;
                                    ewSignalCheckPoint = 310;
                                }
                            }
                        }

                        if (c3.Left <= eastMixzone)
                            if (!entered.Contains(c3.Name))
                            {
                                entered.Add(c3.Name);
                                writeToFile(c3.Name.ToString() + " enters at " + labelClock.Text + " through " + "East" + (((decimal)EWPoints / 500) * 3600));
                            }
                        if (c3.Left <= westMixzone)
                            if (!exited.Contains(c3.Name))
                            {
                                exited.Add(c3.Name);
                                writeToFile(c3.Name.ToString() + " exits at " + labelClock.Text + " through " + "West" + (((decimal)EWPoints / 500) * 3600));
                            }
        }


        public void updateEastSouthCar(Control c3)
        {
            if (c3.Left > esSignalCheckPoint || (c3.Left <= 299 && c3.Left > 220))
                c3.Left = c3.Left - ESPoints;
            else if (c3.Left <= 220 && c3.Top >= 232)
            {
                //To change dimensions of car
                if (c3.Top == 232)
                    EastToSouthTurn(c3);

                c3.Top = c3.Top + roundedEastCar1Units;
            }
            else
            {
                if (c3.Left <= esSignalCheckPoint && c3.Left >= 300)
                {
                    if (panelSignalEast.BackColor.Name.Equals("Red") && panelSignalWest.BackColor.Name.Equals("Red"))
                    {
                        c3.Left = c3.Left;
                        esSignalCheckPoint = esSignalCheckPoint + 4;

                        // label1.Text = panelCar1.Left.ToString();
                    }
                    else
                    {
                        c3.Left = c3.Left - ESPoints;
                        esSignalCheckPoint = 310;
                        // writeToFile("Green");
                    }
                }

            }

            if (c3.Left <= eastMixzone)
                if (!entered.Contains(c3.Name))
                {
                    entered.Add(c3.Name);
                    writeToFile(c3.Name.ToString() + " enters at " + labelClock.Text + " through " + "East" + (((decimal)ESPoints / 500) * 3600));
                }
            if (c3.Top >= southMixzone)
                if (!exited.Contains(c3.Name))
                {
                    exited.Add(c3.Name);
                    writeToFile(c3.Name.ToString() + " exits at " + labelClock.Text + " through " + "South" + (((decimal)ESPoints / 500) * 3600));
                }
        }

        public void updateNorthSouthCar(Control c3)
        {
            if (c3.Top < nsSignalCheckPoint || c3.Top > 200)
                c3.Top = c3.Top + NSPoints;
            else
            {
                if (c3.Top <= 200 && c3.Top >= nsSignalCheckPoint)
                {
                    if (panelSignalNorth.BackColor.Name.Equals("Red") && panelSignalSouth.BackColor.Name.Equals("Red"))
                    {
                        c3.Top = c3.Top;
                        nsSignalCheckPoint = nsSignalCheckPoint - 4;
                    }
                    else
                    {
                        c3.Top = c3.Top + NSPoints;
                        nsSignalCheckPoint = 190;
                    }
                }
            }

            if (c3.Top >= northMixzone)
                if (!entered.Contains(c3.Name))
                {
                    entered.Add(c3.Name);
                    writeToFile(c3.Name.ToString() + " enters at " + labelClock.Text + " through " + "North" + (((decimal)NSPoints / 500) * 3600));
                }
            if (c3.Top >= southMixzone)
                if (!exited.Contains(c3.Name))
                {   
                    exited.Add(c3.Name);
                    writeToFile(c3.Name.ToString() + " exits at " + labelClock.Text + " through " + "South" + (((decimal)NSPoints / 500) * 3600));
                }
        }

        public void updateNorthWestCar(Control c3)
        {
            if (c3.Top < nwSignalCheckPoint || (c3.Top >= 201 && c3.Top < 215))
                c3.Top = c3.Top + WNPoints;
            else if (c3.Top >= 215 && c3.Left <= 205)
            {
                //label1.Text = c3.Left.ToString();
                //MessageBox.Show(">=220");
                //To change dimensions of car
                if (c3.Left == 205)
                    NorthToWestTurn(c3);

                c3.Left = c3.Left - WNPoints;
            }
            else
            {
                if (c3.Top <= 215 && c3.Top >= nwSignalCheckPoint)
                {
                    if (panelSignalNorth.BackColor.Name.Equals("Red") && panelSignalSouth.BackColor.Name.Equals("Red"))
                    {
                        c3.Top = c3.Top;
                        // label1.Text = panelCar1.Left.ToString();
                        nwSignalCheckPoint = nwSignalCheckPoint - 4;
                    }
                    else
                    {
                        c3.Top = c3.Top + WNPoints;
                        // writeToFile("Green");
                        nwSignalCheckPoint = 190;
                    }
                }

            }

            if (c3.Top >= northMixzone)
                if (!entered.Contains(c3.Name))
                {
                    entered.Add(c3.Name);
                    writeToFile(c3.Name.ToString() + " enters at " + labelClock.Text + " through " + "North" + (((decimal)WNPoints / 500) * 3600));
                }
            if (c3.Left <= westMixzone)
                if (!exited.Contains(c3.Name))
                {
                    exited.Add(c3.Name);
                    writeToFile(c3.Name.ToString() + " exits at " + labelClock.Text + " through " + "West" + (((decimal)WNPoints / 500) * 3600));
                }
        }

        public void updateNorthEastCar(Control c3)
        {
            if (c3.Top < neSignalCheckPoint || (c3.Top >= 201 && c3.Top < 280))
                            c3.Top = c3.Top + NEPoints;
                        else if (c3.Top >= 280 && c3.Left >= 232)
                        {
                            //To change dimensions of car
                            if (c3.Left==232)
                                NorthToEastTurn(c3);

                            c3.Left = c3.Left + NEPoints;
                        }
                        else
                        {
                            if (c3.Top <= 200 && c3.Top >= neSignalCheckPoint)
                            {
                                if (panelSignalNorth.BackColor.Name.Equals("Red") && panelSignalSouth.BackColor.Name.Equals("Red"))
                                {
                                    c3.Top = c3.Top;
                                    // label1.Text = panelCar1.Left.ToString();
                                    neSignalCheckPoint = neSignalCheckPoint - 4;
                                }
                                else
                                {
                                    c3.Top = c3.Top + NEPoints;
                                    // writeToFile("Green");
                                    neSignalCheckPoint = 190;
                                }
                            }

                        }
                        
                        if (c3.Top >= northMixzone)
                            if (!entered.Contains(c3.Name))
                            {
                                entered.Add(c3.Name);
                                writeToFile(c3.Name.ToString() + " enters at " + labelClock.Text + " through " + "North" + (((decimal)NEPoints / 500) * 3600));
                            }
                        if (c3.Left >= eastMixzone)
                            if (!exited.Contains(c3.Name))
                            {
                                exited.Add(c3.Name);
                                writeToFile(c3.Name.ToString() + " exits at " + labelClock.Text + " through " + "East" + (((decimal)NEPoints / 500) * 3600));
                            }
                    }


        public void updateWestNorthCar(Control c3)
        {
            if (c3.Left < wnSignalCheckPoint || (c3.Left >= 201 && c3.Left < 280))
                c3.Left = c3.Left + WEPoints;
            else if (c3.Left >= 280 && c3.Top <= 256)
            {
                //To change dimensions of car
                if (c3.Top == 256)
                    WestToNorthTurn(c3);

                c3.Top = c3.Top - WNPoints;
            }
            else
            {
                if (c3.Left <= 200 && c3.Left >= wnSignalCheckPoint)
                {
                    if (panelSignalEast.BackColor.Name.Equals("Red") && panelSignalWest.BackColor.Name.Equals("Red"))
                    {
                        c3.Left = c3.Left;
                        // label1.Text = panelCar1.Left.ToString();
                        wnSignalCheckPoint = wnSignalCheckPoint - 4;
                    }
                    else
                    {
                        c3.Left = c3.Left + WNPoints;
                        // writeToFile("Green");
                        wnSignalCheckPoint = 190;
                    }
                }

            }

            if (c3.Left >= westMixzone)
                if (!entered.Contains(c3.Name))
                {
                    entered.Add(c3.Name);
                    writeToFile(c3.Name.ToString() + " enters at " + labelClock.Text + " through " + "West" + (((decimal)WNPoints / 500) * 3600));
                }
            if (c3.Top <= northMixzone)
                if (!exited.Contains(c3.Name))
                {
                    exited.Add(c3.Name);
                    writeToFile(c3.Name.ToString() + " exits at " + labelClock.Text + " through " + "North" + (((decimal)WNPoints / 500) * 3600));
                }
        }

        public void updateWestEastCar(Control c3)
        {
            if (c3.Left < weSignalCheckPoint || c3.Left > 200)
                c3.Left = c3.Left + WEPoints;
            else
            {
                if (c3.Left <= 200 && c3.Left >= 190)
                {
                    if (panelSignalEast.BackColor.Name.Equals("Red") && panelSignalWest.BackColor.Name.Equals("Red"))
                    {
                        c3.Left = c3.Left;
                        weSignalCheckPoint = weSignalCheckPoint - 4;
                    }
                    else
                    {
                        c3.Left = c3.Left + WEPoints;
                        weSignalCheckPoint = 190;
                    }
                }
            }

            if (c3.Left >= westMixzone)
                if (!entered.Contains(c3.Name))
                {
                    entered.Add(c3.Name);
                    writeToFile(c3.Name.ToString() + " enters at " + labelClock.Text + " through " + "West" + (((decimal)WEPoints / 500) * 3600));
                }
            if (c3.Left >= eastMixzone)
                if (!exited.Contains(c3.Name))
                {
                    exited.Add(c3.Name);
                    writeToFile(c3.Name.ToString() + " exits at " + labelClock.Text + " through " + "East" + (((decimal)WEPoints / 500) * 3600));
                }

        }

        public void updateWestSouthCar(Control c3)
        {
            if (c3.Left < wsSignalCheckPoint || (c3.Left >= 201 && c3.Left < 220))
                c3.Left = c3.Left + WSPoints;
            else if (c3.Left >= 220 && c3.Top >= 282)
            {
                //To change dimensions of car
                if (c3.Top == 282)
                    WestToSouthTurn(c3);

                c3.Top = c3.Top + WSPoints;
            }
            else
            {
                if (c3.Left <= 200 && c3.Left >= wsSignalCheckPoint)
                {
                    if (panelSignalEast.BackColor.Name.Equals("Red") && panelSignalWest.BackColor.Name.Equals("Red"))
                    {
                        c3.Left = c3.Left;
                        // label1.Text = panelCar1.Left.ToString();
                        wsSignalCheckPoint = wsSignalCheckPoint - 4;
                    }
                    else
                    {
                        c3.Left = c3.Left + WNPoints;
                        // writeToFile("Green");
                        wsSignalCheckPoint = 190;
                    }
                }

            }
            if (c3.Left >= westMixzone)
                if (!entered.Contains(c3.Name))
                {
                    entered.Add(c3.Name);
                    writeToFile(c3.Name.ToString() + " enters at " + labelClock.Text + " through " + "West" + (((decimal)WNPoints / 500) * 3600));
                }
            if (c3.Top >= southMixzone)
                if (!exited.Contains(c3.Name))
                {
                    exited.Add(c3.Name);
                    writeToFile(c3.Name.ToString() + " exits at " + labelClock.Text + " through " + "South" + (((decimal)WNPoints / 500) * 3600));
                }
        }

    }
}
