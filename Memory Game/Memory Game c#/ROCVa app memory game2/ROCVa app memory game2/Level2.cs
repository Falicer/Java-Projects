using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROCVa_app_memory_game2
{

    public partial class Level2 : Form
    {
        //variables
        Random Location = new Random();
        //kiest een willekeurig plaats voor een kaart
        //List<int> X = new List<int>();
        //List<int> Y = new List<int>();
        List<Point> points = new List<Point>(); // Lijst voor de kaarten
        bool again = false; // speel nog een keer?
        int Level = 2;
        PictureBox PendingImage1; //Slaat eerste geflipte kaart op
        PictureBox PendingImage2; //Slaat tweede geflipte kaart op

        List<int> IDS = new List<int>();
        List<PictureBox> pictureboxes = new List<PictureBox>();
        
        public Level2()
        {
            
            InitializeComponent();
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            label2.Text = "2";
            timer1.Start();
            timer2.Start();
            #region afbeeldingen
            Card1.Image = Properties.Resources.Kaart1;
            DubCard1.Image = Properties.Resources.Kaart1;
            Card2.Image = Properties.Resources.Kaart2;
            DubCard2.Image = Properties.Resources.Kaart2;
            Card3.Image = Properties.Resources.Kaart3;
            DubCard3.Image = Properties.Resources.Kaart3;
            Card4.Image = Properties.Resources.Kaart4;
            DubCard4.Image = Properties.Resources.Kaart4;
            Card5.Image = Properties.Resources.Kaart5;
            DubCard5.Image = Properties.Resources.Kaart5;
            Card6.Image = Properties.Resources.Kaart6;
            DubCard6.Image = Properties.Resources.Kaart6;
            Card7.Image = Properties.Resources.Kaart7;
            DubCard7.Image = Properties.Resources.Kaart7;
            Card8.Image = Properties.Resources.Kaart8;
            DubCard8.Image = Properties.Resources.Kaart8;
            Card9.Image = Properties.Resources.Kaart9;
            DubCard9.Image = Properties.Resources.Kaart9;
            Card10.Image = Properties.Resources.Kaart10;
            DubCard10.Image = Properties.Resources.Kaart10;
            Card11.Image = Properties.Resources.Kaart11;
            DubCard11.Image = Properties.Resources.Kaart11;
            Card12.Image = Properties.Resources.Kaart12;
            DubCard12.Image = Properties.Resources.Kaart12;
            #endregion
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in cardsHolder.Controls)
            {
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.Achtergrond;
                points.Add(picture.Location);
            }
            foreach(PictureBox picture in cardsHolder.Controls)
            {
                int next = Location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;  //Geeft plaatje de locatie van Next Random
                points.Remove(p); //Zelfde locatie wordt niet meer gebruikt
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label2.Text);
            timer = timer-1;
            label2.Text = Convert.ToString(timer);
            if(timer == 0)
            {
                timer2.Stop();
                timer4.Start();
            }
        }
        #region Level Timer

        private void timer4_Tick(object sender, EventArgs e)
        {
            int timer = 0;
            int timer4 = 120 - Level * 20;

            timer = timer4 - timer;

            label2.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                
            }
        }
        #endregion
       
        //Verander de value van de kaarten op klick event
        #region Kaarten
        private void Card1_Click(object sender, EventArgs e)
        {
            Card1.Image = Properties.Resources.Kaart1;
            if(PendingImage1 == null)
            {
                PendingImage1 = Card1;
            }
            else if(PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card1;
            }
            if(PendingImage1 != null && PendingImage2 != null)
            {
                if(PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card1.Enabled = false;
                    DubCard1.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard1_Click(object sender, EventArgs e)
        {
            DubCard1.Image = Properties.Resources.Kaart1;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card1.Enabled = false;
                    DubCard1.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            Card2.Image = Properties.Resources.Kaart2;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card2.Enabled = false;
                    DubCard2.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard2_Click(object sender, EventArgs e)
        {
            DubCard2.Image = Properties.Resources.Kaart2;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card2.Enabled = false;
                    DubCard2.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            Card3.Image = Properties.Resources.Kaart3;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card3.Enabled = false;
                    DubCard3.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard3_Click(object sender, EventArgs e)
        {
            DubCard3.Image = Properties.Resources.Kaart3;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card3.Enabled = false;
                    DubCard3.Enabled = false;

                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            Card4.Image = Properties.Resources.Kaart4;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card4.Enabled = false;
                    DubCard4.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard4_Click(object sender, EventArgs e)
        {
            DubCard4.Image = Properties.Resources.Kaart4;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card4.Enabled = false;
                    DubCard4.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            Card5.Image = Properties.Resources.Kaart5;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card5.Enabled = false;
                    DubCard5.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard5_Click(object sender, EventArgs e)
        {
            DubCard5.Image = Properties.Resources.Kaart5;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card5.Enabled = false;
                    DubCard5.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            Card6.Image = Properties.Resources.Kaart6;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card6.Enabled = false;
                    DubCard6.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard6_Click(object sender, EventArgs e)
        {
            DubCard6.Image = Properties.Resources.Kaart6;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card6.Enabled = false;
                    DubCard6.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card7_Click(object sender, EventArgs e)
        {
            Card7.Image = Properties.Resources.Kaart7;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card7.Enabled = false;
                    DubCard7.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard7_Click(object sender, EventArgs e)
        {
            DubCard7.Image = Properties.Resources.Kaart7;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card7.Enabled = false;
                    DubCard7.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card8_Click(object sender, EventArgs e)
        {
            Card8.Image = Properties.Resources.Kaart8;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card8.Enabled = false;
                    DubCard8.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard8_Click(object sender, EventArgs e)
        {
            DubCard8.Image = Properties.Resources.Kaart8;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card8.Enabled = false;
                    DubCard8.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card9_Click(object sender, EventArgs e)
        {
            Card9.Image = Properties.Resources.Kaart9;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card9;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card9;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card9.Enabled = false;
                    DubCard9.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard9_Click(object sender, EventArgs e)
        {
            DubCard9.Image = Properties.Resources.Kaart9;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard9;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard9;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card9.Enabled = false;
                    DubCard9.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card10_Click(object sender, EventArgs e)
        {
            Card10.Image = Properties.Resources.Kaart10;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card10;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card10;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card10.Enabled = false;
                    DubCard10.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard10_Click(object sender, EventArgs e)
        {
            DubCard10.Image = Properties.Resources.Kaart10;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard10;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard10;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card10.Enabled = false;
                    DubCard10.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card11_Click(object sender, EventArgs e)
        {
            Card11.Image = Properties.Resources.Kaart11;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card11;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card11;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card11.Enabled = false;
                    DubCard11.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard11_Click(object sender, EventArgs e)
        {
            DubCard11.Image = Properties.Resources.Kaart11;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard11;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard11;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card11.Enabled = false;
                    DubCard11.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card12_Click(object sender, EventArgs e)
        {
            Card12.Image = Properties.Resources.Kaart12;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card12;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card12;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card12.Enabled = false;
                    DubCard12.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard12_Click(object sender, EventArgs e)
        {
            DubCard12.Image = Properties.Resources.Kaart12;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard12;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard12;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card12.Enabled = false;
                    DubCard12.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }
        #endregion

        #region Kaart Show Timer
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PendingImage1.Image = Properties.Resources.Achtergrond;
            PendingImage2.Image = Properties.Resources.Achtergrond;
            PendingImage1 = null;
            PendingImage2 = null;
        }
        #endregion

        #region Kaart Enable

        private void CardEnable()
        {
            Card1.Enabled = true;
            Card2.Enabled = true;
            Card3.Enabled = true;
            Card4.Enabled = true;
            Card5.Enabled = true;
            Card6.Enabled = true;
            Card7.Enabled = true;
            Card8.Enabled = true;
            Card9.Enabled = true;
            Card10.Enabled = true;
            Card11.Enabled = true;
            Card12.Enabled = true;
            DubCard1.Enabled = true;
            DubCard2.Enabled = true;
            DubCard3.Enabled = true;
            DubCard4.Enabled = true;
            DubCard5.Enabled = true;
            DubCard6.Enabled = true;
            DubCard7.Enabled = true;
            DubCard8.Enabled = true;
            DubCard9.Enabled = true;
            DubCard10.Enabled = true;
            DubCard11.Enabled = true;
            DubCard12.Enabled = true;
        }

        #endregion

        private void Opnieuw_Click(object sender, EventArgs e)
        {
            CardEnable();
            Level2_Load(sender, e);

        }
    }
}
