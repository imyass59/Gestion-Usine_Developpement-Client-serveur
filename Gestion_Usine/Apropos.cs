using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Usine
{
    public partial class Apropos : Form
    {
        public Apropos()
        {
            InitializeComponent();
        }

        // imyass
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/ilyass-elkhadiri-5a75bb228/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/imyass.exe");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/imyass59");
        }
        // Mohemad
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/mohamed-benkhayi/");
        }
        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/itsBenkhayi");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/itsBenkhayi/");
        }

        // Mehdi
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mehdi-Ch-19");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/mehdii_chi");
        }
    }
}
