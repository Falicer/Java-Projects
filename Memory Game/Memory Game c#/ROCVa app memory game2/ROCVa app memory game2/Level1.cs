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
    public partial class Level1 : Form
    {
        //variables
        Random Location = new Random(); //kiest een willekeurig plaats voor een kaart
        List<int> X = new List<int>();
        List<int> Y = new List<int>();
        bool again = false; // speel nog een keer?
        List<int> IDS = new List<int>();
        List<PictureBox> pictureboxes = new List<PictureBox>();
        public Level1()
        {
            InitializeComponent();
        }

        private void Level1_Load(object sender, EventArgs e)
        {
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
            }
        }
        //Verander de value van de kaarten op klick event
        #region Kaarten
        private void Card1_Click(object sender, EventArgs e)
        {
            Card1.Image = Properties.Resources.Kaart1;
        }

        private void DubCard1_Click(object sender, EventArgs e)
        {
            DubCard1.Image = Properties.Resources.Kaart1;
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            Card2.Image = Properties.Resources.Kaart2;
        }

        private void DubCard2_Click(object sender, EventArgs e)
        {
            DubCard2.Image = Properties.Resources.Kaart2;
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            Card3.Image = Properties.Resources.Kaart3;
        }

        private void DubCard3_Click(object sender, EventArgs e)
        {
            DubCard3.Image = Properties.Resources.Kaart3;
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            Card4.Image = Properties.Resources.Kaart4;
        }

        private void DubCard4_Click(object sender, EventArgs e)
        {
            DubCard4.Image = Properties.Resources.Kaart4;
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            Card5.Image = Properties.Resources.Kaart5;
        }

        private void DubCard5_Click(object sender, EventArgs e)
        {
            DubCard5.Image = Properties.Resources.Kaart5;
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            Card6.Image = Properties.Resources.Kaart6;
        }

        private void DubCard6_Click(object sender, EventArgs e)
        {
            DubCard6.Image = Properties.Resources.Kaart6;
        }

        private void Card7_Click(object sender, EventArgs e)
        {
            Card7.Image = Properties.Resources.Kaart7;
        }

        private void DubCard7_Click(object sender, EventArgs e)
        {
            DubCard7.Image = Properties.Resources.Kaart7;
        }

        private void Card8_Click(object sender, EventArgs e)
        {
            Card8.Image = Properties.Resources.Kaart8;
        }

        private void DubCard8_Click(object sender, EventArgs e)
        {
            DubCard8.Image = Properties.Resources.Kaart8;
        }

        private void Card9_Click(object sender, EventArgs e)
        {
            Card9.Image = Properties.Resources.Kaart9;
        }

        private void DubCard9_Click(object sender, EventArgs e)
        {
            DubCard9.Image = Properties.Resources.Kaart9;
        }

        private void Card10_Click(object sender, EventArgs e)
        {
            Card10.Image = Properties.Resources.Kaart10;
        }

        private void DubCard10_Click(object sender, EventArgs e)
        {
            DubCard10.Image = Properties.Resources.Kaart10;
        }

        private void Card11_Click(object sender, EventArgs e)
        {
            Card11.Image = Properties.Resources.Kaart11;
        }

        private void DubCard11_Click(object sender, EventArgs e)
        {
            DubCard11.Image = Properties.Resources.Kaart11;
        }

        private void Card12_Click(object sender, EventArgs e)
        {
            Card12.Image = Properties.Resources.Kaart12;
        }

        private void DubCard12_Click(object sender, EventArgs e)
        {
            DubCard12.Image = Properties.Resources.Kaart12;
        }
        #endregion
    }
}
