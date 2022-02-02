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
    public partial class Saisie : Form
    {
        Database con = new Database();
        UsineDataContext dataWproduction = new UsineDataContext();
        public Saisie()
        {
            InitializeComponent();
        }

        private void Saisie_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            comboBox2.DataSource = dataWproduction.Employes.Select(x => new { mat = x.Mat }).ToList();
            comboBox2.DisplayMember = "Mat";
            comboBox2.ValueMember = "Mat";

            comboBox3.DataSource = dataWproduction.Articles.Select(x => new { Codea = x.codea }).ToList();
            comboBox3.DisplayMember = "codea";
            comboBox3.ValueMember = "codea";

            
            check();
        }



        public void WpRemplir()
        {
            try
            {
                dataWproduction.wproductions.First(x => x.Num == int.Parse(textBox3.Text));
                dataWproduction.Productions.First(x => x.Num == int.Parse(textBox3.Text));
                MessageBox.Show("Une erreur s'est produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch
            {
                SqlCommand cmd = new SqlCommand("WproInsert", con.db)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@num_prod", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@date_production", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@mat", int.Parse(comboBox2.Text));
                cmd.Parameters.AddWithValue("@Np", textBox2.Text);
                cmd.Parameters.AddWithValue("@code_a", int.Parse(comboBox3.Text));
                cmd.Parameters.AddWithValue("@Desig", textBox5.Text);
                cmd.Parameters.AddWithValue("@qp", int.Parse(textBox1.Text));
                con.Connection();
                cmd.ExecuteNonQuery();
                con.Disconnection();
                MessageBox.Show("Production Généré Avec Succès", "Générer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void check()
        {
            var result = dataWproduction.wproductions.Select(x => x);

            if(result.Count() > 0)
            {
                bunifuProgressBar1.BackColor = Color.FromArgb(255, 36, 66);
            }
            else
            {
                bunifuProgressBar1.BackColor = Color.FromArgb(78, 159, 61);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var result = dataWproduction.wproductions.Select(x => x);
                if (result.Count() > 0)
                {
                    //Afficher un message d’avertissement lorsque la table n’est pas vide avec une possibilité d’abandon de l’opération.
                    DialogResult d = MessageBox.Show("Il y a encore des informations dans la Base, Voulez-vous terminer l'opération ?", "Danger", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (d == DialogResult.Yes)
                    {
                        //Suppression de tout le contenu de la table wproduction
                        dataWproduction.wproductions.DeleteAllOnSubmit(result);
                        dataWproduction.SubmitChanges();
                        WpRemplir();
                        check();
                    }
                    else if (d == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    WpRemplir();
                    check();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Une erreur s'est produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
