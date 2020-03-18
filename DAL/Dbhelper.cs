using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLayoutAgain.DAL
{
    class Dbhelper
    {
        SqlConnection cnn { get; set; }
        public Dbhelper(string s)
        {
            this.cnn = new SqlConnection(s);
        }

        public DataTable getTable(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query,cnn);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public void ExcuteDB(string query)
        {
            string s = @"Data Source=PC-20161209ULNU;Initial Catalog=CSDLwithC#threelayers;User ID=sa;Password=123456" ;
            cnn = new SqlConnection(s);

            SqlCommand cmd = new SqlCommand(query,cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
