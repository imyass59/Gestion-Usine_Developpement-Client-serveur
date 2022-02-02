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
    public partial class Production_par_periode : Form
    {
        Database db = new Database();
        crProduction crProd = new crProduction();
        public Production_par_periode()
        {
            InitializeComponent();
        }

        private void Production_par_periode_Load(object sender, EventArgs e)
        {
            db.Connection();
            db.Adapter = new SqlDataAdapter("select * from production", db.db);
            db.Set = new DataSet();
            db.Adapter.Fill(db.Set, "production");

            crProd.SetDataSource(db.Set.Tables["production"]);
            crystalReportViewer1.ReportSource = crProd;
            crystalReportViewer1.Refresh();
            db.Disconnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.dt.Clear();
            db.Connection();
            SqlCommand cmd = new SqlCommand("parPeriode", db.db);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@de", dateStart.Value));
            cmd.Parameters.Add(new SqlParameter("@a", dateEnd.Value));
            db.Adapter.SelectCommand = cmd;
            db.Adapter.Fill(db.dt);

            crProd.SetDataSource(db.dt);
            crystalReportViewer1.ReportSource = crProd;
            crystalReportViewer1.Refresh();
            db.Disconnection();
        }
    }
}
