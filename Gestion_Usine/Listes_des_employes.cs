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
    public partial class Listes_des_employes : Form
    {
        Database db = new Database();
        
        public Listes_des_employes()
        {
            InitializeComponent();
        }

        private void Listes_des_employes_Load(object sender, EventArgs e)
        {
            db.Connection();
            db.Adapter = new SqlDataAdapter("select * from employe", db.db);
            db.Set = new DataSet();
            db.Adapter.Fill(db.Set, "Employe");

            crEmployes crEmp = new crEmployes();
            crEmp.SetDataSource(db.Set.Tables["Employe"]);
            crystalReportViewer1.ReportSource = crEmp;
            crystalReportViewer1.Refresh();
            db.Disconnection();
        }
    }
}
