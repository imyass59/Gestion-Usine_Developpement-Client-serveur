using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Usine
{
    public partial class Article : Form
    {
        Database con = new Database();
        public Article()
        {
            InitializeComponent();
        }

        private void Article_Load(object sender, EventArgs e)
        {
            con.Connection();
            GetTables();
            con.Disconnection();
        }

        private void GetTables()
        {
            if (con.Set.Tables["Article"] != null)
            {
                con.Set.Tables["Article"].Clear();
            }
            con.Adapter = new SqlDataAdapter("select * from Article", con.db);
            con.Adapter.Fill(con.Set, "Article");
        }

        public int Rechercher(int id)
        {
            int exist = 0;
            for (var i = 0; i < con.Set.Tables["Article"].Rows.Count; i++)
            {
                if(int.Parse(con.Set.Tables["Article"].Rows[i][0].ToString()) == id)
                {
                    exist = 1;
                }

            }
            return exist;
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
                textBox5.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(Rechercher(int.Parse(textBox1.Text)) != 1)
                {
                    con.Row = con.Set.Tables["Article"].NewRow();
                    con.Row[0] = int.Parse(textBox1.Text.Trim());
                    con.Row[1] = textBox5.Text;
                    con.Row[2] = float.Parse(textBox2.Text.Trim());
                    con.Row[3] = int.Parse(textBox3.Text.Trim());
                    con.Set.Tables["Article"].Rows.Add(con.Row);
                    MessageBox.Show("Article Ajouté Avec Succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    MessageBox.Show("Une Erreur s'est Produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Une Erreur s'est Produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                for (var i = 0; i < con.Set.Tables["Article"].Rows.Count; i++)
                {
                    if (int.Parse(con.Set.Tables["Article"].Rows[i][0].ToString()) == int.Parse(textBox1.Text.ToString()))
                    {
                        con.Set.Tables["Article"].Rows[i].Delete();
                        MessageBox.Show("Article Supprimmer Avec Succès", "Supprimmer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Une Erreur s'est Produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Êtes-vous sûr d'avoir Enregistré les Modifications ?", "Enregistrer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                try
                {
                    con.Builder = new SqlCommandBuilder(con.Adapter);
                    con.Adapter.Update(con.Set, "Article");
                }
                catch
                {
                    MessageBox.Show("Une Erreur s'est Produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bool successs = false;
                for (var i = 0; i < con.Set.Tables["Article"].Rows.Count; i++)
                {
                    if (int.Parse(con.Set.Tables["Article"].Rows[i][0].ToString()) == int.Parse(textBox1.Text.ToString()))
                    {
                        textBox5.Text = con.Set.Tables["Article"].Rows[i][1].ToString();
                        textBox2.Text = con.Set.Tables["Article"].Rows[i][2].ToString();
                        textBox3.Text = con.Set.Tables["Article"].Rows[i][3].ToString();
                        successs = true;
                        break;
                    }

                }
                if (successs == false)
                {
                    MessageBox.Show("Une Erreur s'est Produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("(1) Article a été Trouvé Avec Succès", "Rechercher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Une Erreur s'est Produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = false;
                for (var i = 0; i < con.Set.Tables["Article"].Rows.Count; i++)
                {
                    if (int.Parse(con.Set.Tables["Article"].Rows[i][0].ToString()) == int.Parse(textBox1.Text.ToString()))
                    {
                        con.Set.Tables["Article"].Rows[i][1] = textBox5.Text;
                        con.Set.Tables["Article"].Rows[i][2] = float.Parse(textBox2.Text);
                        con.Set.Tables["Article"].Rows[i][3] = int.Parse(textBox3.Text);
                        success = true;
                        break;
                    }

                }
                if (success == false)
                {
                    MessageBox.Show("Une Erreur s'est Produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Article Modifier Avec Succès", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Une Erreur s'est Produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
