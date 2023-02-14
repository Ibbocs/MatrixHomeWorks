using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrud.Business
{
    internal class MyConnection
    {
        private readonly string conString = "Data Source=DESKTOP-PHRL2VS;Initial Catalog=BookDBmatrix;Integrated Security=True";
        public SqlConnection connection;

        public SqlCommand command;
        public SqlDataAdapter da;

        public MyConnection()
        {
            connection = new SqlConnection(conString);
            command= new SqlCommand(conString);
            da = new SqlDataAdapter();
        }

        //coonect open
        public bool Connect()
        {
            if (this.connection.State == ConnectionState.Closed || this.connection.State == ConnectionState.Broken)
            {
                try { this.connection.Open(); }
                catch { return false; }
            }
            return true;
        }

        //connect close
        public void Disconnect()
        {
            if (this.connection.State == ConnectionState.Open)
            {
                this.connection.Close();
            }
        }
    }
}
