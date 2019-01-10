using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmGiris
{
    class SqlHelper
    {
        private string ConnectionString { get; set; }
        private SqlConnection connection { get; set; }
        public SqlHelper()
        {
            ConnectionString= @"Data Source=DICLE\DICLEDEMIR; Initial Catalog=Company;  Trusted_Connection=true;  User Id = Dicle;";
            connection = new SqlConnection(ConnectionString);
        }
        public int ExecuteCommand(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            int exe = command.ExecuteNonQuery();
            connection.Close();
            return exe;
        }
        public DataTable GetTable (string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public void ExecuteProc(string ProcName, params SqlParameter[] p)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = ProcName;
            command.Parameters.AddRange(p);
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void ExecuteProc(string ProcName,SqlParameter p)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = ProcName;
            command.Parameters.Add(p);
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
