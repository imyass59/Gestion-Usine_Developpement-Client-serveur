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
    public partial class ValidSaisie : Form
    {
        Database con = new Database();
        UsineDataContext dataWproduction = new UsineDataContext();
        public ValidSaisie()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction = null;
            transaction = con.db.BeginTransaction();
            try
            {
                DialogResult result = MessageBox.Show("Voulez vous Valider les Information Sasie?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    //Le transfert de tous les enregistrements de la table wproduction vers la table production. avec la procedure t2
                    SqlCommand cmd = new SqlCommand("t2", con.db)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    con.Connection();
                    cmd.ExecuteNonQuery();
                    con.Disconnection();
                    //-----------------
                    //Delete all the record from Wproduction
                    var resu = dataWproduction.wproductions.Select(x => x);
                    dataWproduction.wproductions.DeleteAllOnSubmit(resu);
                    dataWproduction.SubmitChanges();
                    transaction.Commit();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            catch
            {
                transaction.Rollback();
                MessageBox.Show("Une erreur s'est produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
