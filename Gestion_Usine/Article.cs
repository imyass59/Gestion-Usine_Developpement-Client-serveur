using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_Usine
{
    public partial class Article : Form
    {
        Database db = new Database();
        SqlDataAdapter ad = new SqlDataAdapter();
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
                CA.Text = "";
                Stock.Text = "";
                Designation.Text = "";
                Prix.Text = "";
            }
        }

        private void Article_Load(object sender, EventArgs e)
        {
            db.Connection();
            db.cmd.CommandText = "SELECT * FROM article";
            db.cmd.Connection = db.db;
            ad.SelectCommand = db.cmd;
            ad.Fill(db.Set, "Article");
        }
        public int Rechercher(int id)
        {
            int exist = 0;
            for (var i = 0; i < db.Set.Tables["Article"].Rows.Count; i++)
            {
                if (int.Parse(db.Set.Tables["Article"].Rows[i][0].ToString()) == id)
                {
                    exist = 1;
                }

            }
            return exist;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CA.Text == "" || Designation.Text == "" || Stock.Text == "" || Prix.Text == "")
            {
                MessageBox.Show("Please Fill All The Filds ");
                return;
            }
            if (Rechercher(int.Parse(CA.Text.ToString())) == 0)
            {
                db.Row = db.Set.Tables["Article"].NewRow();
                db.Row[0] = int.Parse(CA.Text.ToString());
                db.Row[1] = Designation.Text;
                db.Row[2] = float.Parse(Prix.Text.ToString());
                db.Row[3] = int.Parse(Stock.Text.ToString());
                db.Set.Tables["Article"].Rows.Add(db.Row);
                MessageBox.Show("Successfully Added ");
            }
            else
            {
                MessageBox.Show("Aleardy Exists ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool succes = false;
            for (var i = 0; i < db.Set.Tables["Article"].Rows.Count; i++)
            {
                if (int.Parse(db.Set.Tables["Article"].Rows[i][0].ToString()) == int.Parse(CA.Text.ToString()))
                {
                    db.Set.Tables["Article"].Rows[i].Delete();
                    succes = true;
                    break;
                }

            }
            if (succes == false)
            {
                MessageBox.Show("Product Aleardy Exists ");
            }
            else
            {
                MessageBox.Show("Successfully Deleted  ");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder Cb = new SqlCommandBuilder(ad);
            ad.Update(db.Set, "Article");
            MessageBox.Show("Successfully Saved  ");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool success = false;
            for (var i = 0; i < db.Set.Tables["Article"].Rows.Count; i++)
            {
                if (int.Parse(db.Set.Tables["Article"].Rows[i][0].ToString()) == int.Parse(CA.Text.ToString()))
                {
                    db.Set.Tables["Article"].Rows[i][1] = Designation.Text;
                    db.Set.Tables["Article"].Rows[i][2] = Prix.Text;
                    db.Set.Tables["Article"].Rows[i][3] = Stock.Text;
                    success = true;
                    break;

                }

            }
            if (success == false)
            {
                MessageBox.Show("Product Dos not Exists ");
            }
            else
            {
                MessageBox.Show("Successfully Updated ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool successs = false;
            for (var i = 0; i < db.Set.Tables["Article"].Rows.Count; i++)
            {
                if (int.Parse(db.Set.Tables["Article"].Rows[i][0].ToString()) == int.Parse(CA.Text.ToString()))
                {
                    Designation.Text = db.Set.Tables["Article"].Rows[i][1].ToString();
                    Prix.Text = db.Set.Tables["Article"].Rows[i][2].ToString();
                    Stock.Text = db.Set.Tables["Article"].Rows[i][3].ToString();
                    successs = true;
                    break;

                }

            }
            if (successs == false)
            {
                MessageBox.Show("Product Dos not Exists ");
            }
        }
    }
}
