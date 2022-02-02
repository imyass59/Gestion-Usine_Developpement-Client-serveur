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
using System.Data;

namespace Gestion_Usine
{
    public partial class Histogramme : Form
    {
        Database db = new Database();
        public Histogramme()
        {
            InitializeComponent();
        }

        private void Histogramme_Load(object sender, EventArgs e)
        {
            db.dt.Clear();
            db.Connection();
            SqlCommand cmd = new SqlCommand("fillHistogram", db.db);
            cmd.CommandType = CommandType.StoredProcedure;
            db.Adapter.SelectCommand = cmd;
            db.Adapter.Fill(db.dt);

            crHistogram crHist = new crHistogram();
            crHist.SetDataSource(db.dt);
            crystalReportViewer1.ReportSource = crHist;
            crystalReportViewer1.Refresh();
            db.Disconnection();
        }
    }
}
