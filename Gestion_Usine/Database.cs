using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gestion_Usine
{
    class Database
    {
        public SqlConnection db = new SqlConnection(@"Data Source=.;Initial Catalog=Usine;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        //public SqlDataReader Reader;
        public SqlDataAdapter Adapter = new SqlDataAdapter();
        public DataSet Set = new DataSet();
        public DataTable dt = new DataTable();
        public DataRow Row;
        public SqlCommandBuilder Builder;

        public void Connection()
        {
            if (db.State.Equals(ConnectionState.Closed) || db.State.Equals(ConnectionState.Broken))
            {
                db.Open();
            }
            return;
        }

        public void Disconnection()
        {
            if (db.State.Equals(ConnectionState.Open))
            {
                db.Close();
            }
            return;
        }
    }
}
