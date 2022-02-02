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
    public partial class Liste_des_articles : Form
    {
        Database db = new Database();
        public Liste_des_articles()
        {
            InitializeComponent();
        }

        private void Liste_des_articles_Load(object sender, EventArgs e)
        {
            db.Connection();
            db.Adapter = new SqlDataAdapter("select * from article", db.db);
            db.Set = new DataSet();
            db.Adapter.Fill(db.Set, "article");

            crArticles crArt = new crArticles();
            crArt.SetDataSource(db.Set.Tables["article"]);
            crystalReportViewer1.ReportSource = crArt;
            crystalReportViewer1.Refresh();
            db.Disconnection();
        }
    }
}
