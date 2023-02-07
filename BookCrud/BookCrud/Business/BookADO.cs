using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace BookCrud.Business
{
    internal class BookADO
    {
        private readonly string conString = "Data Source=DESKTOP-PHRL2VS;Initial Catalog=BookDBmatrix;Integrated Security=True";
        private SqlConnection con;
        private SqlCommand cmd;

        public SqlConnection Con { get => con; set => con = value; }
        public SqlCommand Command { get => cmd; set => cmd = value; }


    public BookADO()
        {
            this.con = new SqlConnection(conString);
            this.cmd = new SqlCommand();
            this.cmd.Connection = con;
        }

        //coonect open
        public bool Connect()
        {
            if (this.con.State == ConnectionState.Closed || this.con.State == ConnectionState.Broken)
            {
                try { this.con.Open(); }
                catch { return false; }
            }
            return true;
        }

        //connect close
        public void Disconnect()
        {
            if (this.con.State == ConnectionState.Open)
            {
                this.con.Close();
            }
        }
    }
}
