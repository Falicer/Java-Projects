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
    public partial class Start_Menu : Form
    {
        public Start_Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Start_Knop_Click(object sender, EventArgs e)
        {
            Level1 form = new Level1();
            form.Show();
            this.Hide();
            //this.Close();

        }
    }
}
