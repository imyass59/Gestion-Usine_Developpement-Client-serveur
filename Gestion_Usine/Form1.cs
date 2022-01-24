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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sommaireDeLaideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void employésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employe employe = new Employe();
            employe.ShowDialog();
        }

        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Article a = new Article();
            a.ShowDialog();
            
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
