using System.Collections.Generic;

namespace ApiSqlCrud.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMassage{ get; set; }
        //public Book Book { get; set; }

        private string ex = null;

        public string exception
        {
            get 
            {
                //return exception = ex ?? "All Things Are Good";
                //if (exception is not null)
                //{
                //    return exception;
                //}
                //return exception;
                return ex ?? "All Things Are Good";
            }
            set
            {
                ex = value;
            }
           
        }

        public List<Book> listOfBooks { get; set; }
    }
}
