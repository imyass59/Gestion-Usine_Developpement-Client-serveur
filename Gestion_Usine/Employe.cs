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
        DataEmployeDataContext dataEmploye = new DataEmployeDataContext();
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
            //var dataRow = db.ds.Tables["Employe"].AsEnumerable().Where(x => x.Field<int>("Id") == 2).FirstOrDefault();
            /*
            var result = from row in db.ds.Tables["Employe"].AsEnumerable()
                                    where row.Field<int>("Mat") == 1
                                    select row;
            */
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null;
            con.Connection();
            transaction = con.db.BeginTransaction();
            try
            {
                var result = dataEmploye.Employes.SingleOrDefault(row => row.Mat == Convert.ToInt32(textBox1.Text));
                if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text == "" || textBox5.Text != "" || maskedTextBox1.Text != "" || maskedTextBox2.Text != "")
                {
                    Employe emp = new Employe
                    {
                        Mat = int.Parse(textBox1.Text),
                        Nom = textBox2.Text.Trim(),
                        Prenom = textBox3.Text.Trim(),
                        DN = DateTime.Parse(maskedTextBox1.Text),
                        Adresse = textBox5.Text.Trim(),
                        Tel = maskedTextBox2.Text.Trim()
                    };

                    dataEmploye.Employes.InsertOnSubmit(emp);
                    dataEmploye.SubmitChanges();
                    transaction.Commit();
                    MessageBox.Show("Employé Ajouté Avec Succès", "Ajouter",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    maskedTextBox1.Text = "";
                    maskedTextBox2.Text = "";
                }
            }
            catch
            {
                transaction.Rollback();
                MessageBox.Show("Employé N'est pas Ajouté par Succès", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Disconnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                       
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Employe_Load(object sender, EventArgs e)
        {

        }
    }
}
