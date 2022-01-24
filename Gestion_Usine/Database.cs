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
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J5SB1HI;Initial Catalog=Usine;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader Reader;
        public SqlDataAdapter Adapter;
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();
        public DataRow Row;
        public SqlCommandBuilder Builder;

        public void Connection()
        {
            if (con.State.Equals(ConnectionState.Closed) || con.State.Equals(ConnectionState.Broken))
            {
                con.Open();
            }
            return;
        }

        public void Disconnection()
        {
            if (con.State.Equals(ConnectionState.Open))
            {
                con.Close();
            }
            return;
        }
    }
}
