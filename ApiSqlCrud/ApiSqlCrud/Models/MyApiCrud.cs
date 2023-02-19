using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ApiSqlCrud.Models
{
    public class MyApiCrud  : MyConnection
    {
        //public List<Book> listBook = new List<Book>();

        public Response GetAllBooks(string commandText)
        {
            Response response= new Response();
            DataTable dt = new DataTable();
            List<Book> list = new List<Book>();

            try
            {
                Connect();
                using (SqlDataAdapter sqlData = new SqlDataAdapter(commandText, mySqlConnection))
                {
                    sqlData.Fill(dt);

                    try
                    {
                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                Book newBook = new Book();

                                newBook.Id = (int)dt.Rows[i]["Id"];
                                newBook.Name = dt.Rows[i]["Name"].ToString();
                                newBook.Pages = (int)dt.Rows[i]["Pages"];
                                newBook.RelaseDate = dt.Rows[i]["RelaseDate"].ToString();
                                newBook.Author = (string)dt.Rows[i]["Author"];

                                list.Add(newBook);
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {

                        response.exception = ex.Message;
                    }
                    finally
                    {
                        Disconnect();
                    }

                    if (list.Count > 0)
                    {
                        response.StatusCode = 200;
                        response.StatusMassage = "Data Found";

                        response.listOfBooks = list;
                    }
                    else
                    {
                        response.StatusCode = 100;
                        response.StatusMassage = "No Data Found";
                        response.listOfBooks = null;
                    }

                }
            }
            catch (System.Exception ex)
            {

                response.exception = ex.Message;
            }
           

            return response;
        }

        public Response AddBook(string commandText, BookDTO bookDTO)
        {
                Response response = new Response();
                int result = 0;

                try
                {
                    //Book book = new Book();
                    Connect();
                    SqlCommand insertCommand = new SqlCommand(commandText, mySqlConnection);
                    insertCommand.CommandType = CommandType.StoredProcedure;

                    insertCommand.Parameters.AddWithValue("@Name", bookDTO.Name);
                    insertCommand.Parameters.AddWithValue("@Pages", bookDTO.Pages);
                    insertCommand.Parameters.AddWithValue("@RelaseDate", bookDTO.RelaseDate);
                    insertCommand.Parameters.AddWithValue("@Author", bookDTO.Author);

                    result = insertCommand.ExecuteNonQuery();
                }
                catch (System.Exception ex)
                {

                    response.exception = ex.Message;
                //response.ex = ex.Message;
                }
                finally
                {
                    Disconnect();
                }

                if (result <0)
                {
                    response.StatusCode = 200;
                    response.StatusMassage = "Book Added";
                }
                else
                {
                    response.StatusCode = 100;
                    response.StatusMassage = "No Data Inserted";
                }

            

            return response;
        }

        public Response UpdateBook(string commandText,BookDTO bookDTO, int id)
        {
                Response response = new Response();
                int result = 0;

                try
                {
                    //Book book = new Book();
                    Connect();
                    SqlCommand insertCommand = new SqlCommand(commandText, mySqlConnection);
                    insertCommand.CommandType = CommandType.StoredProcedure;

                    insertCommand.Parameters.AddWithValue("@Name", bookDTO.Name);
                    insertCommand.Parameters.AddWithValue("@Author", bookDTO.Author);
                    insertCommand.Parameters.AddWithValue("@Pages", bookDTO.Pages);
                    insertCommand.Parameters.AddWithValue("@RelaseDate", bookDTO.RelaseDate);
                    insertCommand.Parameters.AddWithValue("@bookId", id);

                    result = insertCommand.ExecuteNonQuery();

                }
                catch (System.Exception ex)
                {

                    response.exception = ex.Message;
                }
                finally
                {
                    Disconnect();
                }

                if (result <0)
                {
                    response.StatusCode = 200;
                    response.StatusMassage = "Book Updated";
                }
                else
                {
                    response.StatusCode = 100;
                    response.StatusMassage = "No Data Updated";
                }

            

            return response;
        }

        public Response DeleteBook(string commandText, int id)
        {
                Response response = new Response();
                int result = 0;

                try
                {
                    Connect();
                    SqlCommand insertCommand = new SqlCommand(commandText, mySqlConnection);
                    insertCommand.CommandType = CommandType.StoredProcedure;

                    insertCommand.Parameters.AddWithValue("@bookId", id);
                    result = insertCommand.ExecuteNonQuery();
                }
                catch (System.Exception ex)
                {
                    
                    response.exception = ex.Message;
                }
                finally
                {
                    Disconnect();
                }

                if (result <0)
                {
                    response.StatusCode = 200;
                    response.StatusMassage = "Book Deleted";
                }
                else
                {
                    response.StatusCode = 100;
                    response.StatusMassage = "No Data Deleted";
                }

            

            return response;
        }
    }
}
