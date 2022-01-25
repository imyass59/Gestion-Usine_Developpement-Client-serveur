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
    public partial class Employes : Form
    {
        Database con = new Database();
        UsineDataContext dataEmploye = new UsineDataContext();
        public Employes()
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
                textBox5.Text = "";
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null;
            con.Connection();
            transaction = con.db.BeginTransaction();
            try
            {
                var result = dataEmploye.Employes.SingleOrDefault(row => row.Mat == Convert.ToInt32(textBox1.Text));
                if (textBox1.Text != "" && result != null)
                {
                    MessageBox.Show("(1) Employé a été Trouvé Avec Succès", "Rechercher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Text = result.Nom.ToString();
                    textBox3.Text = result.Prenom.ToString();
                    maskedTextBox1.Text = result.DN.ToString();
                    textBox5.Text = result.Adresse.ToString();
                    maskedTextBox2.Text = result.Tel.ToString();
                    transaction.Commit();
                }
                else
                {
                    MessageBox.Show("(0) Employé a été Trouvé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                transaction.Rollback();
                MessageBox.Show("Une erreur s'est produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Disconnection();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null;
            con.Connection();
            transaction = con.db.BeginTransaction();
            try
            {
                var result = dataEmploye.Employes.SingleOrDefault(row => row.Mat == Convert.ToInt32(textBox1.Text));

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter Matricule D'un Employé", "Supprimmer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataEmploye.Employes.DeleteOnSubmit(result);
                    dataEmploye.SubmitChanges();
                    MessageBox.Show("Employé Supprimmer Avec Succès", "Supprimmer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    transaction.Commit();
                }
            }
            catch
            {
                transaction.Rollback();
                MessageBox.Show("Une erreur s'est produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Disconnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null;
            con.Connection();
            transaction = con.db.BeginTransaction();
            var result = dataEmploye.Employes.SingleOrDefault(row => row.Mat == int.Parse(textBox1.Text));
            try
            {
                Employe emp = new Employe();
                emp.Mat = int.Parse(textBox1.Text.ToString());
                emp.Nom = textBox2.Text.ToString();
                emp.Prenom = textBox3.Text.ToString();
                emp.DN = DateTime.Parse(maskedTextBox1.Text.ToString());
                emp.Adresse = textBox5.Text.ToString();
                emp.Tel = maskedTextBox2.Text.ToString();

                dataEmploye.Employes.InsertOnSubmit(emp);
                dataEmploye.SubmitChanges();
                MessageBox.Show("Employé Ajouté Avec Succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                transaction.Commit();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
            }
            catch
            {
                transaction.Rollback();
                MessageBox.Show("Une Erreur s'est Produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Disconnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null;
            con.Connection();
            transaction = con.db.BeginTransaction();
            try
            {
                var result = dataEmploye.Employes.Single(row => row.Mat == Convert.ToInt32(textBox1.Text));
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Ne modifiez pas Matricule D'un Employé", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox5.Text != "" || maskedTextBox1.Text != "" || maskedTextBox2.Text != "" || result == null)
                    {
                        result.Nom = textBox2.Text.Trim();
                        result.Prenom = textBox3.Text.Trim();
                        result.DN = DateTime.Parse(maskedTextBox1.Text);
                        result.Adresse = textBox5.Text.Trim();
                        result.Tel = maskedTextBox2.Text.Trim();
                        dataEmploye.SubmitChanges();
                        MessageBox.Show("Employé Modifier Avec Succès", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        transaction.Commit();
                    }
                }
            }
            catch
            {
                transaction.Rollback();
                MessageBox.Show("Une erreur s'est produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Disconnection();
        }

        private void Employe_Load(object sender, EventArgs e)
        {

        }
    }
}
