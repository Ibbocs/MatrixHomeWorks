using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrud.Business
{
    internal class Book
    {
        private string bookName, year, authName, authSurname, publisher, seller;
        private int bookId, authorId, publisherId, sellerId, pages, bookAmount, sellerAmount;

        public Book(int bookId, int authorId, int publisherId, int sellerId, string bookName, int pages, string year,
                    string authName, string authSurname, string publisher, int bookAmount, string seller, int sellAmount) 
        {
        
            this.bookId = bookId;
            this.authorId = authorId;
            this.publisherId = publisherId;
            this.sellerId = sellerId;
            this.bookName = bookName;
            this.pages = pages;
            this.year = year;
            this.authName = authName;
            this.authSurname= authSurname;
            this.publisher = publisher;
            this.seller = seller;
            this.bookAmount = bookAmount;
            this.sellerAmount = sellAmount;
        }

        //public void BookSellect(int type, BookADO db) 
        //{
        //    if (type == 1)
        //    {
        //        this.ExecuteProcedure(db, "sellect", 1);

        //    }
        //}

        public void AddStudent(BookADO db)
        {
            this.ExecuteProcedure(db, "InsertProcedure");
        }

        private void ExecuteProcedure(BookADO db, string procedureName) 
        {
         try
            {
                db.Connect();
                db.Command.CommandType = CommandType.StoredProcedure;
                db.Command.CommandText = procedureName;

                if (procedureName == "InsertProcedure" || procedureName == "UpdateProcedure")
                {
                    SqlParameter[] parameters = new SqlParameter[13];
                    parameters[0] = new SqlParameter("@bookId", this.bookId);
                    parameters[1] = new SqlParameter("@authorId", this.authorId);
                    parameters[2] = new SqlParameter("@publisherId", this.publisherId);
                    parameters[3] = new SqlParameter("@sellerId", this.sellerId);
                    parameters[4] = new SqlParameter("@pages", this.pages);
                    parameters[5] = new SqlParameter("@bookName", this.bookName);
                    parameters[6] = new SqlParameter("@authorName", this.authName);
                    parameters[7] = new SqlParameter("@surname", this.authSurname);
                    parameters[8] = new SqlParameter("@publisherName", this.publisher);
                    parameters[9] = new SqlParameter("@sellerName", this.seller);
                    parameters[10] = new SqlParameter("@bookAmount", this.bookAmount);
                    parameters[11] = new SqlParameter("@sellAmount", this.sellerAmount);
                    parameters[12] = new SqlParameter("@releaseDate", this.year);

                    db.Command.Parameters.Clear();
                    foreach (SqlParameter param in parameters)
                    {
                        param.Direction = ParameterDirection.Input;
                        db.Command.Parameters.Add(param);
                    }
                    

                }
                else { }


                db.Command.ExecuteNonQuery();
                db.Disconnect();
                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

        }
    }
}
