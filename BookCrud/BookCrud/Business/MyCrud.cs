using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCrud.Business
{
    internal  class MyCrud
    {
        private string bookName, relaseDate, authName, authSurname, publisher, seller;
        private int? bookId, authorId, publisherId, sellerId, pages, bookAmount, sellerAmount;

        public MyCrud(int? bookId, int? authorId, int? publisherId, int? sellerId, string bookName, int? pages, string _relaseDate,
                    string authName, string authSurname, string publisher, int? bookAmount, string seller, int? sellAmount)
        {

            this.bookId = bookId;
            this.authorId = authorId;
            this.publisherId = publisherId;
            this.sellerId = sellerId;
            this.bookName = bookName;
            this.pages = pages;
            this.relaseDate = _relaseDate;
            this.authName = authName;
            this.authSurname = authSurname;
            this.publisher = publisher;
            this.seller = seller;
            this.bookAmount = bookAmount;
            this.sellerAmount = sellAmount;
        }

        public List<int> listerID(string listerType)
        {
            List<int> infoList = new List<int> { };
            DataTable da = list(listerType);

            for (int i = 0; i < da.Rows.Count; i++)
            {
                infoList.Add(Convert.ToInt32(da.Rows[i][0]));
            }

            return infoList;
        }

        public DataTable list(string commandType)
        {
            DataTable tbl = new DataTable();
            MyConnection myConnection = new MyConnection();
            myConnection.Connect();

            //SqlDataReader dr = new SqlDataReader();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandType, myConnection.connection);
            dataAdapter.Fill(tbl);
            dataAdapter.Dispose();
            //myConnection.command.CommandType = CommandType.StoredProcedure;
            //myConnection.command.CommandText = "sellect";

            //SqlParameter sqlParameter = new SqlParameter("@sellectType", sellectType);
            //myConnection.command.Parameters.AddWithValue("@sellectType", sellectType);
            //myConnection.command.Parameters.Add(sqlParameter);

            
            //myConnection.command.Parameters.Clear();
            //sqlParameter.Direction = ParameterDirection.Input;
            //myConnection.command.Parameters.Add(sqlParameter);
           
            //.Fill(tbl);
            //myConnection.da.Fill(tbl);
            myConnection.Disconnect(); 
            return tbl;
        }

        public void Add(string insertType)
        {

            MyConnection myConnection = new MyConnection();
            myConnection.Connect();

            //myConnection.command.CommandType = CommandType.StoredProcedure;
            //myConnection.command.CommandText = insertType;

            SqlCommand insertCommand = new SqlCommand(insertType, myConnection.connection);
            insertCommand.CommandType = CommandType.StoredProcedure;

            if (insertType == "insertAuthor")
            {
                //SqlParameter[] parameters = new SqlParameter[2];
                //parameters[0] = new SqlParameter("@authorName","jjj");
                //parameters[1] = new SqlParameter("@surname", authSurname);

                //myConnection.command.Parameters.AddWithValue("@authorName", authName);
                //myConnection.command.Parameters.AddWithValue("@surname", authSurname);

                insertCommand.Parameters.AddWithValue("@authorName", authName);
                insertCommand.Parameters.AddWithValue("@surname", authSurname);
                insertCommand.ExecuteNonQuery();
            }
            else if (insertType == "insertBook")
            {
               
                try
                {
                    List<int> authId = listerID("sellectAuthorId");

                    for (int i = 0; i < authId.Count; i++)
                    {
                        if (authId[i] == authorId)
                        {
                            insertCommand.Parameters.AddWithValue("@authorId", authorId);
                            insertCommand.Parameters.AddWithValue("@releaseDate", relaseDate);
                            insertCommand.Parameters.AddWithValue("@pages", pages);
                            insertCommand.Parameters.AddWithValue("@bookName", bookName);
                            break;
                        }


                    }
                    insertCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Wrong Aouthor Id" + ex.ToString());
                }
                


            }
            //using (SqlCommand sqlCommand = new SqlCommand(insertType, myConnection.connection)
            //{
            //    sqlCommand.CommandType = CommandType.StoredProcedure;

            //}
            
            insertCommand.Dispose();
            myConnection.Disconnect();
        }
    }
}
