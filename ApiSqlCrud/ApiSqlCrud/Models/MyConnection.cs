using System.Data;
using System.Data.SqlClient;

namespace ApiSqlCrud.Models
{
    public class MyConnection
    {
        private readonly string _connectionString = "Data Source=DESKTOP-PHRL2VS;Initial Catalog=ApiCrud;Integrated Security=True";
        public SqlConnection mySqlConnection;

        public MyConnection()
        {
            mySqlConnection = new SqlConnection(_connectionString); 
        }

        //coonect open
        public bool Connect()
        {
            if (this.mySqlConnection.State == ConnectionState.Closed || this.mySqlConnection.State == ConnectionState.Broken)
            {
                try { this.mySqlConnection.Open(); }
                catch { return false; }
            }
            return true;
        }

        //connect close
        public void Disconnect()
        {
            if (this.mySqlConnection.State == ConnectionState.Open)
            {
                this.mySqlConnection.Close();
            }
        }
    }
}
