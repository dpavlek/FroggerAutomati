using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Automati_Frogger
{
    public partial class Form1 : Form
    {
        int frogY = 6, frogX = 4, Score=0, HScore=0, truck1Y=5, truck1X, truck2Y=4, truck2X, leaf1Y=2, leaf1X, leaf2X, leaf2Y=1;
        bool pauza = true;
        int difficulty = 200;

        Form2 f2 = new Form2();

        Random rnd = new Random();    
        
        Image truck_slika = Image.FromFile(@"./Images/truck1.png");
        Image truck2_slika = Image.FromFile(@"./Images/truck2.png");
        Image leaf_slika = Image.FromFile(@"./Images/leaf.png");
        Image frog_slika = Image.FromFile(@"./Images/frog.png");
        Image frog_leaf = Image.FromFile(@"./Images/leaf_frog.png");

        BackgroundWorker trucks = new BackgroundWorker();

        private bool collision_check()
        {
            bool collision=false;
            if (frogX == truck1X && frogY == truck1Y)
                collision = true;
            if (frogX == truck2X && frogY == truck2Y)
                collision = true;
            if (frogY == leaf1Y && frogX != leaf1X)
                collision = true;
            if (frogY == leaf2Y && frogX != leaf2X)
                collision = true;
            return collision;
        }

        private void win_check()
        {
            if (frogY == 0)
            {
                Score++;
                frogX = 4;
                frogY = 6;
                if (Score > HScore)
                {
                    HScore = Score;
                }
                if (difficulty>0)
                difficulty-=10;                
            }

        }

        private void frog_leaf_set()
        {
            if ((frogX == leaf1X) && (frogY == leaf1Y))
                frogX--;
            else if ((frogX == leaf2X) && (frogY == leaf2Y))
                frogX++;
        }

        private void BUpdate()
        {
           Thread.Sleep(difficulty);
            frog_leaf_set();
            if (truck1X > 0)
                truck1X--;
            else if (truck1X <= 0)
                truck1X = 8;
            
            if (truck2X < 8)
                truck2X++;
            else if (truck2X >= 8)
                truck2X = 0;

            if (leaf1X > 0)
            {
                leaf1X--;
            }
            else if (leaf1X <= 0) {
                leaf1X = 8;
            }

            if (leaf2X < 8) {
                leaf2X++;
            }
            else if (leaf2X >= 8)
            {
                leaf2X = 0;
            }
                        
            Graphics_Draw();
                        
            if (collision_check())
            {
                pauza = true;               
                start_sequence();                
            }
            
        }

        private void clear_screen()
        {
            pictureBox00.Image = null;
            pictureBox01.Image = null;
            pictureBox02.Image = null;
            pictureBox03.Image = null;
            pictureBox04.Image = null;
            pictureBox05.Image = null;
            pictureBox06.Image = null;
            pictureBox07.Image = null;
            pictureBox08.Image = null;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox13.Image = null;
            pictureBox14.Image = null;
            pictureBox15.Image = null;
            pictureBox16.Image = null;
            pictureBox17.Image = null;
            pictureBox18.Image = null;
            pictureBox20.Image = null;
            pictureBox21.Image = null;
            pictureBox22.Image = null;
            pictureBox23.Image = null;
            pictureBox24.Image = null;
            pictureBox25.Image = null;
            pictureBox26.Image = null;
            pictureBox27.Image = null;
            pictureBox28.Image = null;
            pictureBox30.Image = null;
            pictureBox31.Image = null;
            pictureBox32.Image = null;
            pictureBox33.Image = null;
            pictureBox34.Image = null;
            pictureBox35.Image = null;
            pictureBox36.Image = null;
            pictureBox37.Image = null;
            pictureBox38.Image = null;
            pictureBox40.Image = null;
            pictureBox41.Image = null;
            pictureBox42.Image = null;
            pictureBox43.Image = null;
            pictureBox44.Image = null;
            pictureBox45.Image = null;
            pictureBox46.Image = null;
            pictureBox47.Image = null;
            pictureBox48.Image = null;
            pictureBox50.Image = null;
            pictureBox51.Image = null;
            pictureBox52.Image = null;
            pictureBox53.Image = null;
            pictureBox54.Image = null;
            pictureBox55.Image = null;
            pictureBox56.Image = null;
            pictureBox57.Image = null;
            pictureBox58.Image = null;
            pictureBox60.Image = null;
            pictureBox61.Image = null;
            pictureBox62.Image = null;
            pictureBox63.Image = null;
            pictureBox64.Image = null;
            pictureBox65.Image = null;
            pictureBox66.Image = null;
            pictureBox67.Image = null;
            pictureBox68.Image = null;
        }

        private void draw_frog()
        {
            if (frogY == 0 && frogX == 0)
                pictureBox00.Image = frog_slika;
            if (frogY == 0 && frogX == 1)
                pictureBox01.Image = frog_slika;
            if (frogY == 0 && frogX == 2)
                pictureBox02.Image = frog_slika;
            if (frogY == 0 && frogX == 3)
                pictureBox03.Image = frog_slika;
            if (frogY == 0 && frogX == 4)
                pictureBox04.Image = frog_slika;
            if (frogY == 0 && frogX == 5)
                pictureBox05.Image = frog_slika;
            if (frogY == 0 && frogX == 6)
                pictureBox06.Image = frog_slika;
            if (frogY == 0 && frogX == 7)
                pictureBox07.Image = frog_slika;
            if (frogY == 0 && frogX == 8)
                pictureBox08.Image = frog_slika;

            if (frogY == 1 && frogX == 0)
                pictureBox10.Image = frog_slika;
            if (frogY == 1 && frogX == 1)
                pictureBox11.Image = frog_slika;
            if (frogY == 1 && frogX == 2)
                pictureBox12.Image = frog_slika;
            if (frogY == 1 && frogX == 3)
                pictureBox13.Image = frog_slika;
            if (frogY == 1 && frogX == 4)
                pictureBox14.Image = frog_slika;
            if (frogY == 1 && frogX == 5)
                pictureBox15.Image = frog_slika;
            if (frogY == 1 && frogX == 6)
                pictureBox16.Image = frog_slika;
            if (frogY == 1 && frogX == 7)
                pictureBox17.Image = frog_slika;
            if (frogY == 1 && frogX == 8)
                pictureBox18.Image = frog_slika;

            if (frogY == 2 && frogX == 0)
                pictureBox20.Image = frog_slika;
            if (frogY == 2 && frogX == 1)
                pictureBox21.Image = frog_slika;
            if (frogY == 2 && frogX == 2)
                pictureBox22.Image = frog_slika;
            if (frogY == 2 && frogX == 3)
                pictureBox23.Image = frog_slika;
            if (frogY == 2 && frogX == 4)
                pictureBox24.Image = frog_slika;
            if (frogY == 2 && frogX == 5)
                pictureBox25.Image = frog_slika;
            if (frogY == 2 && frogX == 6)
                pictureBox26.Image = frog_slika;
            if (frogY == 2 && frogX == 7)
                pictureBox27.Image = frog_slika;
            if (frogY == 2 && frogX == 8)
                pictureBox28.Image = frog_slika;

            if (frogY == 3 && frogX == 0)
                pictureBox30.Image = frog_slika;
            if (frogY == 3 && frogX == 1)
                pictureBox31.Image = frog_slika;
            if (frogY == 3 && frogX == 2)
                pictureBox32.Image = frog_slika;
            if (frogY == 3 && frogX == 3)
                pictureBox33.Image = frog_slika;
            if (frogY == 3 && frogX == 4)
                pictureBox34.Image = frog_slika;
            if (frogY == 3 && frogX == 5)
                pictureBox35.Image = frog_slika;
            if (frogY == 3 && frogX == 6)
                pictureBox36.Image = frog_slika;
            if (frogY == 3 && frogX == 7)
                pictureBox37.Image = frog_slika;
            if (frogY == 3 && frogX == 8)
                pictureBox38.Image = frog_slika;

            if (frogY == 4 && frogX == 0)
                pictureBox40.Image = frog_slika;
            if (frogY == 4 && frogX == 1)
                pictureBox41.Image = frog_slika;
            if (frogY == 4 && frogX == 2)
                pictureBox42.Image = frog_slika;
            if (frogY == 4 && frogX == 3)
                pictureBox43.Image = frog_slika;
            if (frogY == 4 && frogX == 4)
                pictureBox44.Image = frog_slika;
            if (frogY == 4 && frogX == 5)
                pictureBox45.Image = frog_slika;
            if (frogY == 4 && frogX == 6)
                pictureBox46.Image = frog_slika;
            if (frogY == 4 && frogX == 7)
                pictureBox47.Image = frog_slika;
            if (frogY == 4 && frogX == 8)
                pictureBox48.Image = frog_slika;

            if (frogY == 5 && frogX == 0)
                pictureBox50.Image = frog_slika;
            if (frogY == 5 && frogX == 1)
                pictureBox51.Image = frog_slika;
            if (frogY == 5 && frogX == 2)
                pictureBox52.Image = frog_slika;
            if (frogY == 5 && frogX == 3)
                pictureBox53.Image = frog_slika;
            if (frogY == 5 && frogX == 4)
                pictureBox54.Image = frog_slika;
            if (frogY == 5 && frogX == 5)
                pictureBox55.Image = frog_slika;
            if (frogY == 5 && frogX == 6)
                pictureBox56.Image = frog_slika;
            if (frogY == 5 && frogX == 7)
                pictureBox57.Image = frog_slika;
            if (frogY == 5 && frogX == 8)
                pictureBox58.Image = frog_slika;

            if (frogY == 6 && frogX == 0)
                pictureBox60.Image = frog_slika;
            if (frogY == 6 && frogX == 1)
                pictureBox61.Image = frog_slika;
            if (frogY == 6 && frogX == 2)
                pictureBox62.Image = frog_slika;
            if (frogY == 6 && frogX == 3)
                pictureBox63.Image = frog_slika;
            if (frogY == 6 && frogX == 4)
                pictureBox64.Image = frog_slika;
            if (frogY == 6 && frogX == 5)
                pictureBox65.Image = frog_slika;
            if (frogY == 6 && frogX == 6)
                pictureBox66.Image = frog_slika;
            if (frogY == 6 && frogX == 7)
                pictureBox67.Image = frog_slika;
            if (frogY == 6 && frogX == 8)
                pictureBox68.Image = frog_slika;
        }

        private void Graphics_Draw()
        {
            clear_screen();
            draw_frog();
            switch (truck1X)
            {
                case (8):
                    pictureBox58.Image = truck_slika;
                    break;
                case (7):
                    pictureBox57.Image = truck_slika;
                    break;
                case (6):
                    pictureBox56.Image = truck_slika;
                    break;
                case (5):
                    pictureBox55.Image = truck_slika;
                    break;
                case (4):
                    pictureBox54.Image = truck_slika;
                    break;
                case (3):
                    pictureBox53.Image = truck_slika;
                    break;
                case (2):
                    pictureBox52.Image = truck_slika;
                    break;
                case (1):
                    pictureBox51.Image = truck_slika;
                    break;
                case (0):
                    pictureBox50.Image = truck_slika;
                    break;

            }
            switch (truck2X)
            {
                case (8):
                    pictureBox48.Image = truck2_slika;
                    break;
                case (7):
                    pictureBox47.Image = truck2_slika;
                    break;
                case (6):
                    pictureBox46.Image = truck2_slika;
                    break;
                case (5):
                    pictureBox45.Image = truck2_slika;
                    break;
                case (4):
                    pictureBox44.Image = truck2_slika;
                    break;
                case (3):
                    pictureBox43.Image = truck2_slika;
                    break;
                case (2):
                    pictureBox42.Image = truck2_slika;
                    break;
                case (1):
                    pictureBox41.Image = truck2_slika;
                    break;
                case (0):
                    pictureBox40.Image = truck2_slika;
                    break;
            }
            switch (leaf1X)
            {
                case (8):
                    pictureBox28.Image = leaf_slika;
                    break;
                case (7):
                    pictureBox27.Image = leaf_slika;
                    break;
                case (6):
                    pictureBox26.Image = leaf_slika;
                    break;
                case (5):
                    pictureBox25.Image = leaf_slika;
                    break;
                case (4):
                    pictureBox24.Image = leaf_slika;
                    break;
                case (3):
                    pictureBox23.Image = leaf_slika;
                    break;
                case (2):
                    pictureBox22.Image = leaf_slika;
                    break;
                case (1):
                    pictureBox21.Image = leaf_slika;
                    break;
                case (0):
                    pictureBox20.Image = leaf_slika;
                    break;

            }
            switch (leaf2X)
            {
                case (8):
                    pictureBox18.Image = leaf_slika;
                    break;
                case (7):
                    pictureBox17.Image = leaf_slika;
                    break;
                case (6):
                    pictureBox16.Image = leaf_slika;
                    break;
                case (5):
                    pictureBox15.Image = leaf_slika;
                    break;
                case (4):
                    pictureBox14.Image = leaf_slika;
                    break;
                case (3):
                    pictureBox13.Image = leaf_slika;
                    break;
                case (2):
                    pictureBox12.Image = leaf_slika;
                    break;
                case (1):
                    pictureBox11.Image = leaf_slika;
                    break;
                case (0):
                    pictureBox10.Image = leaf_slika;
                    break;

            }
            if ((frogY == leaf1Y)&&(frogX==leaf1X))
            {
                switch (leaf1X)
                {
                    case (8):
                        pictureBox28.Image = frog_leaf;
                        break;
                    case (7):
                        pictureBox27.Image = frog_leaf;
                        break;
                    case (6):
                        pictureBox26.Image = frog_leaf;
                        break;
                    case (5):
                        pictureBox25.Image = frog_leaf;
                        break;
                    case (4):
                        pictureBox24.Image = frog_leaf;
                        break;
                    case (3):
                        pictureBox23.Image = frog_leaf;
                        break;
                    case (2):
                        pictureBox22.Image = frog_leaf;
                        break;
                    case (1):
                        pictureBox21.Image = frog_leaf;
                        break;
                    case (0):
                        pictureBox20.Image = frog_leaf;
                        break;
                }
            }
            if ((frogY == leaf2Y)&&(frogX==leaf2X))
            {
                switch(leaf2X)
                {
                    case (8):
                        pictureBox18.Image = frog_leaf;
                        break;
                    case (7):
                        pictureBox17.Image = frog_leaf;
                        break;
                    case (6):
                        pictureBox16.Image = frog_leaf;
                        break;
                    case (5):
                        pictureBox15.Image = frog_leaf;
                        break;
                    case (4):
                        pictureBox14.Image = frog_leaf;
                        break;
                    case (3):
                        pictureBox13.Image = frog_leaf;
                        break;
                    case (2):
                        pictureBox12.Image = frog_leaf;
                        break;
                    case (1):
                        pictureBox11.Image = frog_leaf;
                        break;
                    case (0):
                        pictureBox10.Image = frog_leaf;
                        break;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            trucks.WorkerReportsProgress = true;
            trucks.WorkerSupportsCancellation = true;
            trucks.DoWork += new DoWorkEventHandler(trucks_DoWork);
            //trucks.ProgressChanged += new ProgressChangedEventHandler(trucks_ProgressChanged);
            trucks.RunWorkerCompleted += new RunWorkerCompletedEventHandler(trucks_RunWorkerCompleted);

        }

        private void trucks_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                Start_button.Enabled = true;
                Reset_button.Enabled = false;
            }
            else if (!(e.Error == null))
            {
                MessageBox.Show("Error:" + e.Error.Message);
            }
            else
            {
                MessageBox.Show("Done!");
            }
        }


        private void trucks_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while(true)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    BUpdate();
                    win_check();
                    Console.WriteLine("Frog "+ frogX + " " + frogY);
                    Console.WriteLine("L1 " + leaf1X + " " + leaf1Y);
                    Console.WriteLine("L2 " + leaf2X + " " + leaf2Y);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                            
        }
        
        private void Start_button_Click(object sender, EventArgs e)
        {
            start_sequence();
        }

        private void start_sequence()
        {
            Reset_button.Enabled = true;
            Start_button.Enabled = false;
            truck1X = rnd.Next(0, 9);
            truck2X = rnd.Next(0, 9);
            leaf1X = rnd.Next(0, 9);
            leaf2X = rnd.Next(0, 9);
            frogY = 6;
            frogX = rnd.Next(0, 9);
            Score = 0;
            difficulty = 200;
            pauza = false;
            if (trucks.IsBusy != true)
            {
                trucks.RunWorkerAsync();
            }
        }

        private void Stop_keypress(object sender, KeyPressEventArgs e)
        {
                Score_box.Text = Score.ToString();
                HScore_box.Text = HScore.ToString();
            switch (e.KeyChar)
            {
                case ('w'):
                    if (frogY>=0)
                        frogY--;
                    if (frogY < 0)
                        frogY = 0;
                    break;
                case ('a'):
                    if (frogX >=0)
                        frogX--;
                    if (frogX <0)
                        frogX = 0;
                    break;
                case ('s'):
                    if (frogY<=7)
                        frogY++;
                    if (frogY >= 7)
                        frogY = 6;
                    break;
                case ('d'):
                    if (frogX < 9)
                        frogX++;
                    if (frogX == 9)
                        frogX = 8;
                    break;
                case (char)Keys.E:
                    MessageBox.Show("button");
                    break;
                case (char)Keys.Escape:
                    pauza = true;
                    if (trucks.WorkerSupportsCancellation == true)
                    {
                        trucks.CancelAsync();
                    }
                    break;
                default:
                    MessageBox.Show("wrong key");
                    break;
            }
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {

        }

        private void Score_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_KeyDown(object sender, KeyEventArgs e)
        {
            
                
            
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            if (trucks.WorkerSupportsCancellation == true)
            {
                trucks.CancelAsync();
            }
        }

        private void Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void up_button_Click(object sender, EventArgs e)
        {
            if (frogY >= 0 && frogY < 7)
                frogY--;
        }

        private void left_button_Click(object sender, EventArgs e)
        {
            if (frogX >= 0 && frogX < 9)
            frogX--;
        }

        private void right_button_Click(object sender, EventArgs e)
        {
            if(frogX>=0 && frogX<9)
            frogX++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(frogY>=0 && frogY<7)
            frogY++;
        }
    }
}
