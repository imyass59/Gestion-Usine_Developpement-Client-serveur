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
    public partial class Consultation : Form
    {
        Database con = new Database();
        UsineDataContext dataProduction = new UsineDataContext();
        public Consultation()
        {
            InitializeComponent();
        }

        private void Consultation_Load(object sender, EventArgs e)
        {
            Refrech();
        }

        private void Refrech()
        {
            var result = (from rows in dataProduction.Productions select rows).ToList();
            bunifuCustomDataGrid1.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Refrech();
                return;
            }
            catch
            {
                MessageBox.Show("Une erreur s'est produite. Veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
