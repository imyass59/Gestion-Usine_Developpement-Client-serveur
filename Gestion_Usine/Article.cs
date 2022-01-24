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
    public partial class Article : Form
    {
        public Article()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Voulez-vous que tous les champs sont vides ?", "Nouveau", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}
